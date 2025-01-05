using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductStore_BussinessLayer.Dtos;

namespace ProductStore_BussinessLayer.Orders
{
    public interface IOrderService
    {
        Task<List<ShowOrderDto>> GetAllOrdersAsync();


        Task<List<ShowOrderDto>> GetOrdersByUserID(int UserId);


        Task<bool> CreateOrderAsync(CreateOrderDto DTO);

    }
}
