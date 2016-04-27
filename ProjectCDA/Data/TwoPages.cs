using System;

namespace ProjectCDA.Data
{
    public class TwoPages
    {
        public TwoPages()
        {
            LeftPage = RightPage = true;
        }

        public String ID { get; set; }
        public Boolean LeftPage { get; set; }
        public Boolean RightPage { get; set; }
    }
}
