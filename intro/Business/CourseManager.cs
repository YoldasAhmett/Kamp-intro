﻿using intro.DataAccess.Concretes;
using intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro.Business;

public class CourseManager
{
    public List<Course> GetAll()
    {
        //business rules burada yazılır.
        CourseDal courseDal = new CourseDal();
        return courseDal.GetAll();
    }
}
