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

            for(int i=0; i<20; i++)
            {
                TwoPages pages = new TwoPages();
                pages.ID = i.ToString();
                pages.RightPage = i % 5 != 3;
                TmpSchedule.Add(pages);
            }

            Schedule = TmpSchedule;
        }
    }
}
