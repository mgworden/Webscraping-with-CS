using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webscraping_with_C_
{
    public class PersonData
    {
        public int ID { get; set; }
        public string PersonName { get; set; }
        public int Nationality { get; set; }


        public PersonData(int id, int nationality, string Name)
        {
            ID = id;
            PersonName = Name;
            Nationality = nationality;
        }
    }
    
}
