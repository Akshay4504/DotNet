using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace FileHandling

{

    internal class SystemDelegates

    {

        public static int Sum(int x, int y)

        {

            return x + y;

        }

        public static string Concat(string str1, string str2)

        {

            return str1 + str2;

        }

        public void AcceptAndPrint()

        {

            /* Func<int, int, int> add = Sum;
            4"Concatenated String :
             int result = add(10, 10);

             Console.WriteLine(result);
             Func<string, string, string> StrFunc = Concat;
             Console.WriteLine($"Concatenated String: {StrFunc.Invoke("Hello","World")}");
             Func<int> getRandomNumber = delegate ()
             {
                 Random rnd = new Random();
             }
            */
            Func<int, int, int> add = Sum;
            int result = add(10, 10);

            Console.WriteLine(result);
            Func<string, string, string> StrFunc = Concat;
            Console.WriteLine($"Concatenated String : {StrFunc.Invoke("hello","World")}");

            Func<int> getRandomNumber = delegate ()
            {
                Random rnd = new Random();
                return rnd.Next(1, 100);
            };

            Console.WriteLine($"Random Number generated: {getRandomNumber()}");
            Action<int> PrnDel = ConsolePrint;
            PrnDel(20);

        }

        private void ConsolePrint(int obj)
        {
            throw new NotImplementedException();
        }
    }

}


