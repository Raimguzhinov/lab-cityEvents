using System.Collections.ObjectModel;
using System.Collections.Specialized;
using CityEvents.Models;

namespace CityEvents.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private readonly ObservableCollection<CityEvent> _cItems;

        public MainWindowViewModel()
        {
            CityEvent[] events = Serializer<CityEvent[]>.Load("../../../../events.xml");

            _cItems = new ObservableCollection<CityEvent>(events);
            _cItems.CollectionChanged += CItems_CollectionChanged!;
        }

        private void CItems_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add || e.Action == NotifyCollectionChangedAction.Remove)
            {
                // обновляем представление при добавлении/удалении элементов
            }
            else if (e.Action == NotifyCollectionChangedAction.Replace)
            {
                // обновляем представление при замене элементов
            }
        }

        public ObservableCollection<CityEvent> CItems => _cItems;
    }

}