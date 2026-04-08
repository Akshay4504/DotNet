using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
using SchoolDBCodeFirstApp.Models;

namespace SchoolDBCodeFirstApp.Models

{

    internal class Grade

    {

        [Key]

        public int GradeId { get; set; }
        [StringLength(25)]
      //  [(Column("grade_name",) type=("varchar"))];

        public string Section { get; set; } = null!;

        public string? Description { get; set; }

        public ICollection<Student> Students { get; set; }

    }

}