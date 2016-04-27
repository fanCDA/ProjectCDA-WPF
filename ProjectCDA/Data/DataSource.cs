using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ProjectCDA.Data
{
    public class DataSource : INotifyPropertyChanged
    {
        private ObservableCollection<TwoPages> _Schedule;

        public DataSource()
        {
            AddSomeDummyData();
        }

        public ObservableCollection<TwoPages> Schedule
        {
            get
            {
                return _Schedule;
            }
            set
            {
                if (value != _Schedule)
                {
                    _Schedule = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Schedule"));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };



        private void AddSomeDummyData()
        {
            ObservableCollection<TwoPages> TmpSchedule = new ObservableCollection<TwoPages>();

            TmpSchedule.Add(new TwoPages());
            TmpSchedule.Add(new TwoPages());
            TmpSchedule.Add(new TwoPages());
            TmpSchedule.Add(new TwoPages());
            TmpSchedule.Add(new TwoPages());
            TmpSchedule.Add(new TwoPages());
            TmpSchedule.Add(new TwoPages());
            TmpSchedule.Add(new TwoPages());
            TmpSchedule.Add(new TwoPages());
            TmpSchedule.Add(new TwoPages());

            TmpSchedule.Add(new TwoPages());
            TmpSchedule.Add(new TwoPages());
            TmpSchedule.Add(new TwoPages());
            TmpSchedule.Add(new TwoPages());
            TmpSchedule.Add(new TwoPages());
            TmpSchedule.Add(new TwoPages());
            TmpSchedule.Add(new TwoPages());
            TmpSchedule.Add(new TwoPages());
            TmpSchedule.Add(new TwoPages());
            TmpSchedule.Add(new TwoPages());

            Schedule = TmpSchedule;
        }
    }
}
