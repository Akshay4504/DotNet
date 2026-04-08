using System;

using System.Collections.Generic;

using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

using System.Threading.Tasks;

namespace FileHandling

{

    internal class GenericDelegates

    {

        // Step 1

        public delegate double AddNumber1Delegate(int nol, float no2, double no3);
        public delegate void AddNumber2Delegate(int nol, float no2, double no3);
        public delegate bool CheckLengthDelegate (string name);



        public void AcceptandPrint()
        {
            AddNumber1Delegate obj1 = new AddNumber1Delegate(AddNumber1);

            double Result = obj1.Invoke(100, 125.45f, 456.789);

            Console.WriteLine(Result);

            AddNumber2Delegate obj2 = new AddNumber2Delegate(AddNumber2);

            obj2.Invoke(50, 255.45f, 123.456);

            CheckLengthDelegate obj3 = new CheckLengthDelegate(CheckLength);

            bool Status = obj3. Invoke("Pranaya");

            Console.WriteLine(Status);

            Console.ReadKey();

        }

        public static double AddNumber1(int no1, float no2, double no3)
        {
            return no1 + no2 + no3;
        }
        public static void AddNumber2(int no1, float no2, double no3)
        {
            Console.WriteLine(no1 + no2 + no3);
        }
            public static bool CheckLength(string name)
            {
                if(name.Length > 5)
                    return true;
                return false;

            }


    }

}


