using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqConsole
{
    internal class Standard
    {
        public int StudentID {  get; set; }
        public string StandardName { get; set; }
        public string StandardDescription { get; set; }

        public List<Student> CreateStandard()
        {
            return new List<Standard>()
            {
                new Standard(){ StudentID = 1,StandardName="2A",StandardDescription="Tis is Standard 2A"}
                new Standard(){ StudentID = 1,StandardName="2A",StandardDescription="Tis is Standard 2A"}
                new Standard(){ StudentID = 1,StandardName="2A",StandardDescription="Tis is Standard 2A"}
                new Standard(){ StudentID = 1.StandardName="2A",StandardDescription="Tis is Standard 2A"}
                new Standard(){ StudentID = 1.StandardName="2A",StandardDescription="Tis is Standard 2A"}
                new Standard(){ StudentID = 1.StandardName="2A",StandardDescription="Tis is Standard 2A"}
                new Standard(){ StudentID = 1.StandardName="2A",StandardDescription="Tis is Standard 2A"}

            }; 

        }
    }
}
