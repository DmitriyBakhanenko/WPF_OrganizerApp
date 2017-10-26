using Organizer.Model;
using System.Collections.ObjectModel;
using Organizer.Data;

namespace Organizer.ViewModel
{
    public class MainViewModel : ViewModeilBase
    {
        private IPersonDataService _personDataService;
        private Person _selectedPerson;

        public MainViewModel(IPersonDataService personDataService)
        {
            Persons = new ObservableCollection<Person>();
            _personDataService = personDataService;
        }

        public void Load()
        {
            var persons = _personDataService.GetAll();
            Persons.Clear();
            foreach (var person in persons)
            {
                Persons.Add(person);
            }
        }

        public ObservableCollection<Person> Persons { get; set; }

        public Person SelectedPerson
        {
            get => _selectedPerson;
            set
            {
                _selectedPerson = value;
                OnPropertyChanged();
            }
        }
    }
}
