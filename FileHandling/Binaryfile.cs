using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    class BinaryFile

    {
        public void BinWriterFunctions()
        {
            FileStream fs = File.Open("C:\\\\MyBinaryFile.bin", FileMode.Create);
            using (BinaryWriter writer = new BinaryWriter(fs))
            {
                writer.Write("0x80234400");
                writer.Write("Windows Explorer Has Stopped Working");
                writer.Write(true);

            }
            Console.WriteLine("Binary File Created!");
        }
        public void BinReaderFunctions()
        {
            FileStream fs = File.Open("D:\\MyBinaryFile.bin", FileMode.Open);
            using (BinaryReader reader = new BinaryReader(fs))
            {
                Console.WriteLine("Error Code : " + reader.ReadString());
                Console.WriteLine("Message : " + reader.ReadString());
                Console.WriteLine("Restart Explorer : " + reader.ReadBoolean());
                //int ch;
                //while ((ch = reader.Read()) != -1)
                //{
                //    Console.Write((char)ch);
                //}
            }
        }
    }
}
