using Newtonsoft.Json;
using System.Collections.Generic;

namespace ProjectCDA.Model
{
    public class GridObjectsList
    {
        [JsonProperty("GridObjects")]
        public List<FacingPages> Data
        {
            get;
            set;
        }
    }
}
