using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;



public class FormContext : DbContext
{
    public FormContext()
        : base("StudentBaseBD")
    {   }
    
    public DbSet<StudentResponse> StudentResponses { get; set; }
    public DbSet<Assessment> Assessments { get; set; }
    
}