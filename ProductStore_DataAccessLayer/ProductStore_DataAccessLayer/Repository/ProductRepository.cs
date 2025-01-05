using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Dynamic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using ProductStore_DataAccessLayer.Interfaces;

namespace ProductStore_DataAccessLayer.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }


        public async Task<List<Product>>  GetAllProductsAsync ()
        {
            var Products = await _context.Products.Include(x => x.Category).ToListAsync();
          
            return Products;
        }

        //public async Task<bool> AddProdcut (Product product)
        //{

        //    try
        //    {
        //        _context.Products.Add(product);
        //        await _context.SaveChangesAsync();

        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //        return false;
        //    }

        //}
    }
}
