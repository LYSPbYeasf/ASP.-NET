using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StudentInput : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            Page.Validate();
            if (!Page.IsValid)
                return;
            StudentResponse student = new StudentResponse(StFirstName.Text, StLastName.Text, groupNumber.Text);
            StudentsRepository.GetRepository().AddResponse(student);

            int wfAssessment = 0 + int.Parse(TextBoxWF.Text);
            int cAssessmente = 0 + int.Parse(TextBoxCsharp.Text);
            int aspAssessment = 0 + int.Parse(TextBoxASP.Text);
            int sqAssessment = 0 + int.Parse(TextBoxTSQL.Text);
            int adoAssessment = 0 + int.Parse(TextBoxADO.Text);

            
            try
            {
                Assessment studentAsses = new Assessment(wfAssessment, cAssessmente, aspAssessment, adoAssessment, sqAssessment);
                student.Assessments.Add(studentAsses);
                FormContext context = new FormContext();               
                context.StudentResponses.Add(student);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                ExcpLabel.Text = ex.Message;
            }


            Response.Redirect("StudentSave.aspx");
        }
    }

}

   