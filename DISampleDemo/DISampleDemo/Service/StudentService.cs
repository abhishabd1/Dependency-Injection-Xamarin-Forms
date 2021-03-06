﻿using DISampleDemo.Interface;
using DISampleDemo.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DISampleDemo.Service
{
    public class StudentService : IStudentService
    {
        
        public IEnumerable GetStudent()
        {
            return new List<Student>{

                new Student { Name = "Abhishek",Class="XII" },
                new Student { Name = "Anbu",Class="XII" },
                 new Student { Name = "Akshay" ,Class="XII"},
                  new Student { Name = "Pramod" ,Class="XII"},
                   new Student { Name = "Raju" ,Class="XII"},
                new Student { Name = "Sai" ,Class="XII"},

           };

        }
    }
}
