using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webscraping_with_C_
{
    class Country
    {
        public int ID { get; set; }
        public string CountryName { get; set; }

        public Country (int id, string Name)
        {
            ID = id;
            CountryName = Name;
        }
    }
}
