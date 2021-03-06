﻿using Newtonsoft.Json;

namespace ProjectCDA.Model
{
    public class FacingPages
    {
        public FacingPages()
        {
            LeftPage = new SinglePage();
            RightPage = new SinglePage();
        }

        public int ID { get; set; }
        public int Type { get; set; }
        public string Header { get; set; }
        [JsonIgnore]
        public SinglePage LeftPage { get; set; }
        [JsonIgnore]
        public SinglePage RightPage { get; set; }
    }
}
