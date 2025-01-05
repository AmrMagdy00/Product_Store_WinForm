using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using ProductStore_BussinessLayer.Dtos;
using ProductStore_BussinessLayer.Mapper;
using ProductStore_DataAccessLayer;
using ProductStore_DataAccessLayer.Interfaces;
using ProductStore_DataAccessLayer.Repository;

namespace ProductStore_BussinessLayer.Orders
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repository;

        public OrderService(IOrderRepository Repository)
        {
            _repository = Repository;
        }

        public async Task<bool> CreateOrderAsync(CreateOrderDto DTO)
        {
            var Order = DTO.ToOrder();
            return await _repository.CreateOrderAsync(Order);
        }

        public async Task<List<ShowOrderDto>> GetOrdersByUserID(int UserId)
        {
            var Orders = await _repository.GetOrdersByUserIDAsync(UserId);
            if (Orders == null || !Orders.Any())
            {
                return null; 
            }
       
            
                var OrdersDTO = Orders.Select(x => x.ToDTO()).ToList();
                return OrdersDTO;

        }


        public async Task<List<ShowOrderDto>> GetAllOrdersAsync()
        {
            var Orders = await _repository.GetAllOrdersAsync();
            var OrdersDTO = Orders.Select(x => x.ToDTO()).ToList();
            return OrdersDTO;
        }


    }
}
