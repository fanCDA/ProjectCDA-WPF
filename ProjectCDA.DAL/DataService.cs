﻿using Newtonsoft.Json;
using ProjectCDA.Model;
using ProjectCDA.Model.Constants;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

namespace ProjectCDA.DAL
{
    public class DataService
    {
        public IEnumerable<FacingPages> GetStartingData()
        {
            ObservableCollection<FacingPages> gridData = new ObservableCollection<FacingPages>();

            FacingPages pages = new FacingPages();
            pages.ID = 0;
            pages.Type = FacingPagesTypes.DEFAULT;
            gridData.Add(pages);

            pages = new FacingPages();
            pages.ID = 1;
            pages.Type = FacingPagesTypes.NO_HEADER;
            gridData.Add(pages);

            pages = new FacingPages();
            pages.ID = 2;
            pages.Type = FacingPagesTypes.SINGLE_PAGE;
            gridData.Add(pages);

            for (int i = 3; i < 65; i++)
            {
                pages = new FacingPages();
                pages.ID = i;
                pages.Type = FacingPagesTypes.DEFAULT;
                gridData.Add(pages);
            }

            return gridData;
        }

        public IEnumerable<FacingPages> GetData()
        {
            return GetDataFromFile();
        }

        public IEnumerable<FacingPages> GetDataFromFile()
        {
            string tmpDataFile = System.AppDomain.CurrentDomain.BaseDirectory + "..\\..\\Data\\tmpDdata.json";
            string jsonTxt = File.ReadAllText(tmpDataFile);
            GridObjectsList result = JsonConvert.DeserializeObject<GridObjectsList>(jsonTxt);
            return result.Data;
        }

        public bool SaveData(ObservableCollection<FacingPages> data)
        {
            string tmpDataFile = System.AppDomain.CurrentDomain.BaseDirectory + "..\\..\\Data\\tmpDdata.json";

            var jsonText = JsonConvert.SerializeObject(
                                                            new { GridObjects = data },
                                                            Formatting.Indented,
                                                            new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }
                                                       );
            File.WriteAllText(tmpDataFile, jsonText);

            return false;
        }
    }
}