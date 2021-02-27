using System.Windows;
namespace HostViews
{
    public interface IWPFAddInHostView
    {
        FrameworkElement GetAddInUI();
        bool Shutdown();
    }
}
