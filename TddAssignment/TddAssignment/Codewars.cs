using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddAssignment
{
    public class Codewars
    {
        //Write a function that accepts an array of 10 integers(between 0 and 9), that returns a string of those numbers in the form
        //of a phone number.Eg:(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}) // => returns "(123) 456-7890"
        public static string ConvertArrayToRequestedStringFormat(int[] input) 
        {
            if (input.Length != 10)
            {
                throw new ArgumentException("Input too long or too short");
            }

            var result = $"({string.Join("", input[..3])}) {string.Join("", input[3..6])}-{string.Join("", input[6..])}";
            return result;
        }
    }
}


