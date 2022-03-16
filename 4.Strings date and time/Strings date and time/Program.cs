using System;
using System.Globalization;

namespace Strings_date_and_time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //stings
            string myString = "2";
            Console.WriteLine(myString.GetType().IsValueType);


            char[] chars = myString.ToCharArray();
            foreach (char character in chars)
            { Console.WriteLine(character); }

            char[] chars1 = { 'a', 'b', 'c' };
            string mystring1 = new string(chars1);
            Console.WriteLine(mystring1);

            const string myString2 = "ABC";

            int stringLenght=myString2.Length;
            Console.WriteLine(stringLenght);

            string myString3 = "";
            string myString4 = string.Empty;
            Console.WriteLine(myString.CompareTo(myString2));
            Console.WriteLine(myString2.CompareTo(myString));
            Console.WriteLine(string.Compare(mystring1,myString2,StringComparison.CurrentCultureIgnoreCase));

            Console.WriteLine(myString2.Contains("es"));


            //deci acceasi functionalitate ca si compare, cand rezultatul e 0
            Console.WriteLine(myString2.Equals(myString));

            mystring1 = mystring1.Insert(1, "ce");
            Console.WriteLine(mystring1);

            Console.WriteLine(mystring1.StartsWith('a'));
            Console.WriteLine(mystring1.StartsWith("ace"));

            string[] myString5 = myString.Split('a');
            foreach( string character in myString5) { Console.WriteLine(character); }

            string myString6 = "un string ceva mai lung";
            myString6 = myString6.Replace("ceva", "oricum");
            string myString7 = myString6.Remove(2);
            Console.WriteLine(myString7);

            myString6 = "**" + myString6 + "**";
            Console.WriteLine(myString6);
            Console.WriteLine(myString6.Trim('*'));

            Console.WriteLine(myString.ToLower()) ;
            Console.WriteLine(myString.ToUpper()) ;

            string[] unu = { "cucurigu", "cotcodac" };
            string myString8 = string.Join("/", unu);
            Console.WriteLine(myString8);

            string myString9 = string.Format("there are {0} {1}", "apples","in the three");
            Console.WriteLine(myString9);


            //dates
            Console.WriteLine(new TimeSpan(1,30,0));
            Console.WriteLine(TimeSpan.FromDays(1));
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.UtcNow);

            DateTime odata = new DateTime(2023, 5, 7);
            DateTime oaltadata = DateTime.Today;

            string datestr = "3/15/2022 15:00:05 PM";
            DateTime data=DateTime.Parse(datestr);

            var tmspan = TimeSpan.FromHours(2);
            Console.WriteLine($"{data+tmspan}");

            DateTime today_ = DateTime.Today;
            TimeSpan tmspan1 = new TimeSpan(1, 0, 0, 0);
            //DateTime tomorrow = today_ + tmspan1;
            DateTime tomorrow = today_.AddDays(1);
            Console.WriteLine(tomorrow.DayOfWeek);
            DateTime yesterday = DateTime.Today.Subtract(TimeSpan.FromDays(1));

            DateTimeOffset doffset = new DateTime(2022, 10, 10);
            Console.WriteLine(doffset.DateTime);
            Console.WriteLine(doffset.UtcDateTime);
            Console.WriteLine(doffset.LocalDateTime);

            Console.WriteLine(3.ToString("C",CultureInfo.GetCultureInfo("en-GB")));


        }   
    }
}
