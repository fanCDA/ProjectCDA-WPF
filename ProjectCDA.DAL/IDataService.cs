using ProjectCDA.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ProjectCDA.DAL
{
    public interface IDataService
    {
        IEnumerable<FacingPages> GetData();
        bool SaveData(ObservableCollection<FacingPages> data);
    }
}
