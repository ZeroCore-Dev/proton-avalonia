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


namespace proton_avalonia.ViewModels
{
    public class QuickWindowViewModel: ViewModelBase
    {

        public Bitmap? QuickIconFromResource { get; set; } = ImageHelper.LoadFromResource(new Uri("avares://proton_avalonia/Assets/SearchIcon.png"));
        public Task<Bitmap?>? QuickIconFromWebsite { get; } = ImageHelper.LoadFromWeb(new Uri("https://upload.wikimedia.org/wikipedia/commons/4/41/NewtonsPrincipia.jpg"));


        public string WatermarkPrompt { get; set; } = "Type here to search...";

        //public event PropertyChangedEventHandler? PropertyChanged;

        //protected virtual void OnPropertyChanged(string propertyName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}

    }

    //public partial class QuickWindowViewModel: ObservableObject
    //{

    //    [ObservableProperty]
    //    private Bitmap? _QuickIconFromResource = ImageHelper.LoadFromResource(new Uri("avares://proton_avalonia/Assets/SearchIcon.png"));

    //    [ObservableProperty]
    //    private Task<Bitmap?>? _QuickIconFromWebsite;

    //    [ObservableProperty]
    //    private string _WatermarkPrompt = string.Empty;

    //}
}
