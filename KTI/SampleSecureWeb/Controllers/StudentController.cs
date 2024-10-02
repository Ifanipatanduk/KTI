using System;
using System.Reflection.Metadata;
using Microsoft.AspNetCore.Mvc;
using SampleSecureWeb.Data;
using SampleSecureWeb.Models;

namespace SampleSecureWeb.Controllers;

public class StudentController : Controller
{
    private readonly IStundet _studentData;
    public StudentController(IStundet stundetData)
    {
        _studentData = stundetData;
    }
    public IActionResult Index()
    {
        var students = _studentData.GetStudents(); 
        return View(students);
    }

    [HttpGet]
        public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Student student)
    {
        try
        {
            _studentData.AddStundent(student); 
            return RedirectToAction("Index");
        }
        catch (System.Exception ex)
        {
            ViewBag.Error = ex.Message;
        }
        return View(student);
    }
        public IActionResult Edit()
    {
        return View();
    }

        public IActionResult Delete()
    {
        return View();
    }
}