using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore_DataAccessLayer.Interfaces
{
    public interface IOrderRepository
    {
        Task<List<Order>> GetAllOrdersAsync();
        Task<List<Order>> GetOrdersByUserIDAsync(int UserId);
        Task<bool> CreateOrderAsync(Order NewOrder);


    }
}
