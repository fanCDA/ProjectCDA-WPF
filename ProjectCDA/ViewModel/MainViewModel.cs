using ProjectCDA.DAL;
using ProjectCDA.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ProjectCDA.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly IDataService _dataService;

        public MainViewModel(IDataService dataService)
        {
            _dataService = dataService;
            Schedule = new ObservableCollection<TwoPages>();
        }

        public MainViewModel()
            : this(new DataService())
        {
            // This is default constructor
        }


        public void LoadData()
        {
            Schedule.Clear();

            var facingPages = _dataService.GetData();

            foreach (var facingPage in facingPages)
            {
                Schedule.Add(facingPage);
            }
        }

        public ObservableCollection<TwoPages> Schedule
        {
            get;
            private set;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
