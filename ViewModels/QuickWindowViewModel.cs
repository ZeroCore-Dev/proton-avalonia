using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Threading.Tasks;
using Avalonia.Media.Imaging;
using System.IO;
using System.Net.Http;
using Avalonia;
using Avalonia.Platform;

using proton_avalonia.Utils;
using System.ComponentModel;
using Avalonia.Controls;
using proton_avalonia.Views;
using Avalonia.Markup.Xaml;
using System.Collections.Generic;

using proton_avalonia.Module;
using proton_avalonia.Module.CommandExec;


namespace proton_avalonia.ViewModels
{
    public partial class QuickWindowViewModel : ObservableObject
    {
        const int ORIGINAL_HEIGHT = 74;
        const int CONTENTED_HEIGHT = 396;


        public QuickWindowViewModel(QuickWindow? bindingWindow = null)
        {
            window = bindingWindow;
            loadModule(1);
        }

        public void setWindow(QuickWindow bindingWindow)
        {
            window = bindingWindow;
        }

        public QuickWindow window;

        [ObservableProperty]
        private Bitmap? _QuickIconFromResource = ImageHelper.LoadFromResource(new Uri("avares://proton_avalonia/Assets/DefaultIcon.png"));

        [ObservableProperty]
        private Task<Bitmap?>? _QuickIconFromWebsite;

        [ObservableProperty]
        private string _WatermarkPrompt = string.Empty;

        [ObservableProperty]
        private string _QuickWindowTextboxContent = string.Empty;

        [ObservableProperty]
        private string _SeparatorColor = "Transparent";

        [ObservableProperty]
        public UserControl _Content = new UserControl();

        public List<ModuleViewModelBase> Modules { get; set; } = new List<ModuleViewModelBase> { new EverythingSearchViewModel(), new CommandExecModule() };

        //private ModuleViewModelBase? currentModule;

        private int ModuleViewModelIndex = 1;

        [ObservableProperty]
        private ModuleViewModelBase _ModuleViewModel;

        partial void OnQuickWindowTextboxContentChanging(string value)
        {
            Modules[ModuleViewModelIndex].handlePrompt(value);
        }

        private void _loadModule(ModuleViewModelBase target)
        {
            SeparatorColor = target.getSeparatorColor();
            QuickIconFromResource = ImageHelper.LoadFromResource(new Uri(target.getQuickWindowIcon()));
            ModuleViewModel = target;
            target.setVM(this);
        }

        public void loadModule(int target)
        {
            {
                ModuleViewModelIndex = target;
                _loadModule(Modules[target]);
            }
        }

        public void ExitWindow()
        {
            window.Close();
        }

        public void SetHtml(string target)
        {
            window._htmlLabel.Text = target;
            if (string.IsNullOrEmpty(target))
            {
                //window._htmlLabel.InvalidateMeasure();
                //window._htmlLabel.InvalidateVisual();
            }
        }
    }
}
