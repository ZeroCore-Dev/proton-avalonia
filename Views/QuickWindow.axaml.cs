using Avalonia.Controls;
using Avalonia.Input;

namespace proton_avalonia.Views
{
    public partial class QuickWindow : Window
    {
        public QuickWindow()
        {
            InitializeComponent();
            this.AddHandler(KeyDownEvent, ExitQuickWindow, Avalonia.Interactivity.RoutingStrategies.Tunnel);
        }

        public void ExitQuickWindow(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                this.Close();
            }
        }
    }
}
