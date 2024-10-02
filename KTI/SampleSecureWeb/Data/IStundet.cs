using System;
using SampleSecureWeb.Models;

namespace SampleSecureWeb.Data;

public interface IStundet
{
    IEnumerable<Student> GetStudents();
    Student AddStundent(Student student);
    Student UpdateStudent(Student student);
    void DeleteStudent(string nim);
}
