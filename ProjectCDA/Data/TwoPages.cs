using System;

namespace ProjectCDA.Data
{
    public class TwoPages
    {
        public TwoPages()
        {
            LeftPage = new SinglePage();
            RightPage = new SinglePage();
        }

        public String ID { get; set; }
        public SinglePage LeftPage { get; set; }
        public SinglePage RightPage { get; set; }
    }
}
