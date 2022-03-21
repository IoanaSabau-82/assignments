using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPetOwner
{
    public static class StringExtension
    { 
    public static bool DoesContainNumeric(this string aString ) 
        { foreach(char letter in aString)
            { if(char.IsDigit(letter))
                    return true; }
            return false;
        }
    public static IEnumerable<char> EverySecondElement(this string aString)
        {
            for (int i = 0; i < aString.Length; i++)
            {
                if (i % 2 == 0)
                    yield return aString[i];
            }
        }
    }





}
