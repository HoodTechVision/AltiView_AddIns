using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.AddIn.Pipeline;
using System.Windows;

namespace AddInViews
{
    [AddInBase]
    public interface IWPFAddInView {
        FrameworkElement GetAddInUI();
        bool Shutdown();
    }
    
}
