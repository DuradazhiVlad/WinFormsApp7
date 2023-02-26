using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace WinFormsApp7
{
    public class Person
    {
       public string Name;
       public string Surname;
       public string date;
       public string counri;
       public string city;
       public string gender;
        public Person(string Name,string Surname,string date,string counri,string sity,
                      string gender ) 
        {
            this.Name = Name;
            this.Surname = Surname;
            this.date = date;
            this.counri = counri;
            this.city = sity;
            this.gender = gender;

        }
        
        public override string ToString()
        {
            return $"Ім'я:{Name}; Фамілія:{Surname};"; 
            //return $"Ім'я:{Name}; Фамілія:{Surname}; Дата народження: {date};" +
                  // $"Країна: {counri}; Місто: {city}; Стать: {gender}";
        }

    }
}
