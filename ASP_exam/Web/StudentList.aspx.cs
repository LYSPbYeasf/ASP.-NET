using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class StudentList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected string GetStudentListHtml()
    {

        StringBuilder html = new StringBuilder();
        var sdt = StudentsRepository.GetRepository().GetAllResponses();
        foreach (var student in sdt)
        {
            html.Append(String.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td>", student.StudentFirstName, student.StudentLastName, student.GroupNumber));
        }
        return html.ToString();
    }
   
}