using ProjectCDA.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ProjectCDA.DAL
{
    public class DataService : IDataService
    {
        public IEnumerable<FacingPages> GetData()
        {
            ObservableCollection<FacingPages> gridData = new ObservableCollection<FacingPages>();

            FacingPages pages = new FacingPages();
            pages.ID = 0;
            pages.hasNumbers = true;
            pages.hasHeaderField = true;
            gridData.Add(pages);

            pages = new FacingPages();
            pages.ID = 1;
            pages.hasNumbers = true;
            pages.hasHeaderField = false;
            gridData.Add(pages);

            pages = new FacingPages();
            pages.ID = 2;
            pages.hasNumbers = false;
            pages.hasHeaderField = false;
            gridData.Add(pages);

            for (int i = 3; i < 65; i++)
            {
                pages = new FacingPages();
                pages.ID = i;
                pages.hasNumbers = true;
                pages.hasHeaderField = true;
                gridData.Add(pages);
            }

            return gridData;
        }
    }
}
