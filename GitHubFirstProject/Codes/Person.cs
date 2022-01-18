global using GitHubFirstProject.Codes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubFirstProject.Codes
{
    internal class Person
    {



        //property

        private string? _firstName;
        private string? _lastName;
        public string? birthDateInDanishFormat { get; set; }    
        public int Age { get; set; }  
        public double TimeSpanInTotalDays { get; set; }

        //har ikke en set, så det er en konstant
        public int PhoneNo { get; init; }

        public Person(string firstName, string lastName, DateTime birthDate)
        {
            _firstName = firstName;
            _lastName = lastName;
            PhoneNo = 12345678;
            birthDateInDanishFormat = birthDate.ToString("dd-MM-yyyy");
            Age = DateTime.Now.Year - birthDate.Year;
            TimeSpan ts = DateTime.Now - birthDate;

            TimeSpanInTotalDays = ts.TotalDays;

            //int ss;
            //bool pass = int.TryParse("16A", out ss);
            //if (pass == false)
            //{
            //    Console.WriteLine("Does not have type match!");
            //}

            //int tstd = Convert.ToInt32(TimeSpanInTotalDays);
            //Console.WriteLine(tstd);

            object boxed = TimeSpanInTotalDays;
            var unboxed = boxed;
        }

        public Person()
        {
            _firstName = "Thomas";
            _lastName = "Jensen";
            birthDateInDanishFormat = "05-04-1992";
        }

        public string? GetFullName()
        {
            return $"{_firstName} {_lastName}";
        }


    }
}
