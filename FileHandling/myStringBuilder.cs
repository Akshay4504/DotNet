using System;

using System.Collections.Generic;

using System.IO;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace FileHandling

{

    internal class MyStringReadWrite

    {

        public void MyStringReader()

        {

            string text = @"You are reading this StringWriter and StringReader in C# article at dotnettutorials.net";

            using (StringReader stringReader = new StringReader(text))

            {

                int count = 0;

                string line;

                while ((line = stringReader.ReadLine()) != null)

                {

                    count++;

                    Console.WriteLine("Line {0}: {1}", count, line);

                }

            }

        }

        public void MyStringWriter()
        {

            string text = "Hello. This is First Line AnHello. This is Second Line AnHello. This is Third Line";

            //Writing string into StringBuilder

            StringBuilder stringBuilder = new StringBuilder();

            StringWriter stringWriter = new StringWriter(stringBuilder);

            stringWriter.WriteLine(text);
            stringWriter.Flush();
            stringWriter.Close();

            StringReader reader = new StringReader(stringBuilder.ToString());
            while (reader.Peek() > -1)
                Console.WriteLine(reader.ReadLine());
        }
        public static void MoreSBMethods()
        {
            Console.WriteLine("Enter a multi word string");

            string str = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append(str);

            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                char temp = sb[i];
                sb[i] = sb[j];
                sb[j] = temp;

            }

            Console.WriteLine("Reverse of string is : " + sb);

            Console.WriteLine($"Capacity of sb is : {sb.Capacity}, length is {sb.Length}");

            sb.Clear();

            Console.WriteLine($"Capacity of sb is : {sb.Capacity}, length is {sb.Length}");

            StringBuilder sb2 = new StringBuilder("She sells sea shells on the sea shore");
            Console.WriteLine(sb2);

            sb2.Replace("sh", "h");
            Console.WriteLine(sb2);
            sb2.Replace("Sh", "h", 0, 5);
            Console.WriteLine(sb2);
        }

    }

}


