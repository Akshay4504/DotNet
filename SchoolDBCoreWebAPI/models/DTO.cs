using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolDBCodeFirstApp.Models
{
    internal class StdWithGradeDTO
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string GrdSection { get; set; }
        public string? GrdDescription { get; set; }

    }
    internal class StdWithNameAndRoll
    {
        public string StudentName { get; set; }
        public string RollNumber { get; set; }
    }
}
