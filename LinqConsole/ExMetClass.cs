using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsole
{
    internal class ExMetClass {




        public static class ExtMetClass

        {

            // converts the integer stored as a string, and returns as int type

            public static int IntegerExtension(this string str)

            {

                return Int32.Parse(str);

            }




            // checks if the passed in value is greater than this integer

            public static bool IsGreaterThan(this int i, int value)

            {

                return i > value;

            }




            // returns the number of words in this string, as an int

            public static int GetWordCount(this string inputstring)

            {

                if (!string.IsNullOrEmpty(inputstring))

                {

                    string[] strArray = inputstring.Split(' ');

                    return strArray.Count(); // strArray.Length;

                }

                else

                {

                    return 0;

                }

            }
        }
    }
}

