using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling

{
    internal class CFileHandling
    {

        public void WriteToTextFile()

        {

            String file = "FileHandling.txt";

            StreamWriter sw = new StreamWriter(file, true);

            // To write on the console screen

            Console.WriteLine("Enter the Text that you want to write on File");

            // To read the input from the user

            string str = Console.ReadLine();

            // To write a line in buffer

            sw.WriteLine(str);

            // To write in output stream

            sw.Flush();

            // To close the stream

            sw.Close();

        }

        public void ReadFromTextFile()

        {
            StreamReader sr = new StreamReader("D://GreyHeads.txt");

            Console.WriteLine("Content of the File");

            // This is use to specify from where

            // to start reading input stream

            sr.BaseStream.Seek(0, SeekOrigin.Begin);

            // To read line from input stream

            string str = sr.ReadLine();

            // To read the whole file line by line

            while (str != null)

            {

                Console.WriteLine(str);

                str = sr.ReadLine();

            }

            Console.ReadLine();

            // to close the stream

            sr.Close();

        }

        public void FileAccess()

        {

            Console.WriteLine("Please enter a name of the file to renamed: ");

            string FileName = Console.ReadLine();

            // Checking File exist or not

            if (File.Exists(FileName))

            {

                Console.WriteLine("Please enter a new name for this file: ");

                string newFilename = Console.ReadLine();

                // Checking if string is null or not if (newFilename != String.Empty)

                // Renaming the file

                File.Move(FileName, newFilename);

                // checking if the file has been

                // renamed successfully or not

                if (File.Exists(newFilename))

                {

                    Console.WriteLine("The file was renamed to + newFilename");

                    Console.ReadKey();

                }
               /* public void DirectoryAccess()
                {
                    Console.WriteLine("Please enter a name for the new directory");
                    string DirName = Console.ReadLine();

                    if (DirName != String.Empty) {
                        Directory.CreateDirectory(DirName);

                        if (Directory.Exists(DirName))
                        {
                            Console.WriteLine("the directory was created");
                            Console.ReadKey();
                        }
                    }
                    public void getFilesFromDirectory()
                    {
                        Console.WriteLine("please enter the name of existing directories: ");
                        string DirName = Console.ReadLine();
                        if (DirName != string.Empty)
                        {
                            if (Directory.Exists(DirName))
                            {
                                string[] filesInDirectory = Directory.GetFiles(DirName);
                            }
                        }
                    }
               */
                }
            }

        }

    }


