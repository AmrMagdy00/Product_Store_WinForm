using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ProductSotre_WindowsFormLayer.Factory;
using ProductStore_BussinessLayer.Dtos;
using ProductStore_BussinessLayer.Orders;
using ProductStore_BussinessLayer.Products;

namespace ProductSotre_WindowsFormLayer.User
{

    public partial class UserForm : Form
    {
        public Action OnFormClosed;


        private readonly IProductsService _productsService;
        private readonly IOrderService _orderService;
        private readonly IFormFactory _formFactory;

        public UserForm(IProductsService ProductsService,IOrderService OrderService, IFormFactory formFactory)
        {
            InitializeComponent();
            _productsService = ProductsService;
            _orderService = OrderService;
            _formFactory = formFactory;


        }

        private void AddCheckBoxAndQuantityToGridView()
        {
   

            DataGridViewCheckBoxColumn selectColumn = new DataGridViewCheckBoxColumn();
            selectColumn.HeaderText = "Select";
            selectColumn.Name = "SelectProduct";
            selectColumn.Width = 60;


            DataGridViewTextBoxColumn quantityColumn = new DataGridViewTextBoxColumn();
            quantityColumn.HeaderText = "Quantity";
            quantityColumn.Name = "Quantity";
            quantityColumn.Width = 100;
            quantityColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            quantityColumn.ReadOnly = true;

            dgvProducts.Columns.Add(selectColumn);
            dgvProducts.Columns.Add(quantityColumn);
        }

        private void CustomizeDataGridView(DataGridView dgv)
        {
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgv.DefaultCellStyle.Font = new Font("Arial", 10);

            dgv.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.RowsDefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;

            dgv.ScrollBars = ScrollBars.Both;

        }

        private async void UserForm_Load(object sender, EventArgs e)
        {

            LoadProductsInfo();
            LoadOrdersInfo();
        }
        private async void LoadProductsInfo()
        {
            dgvProducts.Columns.Clear();

            var Products = await _productsService.GetAllProductsAsync();
            if (Products != null)
            {
                dgvProducts.DataSource = Products;
                foreach (DataGridViewColumn column in dgvProducts.Columns)
                {
                    if (column.Name != "SelectProduct")
                    {
                        column.ReadOnly = true;
                    }
                }

                AddCheckBoxAndQuantityToGridView();
                CustomizeDataGridView(dgvProducts);
            }
        }
        private async void LoadOrdersInfo ()
        {
            var Orders = await _orderService.GetOrdersByUserID(CurrentUserInfo.CurrentUser.Id);
            if (Orders != null)
            {
   
                dgvOrders.DataSource = Orders;
                CustomizeDataGridView(dgvOrders);
                dgvOrders.ReadOnly = true;

            }

        }
        private void button1_Click(object sender, EventArgs e)
        {


            var selectedProductsTable = new DataTable();
            selectedProductsTable.Columns.Add("ID", typeof(int));
            selectedProductsTable.Columns.Add("Title", typeof(string));
            selectedProductsTable.Columns.Add("Price", typeof(decimal));
            selectedProductsTable.Columns.Add("Quantity", typeof(int));

            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                if (row.Cells["SelectProduct"].Value != null && Convert.ToInt32(row.Cells["Quantity"].Value) > 0)
                {

                    var id = Convert.ToInt32(row.Cells["ID"].Value);
                    var title = row.Cells["Title"].Value.ToString();
                    var price = Convert.ToDecimal(row.Cells["Price"].Value);
                    var quantity = Convert.ToInt32(row.Cells["Quantity"].Value);

                    selectedProductsTable.Rows.Add(id, title, price, quantity);
                }
            }

            if (selectedProductsTable.Rows.Count > 0)
            {

                var form = _formFactory.CreateForm<CheckOutForm>();
                form.ConfirmedPurchase = UpdateProductStock;
                form.SetSelectedProducts(selectedProductsTable);
                form.ShowDialog();
                LoadOrdersInfo();

            }
            else
            {
                MessageBox.Show("Please Choose At Least 1 Product And Write Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void UpdateProductStock(DataTable selectedProductsTable)
        {
            foreach (DataRow row in selectedProductsTable.Rows)
            {
                int productId = Convert.ToInt32(row["ID"]);          
                int quantityPurchased = Convert.ToInt32(row["Quantity"]); 

                foreach (DataGridViewRow dgvRow in dgvProducts.Rows)
                {
                    if (Convert.ToInt32(dgvRow.Cells["ID"].Value) == productId)
                    {
                        int currentStock = Convert.ToInt32(dgvRow.Cells["InStock"].Value);
                        dgvRow.Cells["InStock"].Value = currentStock - quantityPurchased;
                        dgvRow.Cells["SelectProduct"].Value = false;
                        dgvRow.Cells["Quantity"].Value = null;
                        break;
                    }
                }
            }

        }
        private void dgvProducts_CellValidating_1(object sender, DataGridViewCellValidatingEventArgs e)
        {


            if (dgvProducts.Columns[e.ColumnIndex].Name == "Quantity")
            {

                var enteredValueInString = e.FormattedValue.ToString();
                if (enteredValueInString == "")
                {
                    return;

                }



                if (!int.TryParse(enteredValueInString, out int enteredQuantity))
                {

                    MessageBox.Show("Please enter a valid number.");
                    e.Cancel = true;
                }
                if (enteredQuantity <= 0)
                {

                    MessageBox.Show("Please enter a valid number.");
                    e.Cancel = true;
                }
                else
                {
                    int availableStock = Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells["InStock"].Value);

                    if (enteredQuantity > availableStock)
                    {
                        MessageBox.Show($"The quantity exceeds the available stock ({availableStock}). Please enter a valid quantity.");
                        e.Cancel = true;
                    }
                }
            }
        }
        private void dgvProducts_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProducts.Columns[e.ColumnIndex].Name == "SelectProduct")
            {
                bool isSelected = Convert.ToBoolean(dgvProducts.Rows[e.RowIndex].Cells["SelectProduct"].Value);
                dgvProducts.Rows[e.RowIndex].Cells["Quantity"].ReadOnly = !isSelected;

            }
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnFormClosed?.Invoke();

        }

    }
}
