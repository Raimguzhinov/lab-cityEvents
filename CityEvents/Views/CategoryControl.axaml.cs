using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using CityEvents.Models;

namespace CityEvents.Views;

public partial class CategoryControl : UserControl
{
    public CategoryControl()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
    
    public static readonly StyledProperty<EventCategory> EventCategoryProperty =
        AvaloniaProperty.Register<CategoryControl, EventCategory>(nameof(EventCategory));

    public EventCategory EventCategory
    {
        get { return GetValue(EventCategoryProperty); }
        set { SetValue(EventCategoryProperty, value); }
    }
}