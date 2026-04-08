using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace SchoolDBCodeFirstApp.Models

{

    internal class SchoolDBContext : DbContext

    {

        public string _ConStr;

        public SchoolDBContext()

        {

        }

        public SchoolDBContext(string _ConStr)

        {

            this._ConStr = _ConStr;

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {

            modelBuilder.Entity<User>(entity =>

            {

                entity.HasKey(e => e.UserId).HasName("PK__User");




                entity.ToTable("users", "School");




                // Seed User Data

                entity.HasData(

                    new User

                    {

                        UserId = 1,

                        FullName = "Pranaya Rout",

                        Email = "pranaya.rout@TekSystems.com",

                        PasswordHash = PasswordHasher.HashPassword("Pranaya@123"),

                        Role = "Administrator,Manager"

                    },

                    new User

                    {

                        UserId = 2,

                        FullName = "John Doe",

                        Email = "john.doe@TekSystems.com",

                        PasswordHash = PasswordHasher.HashPassword("John@123"),

                        Role = "Administrator"

                    },

                    new User

                    {

                        UserId = 3,

                        FullName = "Jane Smith",

                        Email = "jane.smith@TekSystems.com",

                        PasswordHash = PasswordHasher.HashPassword("Jane@123"),

                        Role = "Manager"

                    }

                );

            });
        }

        public SchoolDBContext(DbContextOptions<SchoolDBContext> options) : base(options)

        {

        }


        public DbSet<Grade> Grades { get; set; }

        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {

            if (!optionsBuilder.IsConfigured)

                optionsBuilder.UseSqlServer("server=EC2AMAZ-EHR6SVV; Database=SchoolDb; Integrated Security=True; Trusted_Connection=True ;TrustServerCertificate=True;");

            // optionsBuilder.UseSqlServer(_ConStr);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {

            modelBuilder.Entity<Grade>(entity => {

                entity.HasKey(e => e.GradeId).HasName("PK__Grade");

                entity.ToTable("grades", "School");

            });

            modelBuilder.Entity<Student>(entity =>

            {

                entity.HasKey(e => e.Studentid).HasName("PK__Student");

                entity.ToTable("students", "School");

                entity.HasOne(s => s.grade).WithMany(g => g.Students)

                .HasForeignKey(s => s.GradeId)

                .OnDelete(DeleteBehavior.Cascade)

                .HasConstraintName("FK__grades__students");

            });

        }

    }

}





