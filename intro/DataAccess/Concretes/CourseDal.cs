using intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro.DataAccess.Concretes
{
    public class CourseDal
    {
        List<Course> courses;
        public CourseDal()
        {
            Course course1 = new Course();
            course1.Id = 1;
            course1.Name = "C#";
            course1.Description = ".Net8 vs...";
            course1.Price = 0;

            Course course2 = new Course();
            course2.Id = 2;
            course2.Name = "JAVA";
            course2.Description = "Java17 vs...";
            course2.Price = 10;

            Course course3 = new Course();
            course3.Id = 3;
            course3.Name = "PYTON";
            course3.Description = "Pyton 3.12 vs...";
            course3.Price = 20;

            courses = new List<Course> { course1, course2, course3 };
        }

        public List<Course> GetAll()
        {
            return courses;
            //burada db işlemleri yapılır.
        }

        public void Add(Course course)
        {
            courses.Add(course);
        }
    }
