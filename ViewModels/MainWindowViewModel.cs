using proton_avalonia.Views;

namespace proton_avalonia.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
#pragma warning disable CA1822 // Mark members as static
        public string Greeting { get; set; } = "Welcome to Avalonia!";
#pragma warning restore CA1822 // Mark members as static

        //public QuickWindow quickWindow { get; set; } = new QuickWindow();

        private QuickWindowViewModel quickWindowVM = new();

        public MainWindowViewModel() {}


        public void ClickHandler()
        {
            var quickWindow = new QuickWindow();

            quickWindow.ViewModel = quickWindowVM;
            quickWindowVM.setWindow(quickWindow);

            quickWindow.Show();
        }
    }
}
