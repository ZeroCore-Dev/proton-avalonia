using proton_avalonia.Views;

namespace proton_avalonia.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
#pragma warning disable CA1822 // Mark members as static
        public string Greeting { get; set; } = "Welcome to Avalonia!";
#pragma warning restore CA1822 // Mark members as static

        //public QuickWindow quickWindow { get; set; } = new QuickWindow();

        public void ClickHandler()
        {
            var quickWindow = new QuickWindow();
            quickWindow.Show();
        }
    }
}
