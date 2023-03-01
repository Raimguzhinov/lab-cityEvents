using System.Collections.ObjectModel;
using Avalonia.Media.Imaging;
using CityEvents.Models;
using ReactiveUI;

namespace CityEvents.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private ObservableCollection<TabViewModel> _tabs = null!;
    private TabHeaderViewModel[] _headers = null!;
    private ViewModelBase? _currentTab = null!;

    public ObservableCollection<TabViewModel> Tabs
    {
        get => _tabs;
        set => this.RaiseAndSetIfChanged(ref _tabs, value);
    }
    

    public TabHeaderViewModel[] Headers
    {
        get => _headers;
        set => this.RaiseAndSetIfChanged(ref _headers, value);
    }

    public ViewModelBase? CurrentTab
    {
        get => _currentTab;
        set => this.RaiseAndSetIfChanged(ref _currentTab, value);
    }

    public MainWindowViewModel()
    {
        Headers = new[]
        {
            new TabHeaderViewModel
            {
                IconPath = "../../../Assets/icon.png",
                Title = "Tab 1"
            },
            new TabHeaderViewModel
            {
                IconPath = "../../../Assets/icon.png",
                Title = "Tab 2"
            },
            new TabHeaderViewModel
            {
                IconPath = "../../../Assets/icon.png",
                Title = "Tab 3"
            }
        };

        Tabs = new ObservableCollection<TabViewModel>
        {
            new TabViewModel
            {
                Icon = new Bitmap(Headers[0].IconPath),
                Name = Headers[0].Title,
                Content = new Tab1ViewModel()
            },
            new TabViewModel
            {
                Icon = new Bitmap(Headers[1].IconPath),
                Name = Headers[1].Title,
                Content = new Tab2ViewModel()
            },
            new TabViewModel
            {
                Icon = new Bitmap(Headers[2].IconPath),
                Name = Headers[2].Title,
                Content = new Tab3ViewModel()
            }
        };

        CurrentTab = Tabs[0].Content;
    }
}

