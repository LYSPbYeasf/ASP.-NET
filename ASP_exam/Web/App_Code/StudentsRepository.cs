using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
public class StudentsRepository
{
    private static StudentsRepository repository = new StudentsRepository();
    private List<StudentResponse> responses = new List<StudentResponse>();
    public static StudentsRepository GetRepository()
    {
        return repository;
    }
    public IEnumerable<StudentResponse> GetAllResponses()
    {
        return responses;
    }
    public void AddResponse(StudentResponse response)
    {
        responses.Add(response);
    }
}