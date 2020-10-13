using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

public class EmployeeController : Controller
{
    public ActionResult Index()
    {
        var employees = Person.GetEmployees();
        
        return View(employees);
    }
    
    public ActionResult Detail([FromQuery]Guid id)
    {
        var employees = Person.GetEmployees();
        var employee = employees.FirstOrDefault(x => x.Id.ToString() == id.ToString);
        
        return View(employee);
    }
}

