using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using proton_avalonia.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proton_avalonia.Module.CommandExec;
using proton_avalonia.ViewModels;

namespace proton_avalonia.Module.CommandExec
{
    public class CommandExecModule : ModuleViewModelBase
    {
        public CommandExecModule(QuickWindowViewModel windowTarget = null) : base(windowTarget) 
        {
            //UserControl = new CommandExecView();
            //CommandResult = "test";
            //UserControl.DataContext = this;
        }

        public override string getSeparatorColor() { return "Grey"; }
        public override string getQuickWindowIcon() { return "avares://proton_avalonia/Assets/CommandIcon.png"; }
        public override void handlePrompt(string prompt) 
        {
            QuickWindowVM.window.Height = 396;
            QuickWindowVM.SetHtml("<div>" + prompt + "</div>");
        }
    }
}
