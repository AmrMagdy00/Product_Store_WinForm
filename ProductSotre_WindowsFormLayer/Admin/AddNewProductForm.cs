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
using ProductStore_BussinessLayer.Products;

namespace ProductSotre_WindowsFormLayer.Admin
{
    public partial class AddNewProductForm : Form
    {
       private readonly IProductsService _productsService;

        public AddNewProductForm(IProductsService ProductsService)
        {
            _productsService = ProductsService;
        }
        private bool CheckValidations()
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) || txtTitle.Text.Length < 10)
            {
                MessageBox.Show("Title must be at least 10 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtDescription.Text.Length > 500)
            {
                MessageBox.Show("Description must not exceed 500 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Price must be a positive number greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Uri.IsWellFormedUriString(txtImageUrl.Text, UriKind.Absolute))
            {
                MessageBox.Show("Image URL must be a valid URL.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtInStock.Text, out int inStock) || inStock < 1)
            {
                MessageBox.Show("In Stock must be a number greater than or equal to 1.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cbCategory.SelectedItem == null)
            {
                MessageBox.Show("Please select a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        //private async void btnAddProduct_Click(object sender, EventArgs e)
        //{
        //    if (CheckValidations())
        //    {
        //        var ProductDto = CreateProductDto();
        //        await _productsService.AddProdcut(ProductDto);
        //    }
        //}

        private ProductDTO CreateProductDto()
        {
            ProductDTO DTO = new ProductDTO();
            DTO.Title = txtTitle.Text;
            DTO.Description = txtDescription.Text;
            DTO.Price = Convert.ToDecimal(txtPrice.Text);
            DTO.ImageUrl = txtImageUrl.Text;
            DTO.Category = cbCategory.SelectedItem.ToString();
            DTO.InStock = Convert.ToInt32(txtInStock.Text);

            return DTO;


        }

        private void AddNewProductForm_Load(object sender, EventArgs e)
        {

        }
    }
}
