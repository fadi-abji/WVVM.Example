using System.ComponentModel;
using System.Windows.Input;
using WVVM.WPF.Helpers;
using WVVM.WPF.Models;


namespace WVVM.WPF.ModelViews
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        private Person _person;
        public event PropertyChangedEventHandler PropertyChanged;

        public PersonViewModel()
        {
            _person = new Person { Name = "Fadi" };
            ChangeNameCommand = new RelayCommand(ChangeName);
        }

        // Property for binding to the View
        public string Name
        {
            get { return _person.Name; }
            set
            {
                _person.Name = value;
                OnPropertyChanged("Name");
            }
        }

        // Command to update the name
        public ICommand ChangeNameCommand { get; }

        private void ChangeName()
        {
            Name = "changing Name to something else";
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
