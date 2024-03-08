using Avalonia.Media;
using proton_avalonia.ViewModels;
using proton_avalonia.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proton_avalonia.Module
{
    public class EverythingSearchViewModel : ModuleViewModelBase
    {
        public EverythingSearchViewModel(QuickWindowViewModel windowTarget = null) : base(windowTarget) { }

        public override string getSeparatorColor() { return "Grey"; }
        public override string getQuickWindowIcon() { return "avares://proton_avalonia/Assets/SearchIcon.png"; }

        public override void handlePrompt(string prompt) { }
    }
}
