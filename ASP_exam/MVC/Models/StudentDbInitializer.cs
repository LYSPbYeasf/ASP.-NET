using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebMVC.Models
{
    public class StudentDbInitializer : DropCreateDatabaseAlways<StudentContext>
    {
        protected override void Seed(StudentContext db)
        {
            db.Students.Add(new Student { firstName = "Александр", lastName = "Смирнов", group = "1", winFormAssessment = 3, cAssessment = 4, aspAssessment = 3, sqlAssessment = 4, adoAssessment = 5 });
            db.Students.Add(new Student { firstName = "Дмитрий", lastName = "Кузьмин", group = "2", winFormAssessment = 4, cAssessment = 5, aspAssessment = 4, sqlAssessment = 4, adoAssessment = 5 });
            db.Students.Add(new Student { firstName = "Ева", lastName = "Кудрина", group = "3", winFormAssessment = 5, cAssessment = 4, aspAssessment = 4, sqlAssessment = 4, adoAssessment = 5 });
            db.Students.Add(new Student { firstName = "Ирина", lastName = "Василеа", group = "1", winFormAssessment = 4, cAssessment = 4, aspAssessment = 5, sqlAssessment = 3, adoAssessment = 3 });
            db.Students.Add(new Student { firstName = "Марина", lastName = "Смирнова", group = "2", winFormAssessment = 5, cAssessment = 3, aspAssessment = 4, sqlAssessment = 4, adoAssessment = 4 });
            db.Students.Add(new Student { firstName = "Богдан", lastName = "Городин", group = "2", winFormAssessment = 3, cAssessment = 4, aspAssessment = 3, sqlAssessment = 3, adoAssessment = 4 });

            base.Seed(db);
        }
    }
}