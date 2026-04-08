using System;

using System.Linq;

using System.Text;

using System.Threading.Tasks;




namespace FileHandlingThreading

{

    class MyFileInfo

    {

        public void FileInfoProps()

        {

            //Set the File Path

            string filePath = @"C:\Harry\TechTraining\TekSystems\FileHandling\Program.cs";

            FileInfo fileInfo = new FileInfo(filePath);

            if (fileInfo.Exists)

            {

                Console.WriteLine($"Directory: {fileInfo.Directory}");
                Console.WriteLine($"Directory Name: {fileInfo.DirectoryName}");
                Console.WriteLine($"Length in bytes: {fileInfo.Length}");
                Console.WriteLine($"Name: {fileInfo.Name}");
                Console.WriteLine($"Is read only: {fileInfo.IsReadOnly}");
                Console.WriteLine($"File exists?: {fileInfo.Exists}");

            }

        }

    }

}