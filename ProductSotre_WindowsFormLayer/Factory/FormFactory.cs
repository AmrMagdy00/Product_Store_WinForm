using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms;

namespace ProductSotre_WindowsFormLayer.Factory
{
    public class FormFactory : IFormFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public FormFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public T CreateForm<T>() where T : Form
        {
            return _serviceProvider.GetRequiredService<T>();
        }
    }
}