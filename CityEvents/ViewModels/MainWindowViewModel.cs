using System.Collections.ObjectModel;
using Avalonia.Media;
using CityEvents.Models;
using ReactiveUI;

namespace CityEvents.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<EventCategory>? _category;

        public MainWindowViewModel()
        {
            EventCategory = new ObservableCollection<EventCategory>();
            EventCategory.Add(new EventCategory { Name = "RedName", Color = new SolidColorBrush(Colors.Red) });
            EventCategory.Add(new EventCategory { Name = "GreenName", Color = new SolidColorBrush(Colors.Green) });
            EventCategory.Add(new EventCategory { Name = "PurpleName", Color = new SolidColorBrush(Colors.Purple) });
            EventCategory.Add(new EventCategory { Name = "BlueName", Color = new SolidColorBrush(Colors.Blue) });
            EventCategory.Add(new EventCategory { Name = "OrangeName", Color = new SolidColorBrush(Colors.Orange) });
            EventCategory.Add(new EventCategory { Name = "RedName", Color = new SolidColorBrush(Colors.Red) });
            EventCategory.Add(new EventCategory { Name = "GreenName", Color = new SolidColorBrush(Colors.Green) });
            EventCategory.Add(new EventCategory { Name = "PurpleName", Color = new SolidColorBrush(Colors.Purple) });
            EventCategory.Add(new EventCategory { Name = "BlueName", Color = new SolidColorBrush(Colors.Blue) });
            EventCategory.Add(new EventCategory { Name = "OrangeName", Color = new SolidColorBrush(Colors.Orange) });
            EventCategory.Add(new EventCategory { Name = "RedName", Color = new SolidColorBrush(Colors.Red) });
            EventCategory.Add(new EventCategory { Name = "GreenName", Color = new SolidColorBrush(Colors.Green) });
            EventCategory.Add(new EventCategory { Name = "PurpleName", Color = new SolidColorBrush(Colors.Purple) });
            EventCategory.Add(new EventCategory { Name = "BlueName", Color = new SolidColorBrush(Colors.Blue) });
            EventCategory.Add(new EventCategory { Name = "OrangeName", Color = new SolidColorBrush(Colors.Orange) });
            EventCategory.Add(new EventCategory { Name = "RedName", Color = new SolidColorBrush(Colors.Red) });
            EventCategory.Add(new EventCategory { Name = "GreenName", Color = new SolidColorBrush(Colors.Green) });
            EventCategory.Add(new EventCategory { Name = "PurpleName", Color = new SolidColorBrush(Colors.Purple) });
            EventCategory.Add(new EventCategory { Name = "BlueName", Color = new SolidColorBrush(Colors.Blue) });
            EventCategory.Add(new EventCategory { Name = "OrangeName", Color = new SolidColorBrush(Colors.Orange) });
        }

        public ObservableCollection<EventCategory>? EventCategory
        {
            get { return _category; }
            set
            {
                this.RaiseAndSetIfChanged(ref _category, value);
            }
        }
    }
}