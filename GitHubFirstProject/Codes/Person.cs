global using GitHubFirstProject.Codes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubFirstProject.Codes
{
    internal class Car
    {

       


        //Internal Data 
        //is not a get set since it's private so it's not gonna 
        //go outside of the class

        private DateTime latestDateForVision;

        private bool mustCallForVision;

        //Static Data

        public static int AgeForFirstVision;

        public static int VisionYearRange;

        //Startup Data
        public string? NameOfOwner { get; set; }

        public string? Brand { get; set; }

        public string? LicensePlate { get; set; }

        public DateTime CarAgeYear { get; set; }


        //public string GetCarAgeAndCheckForVision(int CarAgeYear, string LateDateForVision)
        //{
        //    DateTime localDate = DateTime.Now;

        //    string stringDate = Convert.ToString(localDate);

        //    return stringDate;
        //}


        //constructor for the Car class
        public Car(string? nameOfOwner, string? brand, string? licensePlate, DateTime carAgeYear)
        {

            NameOfOwner = nameOfOwner;
            Brand = brand;
            LicensePlate = licensePlate;
            CarAgeYear = carAgeYear;

        }

        static Car()
        {
         AgeForFirstVision = 5;

        VisionYearRange = 2;
        }

        //method for checking if car needs vision
        public void CheckCarVisionStatus()
        {
            //age is year now minues CarAgeYears (both in years)
            int age = DateTime.Now.Year - CarAgeYear.Year;

            //if age is greater than 5
            if (age > AgeForFirstVision)
            {
                Console.WriteLine("Insert the latest CarVision date: ");
                string latestDateForVision = Console.ReadLine();

                

                //fields for day, month and year
                int day = 0;
                int month = 0;
                int year = 0;

                //
                if (latestDateForVision != null)
                {

                    //array for day, month and year. Split them into 3 in one array
                    //then it converts the strings into int
                    string[] latestDateForVisionSplit = latestDateForVision.Split('-');
                    day = Convert.ToInt32(latestDateForVisionSplit[0]);
                    month = Convert.ToInt32(latestDateForVisionSplit[1]);
                    year = Convert.ToInt32(latestDateForVisionSplit[2]);


                }

                //converts latestDateForVision to a DateTime
                DateTime latestDateForVisionDateTime = Convert.ToDateTime(latestDateForVision);

                //field get new value of DateTime for year, month and day
                latestDateForVisionDateTime = new DateTime(year, month, day);

                //Timespan respresent a time range
                //Timespan is present time minus the latestDateForVision
                TimeSpan ts = DateTime.Now - latestDateForVisionDateTime;

                //if timespan (in years) is greater than VisionYearRange
                if ((ts.TotalDays / 365) > VisionYearRange)
                {

                    mustCallForVision = true;

                }

            }

            if (mustCallForVision == true)
            {
                Console.WriteLine("Car needs a vision");
            }
            else
            {
                Console.WriteLine("Car is approved");
            }
        
        }

    }

}
