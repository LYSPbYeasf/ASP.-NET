using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace WebMVC.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Заполните поле имени")]
        public string firstName { get; set; }

        [Required(ErrorMessage = "Заполните поле фамилия")]
        public string lastName { get; set; }

        [Required(ErrorMessage = "Заполните поле группа")]
        public string group { get; set; }
        
        public int winFormAssessment { get; set; }
        
        public int cAssessment { get; set; }
        
        public int aspAssessment { get; set; }
        
        public int sqlAssessment { get; set; }
        
        public int adoAssessment { get; set; }
        
        public int sumAssessment { get; set; }
    }
}