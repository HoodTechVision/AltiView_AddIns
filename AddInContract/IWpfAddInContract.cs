using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.AddIn.Contract;
using System.AddIn.Pipeline;

namespace AddInContract {
    /// <summary>
    /// Defines the services that an add-in will provide to a host application.
    /// In this case, the add-in is a UI.
    /// </summary>
    [AddInContract]
    public interface IWpfAddInContract : IContract {
        INativeHandleContract GetAddInUI();
        bool Shutdown();
    }
}
