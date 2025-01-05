using System;

using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using ProductSotre_WindowsFormLayer.Admin;
using ProductSotre_WindowsFormLayer.Factory;
using ProductSotre_WindowsFormLayer.Login;
using ProductSotre_WindowsFormLayer.User;
using ProductStore_BussinessLayer.Orders;
using ProductStore_BussinessLayer.Products;
using ProductStore_BussinessLayer.Users;
using ProductStore_DataAccessLayer;
using ProductStore_DataAccessLayer.Interfaces;
using ProductStore_DataAccessLayer.Repository;

namespace ProductSotre_WindowsFormLayer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var services = new ServiceCollection();

            services.AddScoped<AppDbContext>(provider => new AppDbContext());

            services.AddSingleton<IFormFactory, FormFactory>();

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IProductsService, ProductsService>();

            services.AddTransient<LoginForm>();
            services.AddTransient<AdminForm>();
            services.AddTransient<UserForm>();
            services.AddTransient<CheckOutForm>();
            services.AddTransient<AddNewProductForm>();




            var serviceProvider = services.BuildServiceProvider();

            var loginForm = serviceProvider.GetRequiredService<LoginForm>();

            Application.Run(loginForm);
        }
    }
}
