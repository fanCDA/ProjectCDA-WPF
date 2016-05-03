﻿using System;

namespace ProjectCDA.Data
{
    public class TwoPages
    {
        public TwoPages()
        {
            LeftPage = new SinglePage();
            RightPage = new SinglePage();
        }

        public int ID { get; set; }
        public Boolean hasNumbers { get; set; }
        public Boolean hasHeaderField { get; set; }
        public SinglePage LeftPage { get; set; }
        public SinglePage RightPage { get; set; }
    }
}
