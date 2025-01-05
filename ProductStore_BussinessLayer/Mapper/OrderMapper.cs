using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductStore_BussinessLayer.Dtos;
using ProductStore_DataAccessLayer;

namespace ProductStore_BussinessLayer.Mapper
{
    public static class OrderMapper
    {
        public static Order ToOrder (this CreateOrderDto order)
        {
            Order NewOrder = new Order();
            {
                NewOrder.UserID = order.UserID;
                NewOrder.ProductID = order.ProductID;
                NewOrder.StatusID = order.StatusID;
                NewOrder.Quantity = order.Quantity;
                NewOrder.DateRequested = order.DateRequested;
                NewOrder.TotalPrice = order.TotalPrice;
                NewOrder.ShippingAddress = order.ShippingAddress;

            }
            return NewOrder;
        }

        public static ShowOrderDto ToDTO(this Order order)
        {
            ShowOrderDto NewOrder = new ShowOrderDto();
            {
                NewOrder.ProductName = order.Product.Title;
                NewOrder.Status = order.Status.OrderStatus;
                NewOrder.Quantity = order.Quantity;
                NewOrder.DateRequested = order.DateRequested;
                NewOrder.TotalPrice = order.TotalPrice;
                NewOrder.ShippingAddress = order.ShippingAddress;

            }
            return NewOrder;
        }
    }
}
