using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductSotre_WindowsFormLayer.Factory
{
    public interface IFormFactory
    {
        T CreateForm<T>() where T : Form;

    }
}
