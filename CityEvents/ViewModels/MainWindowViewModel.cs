using System.Collections.ObjectModel;
using CityEvents.Models;

namespace CityEvents.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<CityEvent> Events { get; } = new ObservableCollection<CityEvent>();

        public MainWindowViewModel()
        {
            CityEvent[] events = Serializer<CityEvent[]>.Load("../../../../events.xml");
            foreach (var e in events)
            {
                Events.Add(e);
            }

            Events.Add(new CityEvent());
        }
    }
}