using System.Collections.Generic;

namespace ProjectCDA.Data
{
    public class SinglePage
    {
        private List<string> _BaseFields;

        public SinglePage()
        {
            _BaseFields = new List<string>();
            _BaseFields.Add("Test 1");
            _BaseFields.Add("Test 2");
            _BaseFields.Add("Test 3");
            _BaseFields.Add("Test 4");
        }

        public List<string> BaseFields
        {
            get
            {
                return _BaseFields;
            }
        }
    }
}
