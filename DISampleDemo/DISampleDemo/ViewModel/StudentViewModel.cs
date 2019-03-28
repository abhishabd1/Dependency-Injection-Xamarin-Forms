using DISampleDemo.Interface;
using DISampleDemo.Model;
using DISampleDemo.Service;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DISampleDemo.ViewModel
{
    public class StudentViewModel
    {
        // private readonly StudentService _stservice;
        private readonly IStudentService _istudentservice;
        public IEnumerable Students { get; set; }
      
        public StudentViewModel(IStudentService isutedeservice)
        {
            _istudentservice = isutedeservice;
            //_stservice = new StudentService();
            //FetchRecord();
            Students = _istudentservice.GetStudent();
        }

        //public void FetchRecord()
        //{
        //    Students = _istudentservice.GetStudent();
        //}
    }
}
