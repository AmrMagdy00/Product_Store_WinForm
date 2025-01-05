using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductStore_BussinessLayer.Dtos;
using ProductStore_BussinessLayer.Orders;

namespace ProductSotre_WindowsFormLayer.User
{
    public partial class CheckOutForm : Form
    {

        public Action<DataTable> ConfirmedPurchase;

        private readonly IOrderService _orderService;
        private DataTable _selectedProducts;

        decimal totalPrice =0;
        public CheckOutForm(IOrderService OrderService)
        {
            InitializeComponent();

            _orderService = OrderService;
   
        }

        public void SetSelectedProducts(DataTable selectedProducts)
        {
            _selectedProducts = selectedProducts;
        }

        private void CheckOutForm_Load(object sender, EventArgs e)
        {
            CustomizeDataGridView();

            dgvProducts.DataSource = _selectedProducts;
            dgvProducts.ReadOnly = true;
          
            foreach (DataRow row in _selectedProducts.Rows)
            {
     
                    totalPrice += Convert.ToDecimal(row["Price"]);
            }

            lblTotalPriceCount.Text = $"{totalPrice}$";

        }

        private void CustomizeDataGridView()
        {
            dgvProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvProducts.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;

            dgvProducts.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgvProducts.DefaultCellStyle.Font = new Font("Arial", 10);

            dgvProducts.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            dgvProducts.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvProducts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dgvProducts.RowsDefaultCellStyle.BackColor = Color.White;
            dgvProducts.RowsDefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;

            dgvProducts.ScrollBars = ScrollBars.Both;

        }


        private async void btnConfirm_Click(object sender, EventArgs e)
        {

            CreateOrderDto NewOrder = new CreateOrderDto();

            NewOrder.UserID = CurrentUserInfo.CurrentUser.Id;
            NewOrder.StatusID = 1;
            NewOrder.DateRequested = DateTime.Now;
            NewOrder.TotalPrice = totalPrice;
            NewOrder.ShippingAddress = txtShippingAddress.Text;

            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }
                NewOrder.ProductID = Convert.ToInt32(row.Cells["ID"].Value);
                NewOrder.Quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                await _orderService.CreateOrderAsync(NewOrder);

            }
            MessageBox.Show("Your Order Has Created Succesfuuly");
            ConfirmedPurchase?.Invoke(_selectedProducts);
            this.Close();
        }
    }
}
