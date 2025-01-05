using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductStore_BussinessLayer.Orders;
using ProductStore_BussinessLayer.Products;

namespace ProductSotre_WindowsFormLayer.Admin
{
    public partial class AdminForm : Form


    {
        public Action onFormClosed;

        private readonly IProductsService _productsService;
        private readonly IOrderService _orderService;
        public AdminForm(IProductsService ProductsService , IOrderService OrderService)
        {
            _productsService = ProductsService;
            _orderService = OrderService;
            InitializeComponent();
  
        }

        private async void AdminForm_Load(object sender, EventArgs e)
        {

            LoadProducts();
            LoadOrders();
        }

        private async void LoadProducts()
        {
            var Products = await _productsService.GetAllProductsAsync();
            if (Products != null)
            {
                dgvProducts.DataSource = Products;
                CustomizeDataGridView(dgvProducts);

            }


        }

        private async void LoadOrders()
        {
            var Orders = await _orderService.GetAllOrdersAsync();
            if (Orders!=null)
            {
                dgvOrders.DataSource = Orders;
                CustomizeDataGridView(dgvOrders);

            }
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

        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tpxMain.SelectedIndex==0)
            {
                dgvProducts.Columns.Clear();
                 LoadProducts();
            }
            else
            {
                dgvOrders.Columns.Clear();
                LoadOrders();
            }


        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
          onFormClosed?.Invoke();

    }
}
}
