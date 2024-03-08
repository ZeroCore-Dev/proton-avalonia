using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.ReactiveUI;
using proton_avalonia.ViewModels;

namespace proton_avalonia.Views
{
    public partial class QuickWindow : ReactiveWindow<QuickWindowViewModel>
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
                this.ViewModel = null;
                this.Close();
            }
        }

        private void Window_LostFocus(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            this.ViewModel = null;
            this.Close();
        }

        //private void Binding_1(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        //{
        //}

        //private void Window_LostFocus_1(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        //{
        //}
    }
}
