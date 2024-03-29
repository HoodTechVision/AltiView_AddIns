﻿using System;
using System.Windows;
using System.AddIn;
using System.AddIn.Contract;
using System.AddIn.Pipeline;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using AddInContract;

using HostViews;

namespace HostSideAdapters {
    /// <summary>
    /// Adapts the add-in contract to the host's view of the add-in
    /// </summary>
    [HostAdapter]
    public class WPFAddIn_ContractToViewHostSideAdapter : IWPFAddInHostView {
        IWpfAddInContract wpfAddInContract;
        ContractHandle wpfAddInContractHandle;

        public WPFAddIn_ContractToViewHostSideAdapter(IWpfAddInContract wpfAddInContract) {
            // Adapt the contract (IWPFAddInContract) to the host application's
            // view of the contract (IWPFAddInHostView)
            this.wpfAddInContract = wpfAddInContract;

            // Prevent the reference to the contract from being released while the
            // host application uses the add-in
            this.wpfAddInContractHandle = new ContractHandle(wpfAddInContract);
        }

        public FrameworkElement GetAddInUI() {
            // Convert the INativeHandleContract that was passed from the add-in side
            // of the isolation boundary to a FrameworkElement
            INativeHandleContract inhc = this.wpfAddInContract.GetAddInUI();
            FrameworkElement fe = FrameworkElementAdapters.ContractToViewAdapter(inhc);
            return fe;
        }

        public bool Shutdown() {
            wpfAddInContract.Shutdown();
            return true;
        }
    }
}
