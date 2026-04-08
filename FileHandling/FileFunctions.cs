using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class FileFunctions
    {

        public string filePath = @"D:\\Harry\\TechTraining\\TekSystems\\FileHandling\\CFileHandling.cs";
        public void FileStreamFunctions()
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))

            {
                if (stream.CanRead)
                {

                    byte[] buffer = new byte[10];
                    int bytesRead;

                    while ((bytesRead = stream.Read(buffer, 0, buffer.Length - 2)) > 0)

                    {
                        string content = System.Text.Encoding.UTF8.GetString(buffer, 0, bytesRead);

                        Console.Write(content);
                    }
                }
                else

                {

                    Console.WriteLine("The stream does not support reading.");

                }

            }

        }

    }
}
