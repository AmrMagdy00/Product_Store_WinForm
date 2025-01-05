using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductStore_DataAccessLayer.Interfaces;

namespace ProductStore_DataAccessLayer.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _context;

        public OrderRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateOrderAsync (Order NewOrder)
        {
            _context.Orders.Add(NewOrder);
            var Product = _context.Products.Find(NewOrder.ProductID);
            
                Product.InStock -= NewOrder.Quantity;
                _context.Entry(Product).State = EntityState.Modified;
            
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task< List<Order>> GetOrdersByUserIDAsync(int UserId)
        {
           var Orders  = await _context.Orders.Include(x=>x.Product).Include(x=>x.Status).Where(s=>s.UserID == UserId).ToListAsync();
            return Orders;
        }

        public async Task<List<Order>> GetAllOrdersAsync()
        {
            var Orders = await _context.Orders.Include(x => x.Product).Include(x => x.Status).ToListAsync();
            return Orders;
        }
    }
}
