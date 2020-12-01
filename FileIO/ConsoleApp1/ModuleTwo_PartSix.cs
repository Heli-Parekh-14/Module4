using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ModuleTwo_PartSix
    {
        public void codes()
        {
            /* ----------------Part-6-------------------
            //various constructors
            DateTime DOB = new DateTime(1956, 12, 8, 6, 24, 12, 23);// From DateTime create the Date and Time 
            Console.WriteLine(DOB);

            string DateString = "8/12/1956 7:10:24 AM";// From String creation of DateTime 
            DateTime dateFromString =  DateTime.Parse(DateString, System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine(dateFromString);   
            
            DateTime EmpDateTime = new DateTime();// Empty DateTime    
            Console.WriteLine(EmpDateTime);               

            DateTime OnlyDate = new DateTime(2020, 10, 19);// Just date 
            Console.WriteLine(OnlyDate);

            DateTime OnlyTime = new DateTime(10000000);// DateTime from Ticks 
            Console.WriteLine(OnlyTime);

            DateTime DateTimewithKind = new DateTime(1976, 7, 10, 7, 10, 24, DateTimeKind.Local);// Localization with DateTime              
            Console.WriteLine(DateTimewithKind);            

            //properties
            Console.WriteLine("Day:{0}", DOB.Day);
            Console.WriteLine("Month:{0}", DOB.Month);
            Console.WriteLine("Year:{0}", DOB.Year);
            Console.WriteLine("Hour:{0}", DOB.Hour);
            Console.WriteLine("Minute:{0}", DOB.Minute);
            Console.WriteLine("Second:{0}", DOB.Second);
            Console.WriteLine("Millisecond:{0}", DOB.Millisecond);
            Console.WriteLine("Day of Week:{0}", DOB.DayOfWeek);
            Console.WriteLine("Day of Year: {0}", DOB.DayOfYear);
            Console.WriteLine("Time of Day:{0}", DOB.TimeOfDay);
            Console.WriteLine("Ticks:{0}", DOB.Ticks);
            Console.WriteLine("Today:{0}", DateTime.Today);
            Console.WriteLine("Now:{0}", DateTime.Now);
            Console.WriteLine("UTC:{0}", DateTime.UtcNow);
            Console.WriteLine("Kind:{0}", DateTimewithKind.Kind);

            //methods
            TimeSpan Month = new System.TimeSpan(30, 0, 0, 0);
            DateTime Day = DateTime.Now;
            DateTime SubtractDate = new DateTime(2000, 2, 6, 13, 5, 15);

            DateTime aDayAfterAMonth = Day.Add(Month);//add 30 days to current day
            Console.WriteLine(aDayAfterAMonth);

            DateTime aDayBeforeAMonth = Day.Subtract(Month);//subtract 30 days(timespan) from current day            
            Console.WriteLine("{0:dddd}", aDayBeforeAMonth);
            TimeSpan Difference = DOB.Subtract(SubtractDate);//subtract another date
            Console.WriteLine(Difference);

            Console.WriteLine(Day.AddYears(2));//add various components to datetime
            Console.WriteLine(Day.AddDays(12));
            Console.WriteLine(Day.AddHours(4.25));
            Console.WriteLine(Day.AddMinutes(15));
            Console.WriteLine(Day.AddSeconds(45));
            Console.WriteLine(Day.AddMilliseconds(200));
            Console.WriteLine(Day.AddTicks(5000));

            int NumberOfDays = DateTime.DaysInMonth(2020, 2);
            Console.WriteLine(NumberOfDays);//number of days in a year can be found using same technique in for loop for 12 months of a year

            DateTime DateOfFirst = new DateTime(2002, 10, 22);
            DateTime DateOfSecond = new DateTime(2009, 8, 11);
            int result1 = DateTime.Compare(DateOfFirst, DateOfSecond);//compare two dates
            if (result1 < 0)//result1=-1
                Console.WriteLine("Date of First is earlier");
            else if (result1 == 0)
                Console.WriteLine("Both dates are same");
            else//result1=1
                Console.WriteLine("Date of First is later");
            Console.WriteLine(DateOfFirst.CompareTo(DateOfSecond));//same work as above

            /*
            string[] FormatsOfDate = OnlyDate.GetDateTimeFormats();//to get formats available
            foreach (string format in FormatsOfDate)
                Console.WriteLine(format);
            FormatsOfDate = OnlyDate.GetDateTimeFormats('d');// DateTime Formats: d, D, f, F, g, G, m, o, r, s, t, T, u, U
            foreach (string format in FormatsOfDate)
                Console.WriteLine(format);         
            Console.WriteLine(OnlyDate.ToString("r"));//formates can be specified as such
            */

            /*
            Console.WriteLine(OnlyDate.IsDaylightSavingTime());//to check for daylight saving time
            Console.WriteLine(DateTime.IsLeapYear(OnlyDate.Year));//to check leap year

            Console.WriteLine("ToString: " + DOB.ToString());//conversions of datetime
            Console.WriteLine("ToBinary: " + DOB.ToBinary());
            Console.WriteLine("ToFileTime: " + DOB.ToFileTime());
            Console.WriteLine("ToLocalTime: " + DOB.ToLocalTime());
            Console.WriteLine("ToLongDateString: " + DOB.ToLongDateString());
            Console.WriteLine("ToLongTimeString: " + DOB.ToLongTimeString());
            Console.WriteLine("ToOADate: " + DOB.ToOADate());
            Console.WriteLine("ToShortDateString: " + DOB.ToShortDateString());
            Console.WriteLine("ToShortTimeString: " + DOB.ToShortTimeString());
            Console.WriteLine("ToUniversalTime: " + DOB.ToUniversalTime());

            Console.ReadKey();
            */
        }
    }
}
