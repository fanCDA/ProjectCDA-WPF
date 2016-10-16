using ProjectCDA.Model;
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

            TwoPages pages = new TwoPages();
            pages.ID = 0;
            pages.hasNumbers = true;
            pages.hasHeaderField = true;
            TmpSchedule.Add(pages);

            pages = new TwoPages();
            pages.ID = 1;
            pages.hasNumbers = true;
            pages.hasHeaderField = false;
            TmpSchedule.Add(pages);

            pages = new TwoPages();
            pages.ID = 2;
            pages.hasNumbers = false;
            pages.hasHeaderField = false;
            TmpSchedule.Add(pages);

            for (int i=3; i<30; i++)
            {
                pages = new TwoPages();
                pages.ID = i;
                pages.hasNumbers = true;
                pages.hasHeaderField = true;
                TmpSchedule.Add(pages);
            }

            Schedule = TmpSchedule;
        }
    }
}
