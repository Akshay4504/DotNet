using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace SchoolDBCodeFirstApp.Models

{

    internal class Student

    {

        [Key]

        public int Studentid { get; set; }

        public string Name { get; set; } = null!;

        public string RollNumber { get; set; } = null!;

        //these two below make the foriengn key 

        public int GradeId { get; set; }

        public virtual Grade grade { get; set; }
    }
}