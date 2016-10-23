using ProjectCDA.Model;
using System.Collections.Generic;

namespace ProjectCDA.DAL
{
    public interface IDataService
    {
        IEnumerable<TwoPages> GetData();
    }
}
