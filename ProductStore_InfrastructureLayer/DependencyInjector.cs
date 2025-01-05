using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductSotre_WindowsFormLayer.Admin;
using ProductSotre_WindowsFormLayer.Login;
using ProductSotre_WindowsFormLayer.User;
using ProductStore_BussinessLayer.Orders;
using ProductStore_BussinessLayer.Products;
using ProductStore_BussinessLayer.Users;
using ProductStore_DataAccessLayer.Interfaces;
using ProductStore_DataAccessLayer.Repository;
using Unity;

namespace ProductStore_InfrastructureLayer
{
    public static class DependencyInjector
    {
        private static readonly IUnityContainer container = new UnityContainer();

        public static void RegisterDependencies()
        {
       
            container.RegisterType<IOrderRepository, OrderRepository>();
            container.RegisterType<IUserRepository, UserRepository>();
            container.RegisterType<IProductRepository, ProductRepository>();


            container.RegisterType<IUserService, UserService>();
            container.RegisterType<IProductsService, ProductsService>();
            container.RegisterType<IOrderService, OrderService>();

   

            container.RegisterType<LoginForm>();
            container.RegisterType<AdminForm>();
            container.RegisterType<AddNewProductForm>();
            container.RegisterType<UserForm>();
            container.RegisterType<CheckOutForm>();


        }

        public static IUnityContainer Container => container;
    }
}
