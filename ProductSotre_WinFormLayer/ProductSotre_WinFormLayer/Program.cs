
using ProductStore_DependencyInjectionLayer;
using System;
using System.Windows.Forms;

namespace ProductSotre_WinFormLayer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // إعداد DI
            var container = DependencyInjectionConfig.RegisterComponents();

            // إنشاء النموذج الرئيسي باستخدام DI
            var mainForm = container.Resolve<Form1>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(mainForm);
        }
    }
}
