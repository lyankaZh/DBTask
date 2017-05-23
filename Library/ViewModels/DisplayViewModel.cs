using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Domain.Repository;

namespace Library.ViewModels
{
    public class DisplayViewModel<T>: INotifyPropertyChanged where T:class
    {
        private ObservableCollection<T> _items;
        private string _name;
        public DisplayViewModel(IUnitOfWork unit, List<T> list, string name)
        {
            var unitOfWork = unit;
            _items = new ObservableCollection<T>(list);
            _name = name;
        }

        public ObservableCollection<T> Items
        {
            get { return _items; }
            set
            {
                if (value != _items)
                {
                    _items = value;
                    NotifyPropertyChanged(_name);
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}

