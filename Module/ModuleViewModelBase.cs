using Avalonia.Controls;
using Avalonia.Media;
using proton.style.ViewModels;
using proton_avalonia.ViewModels;
using proton_avalonia.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proton_avalonia.Module
{
    public class ModuleViewModelBase: proton_avalonia.ViewModels.ViewModelBase
    {

        public ModuleViewModelBase(QuickWindowViewModel ViewModelTarget= null)
        {
            //window = windowTarget;
            ViewModel = ViewModelTarget;
        }

        //protected QuickWindow? window;
        //public void setWindow(QuickWindow bindingWindow)
        //{
        //    window = bindingWindow;
        //}

        protected QuickWindowViewModel QuickWindowVM;

        public QuickWindowViewModel ViewModel { get; set; }

        public virtual string getSeparatorColor() { return "Transparent"; }

        public virtual string getQuickWindowIcon() { return "avares://proton_avalonia/Assets/DefaultIcon.png"; }

        public virtual void handlePrompt(string prompt) {}

        public void setVM(QuickWindowViewModel windowTarget)
        {
            QuickWindowVM = windowTarget;
        }

    }
}

