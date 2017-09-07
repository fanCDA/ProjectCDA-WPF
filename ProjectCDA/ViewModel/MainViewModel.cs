using ProjectCDA.DAL;
using ProjectCDA.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ProjectCDA.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly DataService _dataService;

        public MainViewModel(DataService dataService)
        {
            _dataService = dataService;
            Schedule = new ObservableCollection<FacingPages>();
        }

        public MainViewModel()
            : this(new DataService())
        {
            // This is default constructor
        }


        public void LoadStartingData()
        {
            ClearAndFillSchedule(_dataService.GetStartingData());
        }

        public void LoadBrandNewData(int amount)
        {
            ClearAndFillSchedule(_dataService.GetSpecificAmountOfData(amount));
        }

        public void LoadData()
        {
            ClearAndFillSchedule(_dataService.GetData());
        }

        private void ClearAndFillSchedule(IEnumerable<FacingPages> facingPages)
        {
            Schedule.Clear();

            foreach (var facingPage in facingPages)
            {
                Schedule.Add(facingPage);
            }
        }

        internal void SavedData()
        {
            _dataService.SaveData(Schedule);
        }

        public ObservableCollection<FacingPages> Schedule
        {
            get;
            private set;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
