using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsole
{
    internal class MoreLinqFunctions
    {
        public void Aggregation()
        {
            Student std = new Studnet();
            List<Student> studentList = newstd.CreateStudnets();
            bool areAllStudentsTeenAger = studentList.ToList().Any(s => s.age > 12 && s.Age < 20);
            if (areAllStudentsTeenAger)
            {
                var std.List=(from s1 in studentList
                              where s1.Age>12 && s1.Age<20
                              select s1).ToList();
            }
        }
        public void stringAggregation()
        {
            IList<String> strlist = new List<string>() { 10, 21, 30, 45, 50, 87 };
            var largest = intList.Max();
            Console.WriteLine("Largest Element: ", +largest);
            var largestEventElement = intlist.Max(1=>{
                if (i % 2 == 0)
                {
                    return i;
                    return 0;

                });

                Console.WriteLine("largest Even: {0}", largestEventElement);
                Console.WriteLine("2nd Element in intList: {0}", intList.ElementAt(1));
                Console.WriteLine("5th Element in intList: {0}", intList.FirstorDefault(5));
            }
            public void setOperators()
            {
                INumerable<string> eList= CollectionsMarshal        Console.WriteLine("Largest Even Number is: " + largestEven);

                Console.WriteLine("2nd element in the list: " + intList.ElementAt(0));

                Console.WriteLine("10th Element in the list: " + intList.ElementAtOrDefault(10));

                Console.WriteLine("\nFirst Function:- Even element in the list: " + intList.First(i => i % 2 == 0));

                Console.WriteLine("First Function:- 5th Element in the list: " + intList.FirstOrDefault(i => i % 27 == 0));

                Console.WriteLine("\nSingle Function:- Even element in the list: " + intList.Single(i => i % 2 == 0));

            }

            //Data Source

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<string> Collection1 = new List<string>() { "One", "Two", "Three", "Four", "Three" };

            List<string> Collections2 = new List<string>() { "Five", "Three", "Six", "One", "Six" };

            public void SetOperator()

            {

                //Distinct List

                IEnumerable<string> dList = Collection1.Distinct();

                Console.WriteLine("\nDistinct List:");

                foreach (string d in dList) Console.WriteLine(d);

                //Except List

                dList = Collection1.Except(Collections2).ToList();

                Console.WriteLine("\nExcept List:");

                foreach (var d in dList) Console.WriteLine(d);

                //Intersect List

                dList = Collection1.Intersect(Collections2).ToList();

                Console.WriteLine("\nIntersect List:");

                foreach (var d in dList) Console.WriteLine(d);



                //Union List

                dList = Collection1.Union(Collections2).ToList();

                Console.WriteLine("\nUnion List:");

                foreach (var d in dList) Console.WriteLine(d);

            }

            public void SkipFunctions()

            {

                Console.WriteLine("Original List");

                foreach (var num in numbers) Console.Write(num + " ");

            }

        }
    }
            
            







        }
    }
}
