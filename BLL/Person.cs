using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Payments;

namespace LibraryManager.BLL
{
    public class Person
    {
        public String name { get; set; }
        public String nationality { get; set; }
        public String DOB { get; set; }

        public Person(string name, string nationality, string DOB)
        {
            this.name = name;
            this.nationality = nationality;
            this.DOB = DOB; 

        }
    }
}
