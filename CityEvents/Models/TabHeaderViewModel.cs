using System.Collections.Generic;
using Avalonia.Media.Imaging;
using CityEvents.ViewModels;
using ReactiveUI;

namespace CityEvents.Models;
public class TabHeaderViewModel : ViewModelBase
{
    private readonly string? _title;
    private readonly string? _iconPath;

    public string? Title
    {
        get => _title;
        init => this.RaiseAndSetIfChanged(ref _title, value);
    }

    public string? IconPath
    {
        get => _iconPath;
        init => this.RaiseAndSetIfChanged(ref _iconPath, value);
    }
}

public class TabViewModel : ViewModelBase
{
    public Bitmap? Icon { get; set; }
    public string? Name { get; set; }
    public ViewModelBase? Content { get; init; }
}

public class Tab1ViewModel : ViewModelBase
{
    public string ImageUrl { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }

    public Tab1ViewModel()
    {
        ImageUrl = "path/to/image.png";
        Title = "Tab 1 Title";
        Description = "Tab 1 Description";
    }
}

public class Tab2ViewModel : ViewModelBase
{
    public string ImageUrl { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }

    public Tab2ViewModel()
    {
        ImageUrl = "path/to/image.png";
        Title = "Tab 2 Title";
        Description = "Tab 2 Description";
    }
}

public class Tab3ViewModel : ViewModelBase
{
    public string ImageUrl { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }

    public Tab3ViewModel()
    {
        ImageUrl = "path/to/image.png";
        Title = "Tab 3 Title";
        Description = "Tab 3 Description";
    }
}
