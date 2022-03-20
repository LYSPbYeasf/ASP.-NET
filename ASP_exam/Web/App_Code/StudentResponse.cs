using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Dynamic;
using System.ComponentModel.DataAnnotations;

public class StudentResponse
{
    public int StudentResponseId { get; set; }
    public string StudentFirstName { get; set; }
    public string StudentLastName { get; set; }
    public string GroupNumber { get; set; }

    public virtual List<Assessment> Assessments { get; set; }
    public StudentResponse(string name, string lastName, string gNumber)
    {
        StudentFirstName = name;
        StudentLastName = lastName;
        GroupNumber = gNumber;
        Assessments = new List<Assessment>();
    }
    public StudentResponse() { }
}
public class Assessment
{
    public int StudentAssessmentId { get; set; }
    public int WinFormAssessment { get; set; }
    public int CAssessment { get; set; }
    public int AspAssessment { get; set; }
    public int SqlAssessment { get; set; }
    public int AdoAssessment { get; set; }
    public int SumAssessment { get; set; }
    public StudentResponse StudRes { get; set; }
    public Assessment() { }
    public Assessment(int wfAssessment, int cAssessmente, int aspAssessment, int adoAssessment, int sqAssessment)
    {
        WinFormAssessment = wfAssessment;
        CAssessment = cAssessmente;
        AspAssessment = aspAssessment;
        SqlAssessment = sqAssessment;
        AdoAssessment = adoAssessment;
        SumAssessment = CountAssessment(wfAssessment, cAssessmente, aspAssessment, adoAssessment, sqAssessment);
    }
    public int CountAssessment(int wfAssessment, int cAssessmente, int aspAssessment, int adoAssessment, int sqAssessment)
    {
        int sumAssessment = wfAssessment + cAssessmente + aspAssessment + adoAssessment + sqAssessment;
        return sumAssessment;
    }
}