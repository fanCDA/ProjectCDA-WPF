using System;

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
        public SinglePage LeftPage { get; set; }
        public SinglePage RightPage { get; set; }
    }
}
