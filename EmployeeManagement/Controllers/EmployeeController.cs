using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    public ActionResult Index()
    {
        //Object initializer syntax
        Person empl1 = new Person() {FirstName= "Sehun", SurName = "Oh",Address = "Kathmandu",Salary = 2000.0};
        Person empl2 = new Person() {FirstName= "Kai", SurName = "Kim",Address = "Kathmandu",Salary = 2000.0};
        Person empl3 = new Person() {FirstName= "Chanyeol", SurName = "Park",Address = "Kathmandu",Salary = 2000.0};
        Person empl4 = new Person() {FirstName= "Chen", SurName = "Kim",Address = "Kathmandu",Salary = 2000.0};
        Person empl5 = new Person() {FirstName= "Baekhyun", SurName = "Byun",Address = "Kathmandu",Salary = 2000.0};
        Person empl6 = new Person() {FirstName= "Lay", SurName = "Zhang",Address = "Kathmandu",Salary = 2000.0};
        List<Person> employees = new List<Person>() {empl1, empl2, empl3, empl4, empl5, empl6};
        return View(employees);  
    }

    public ActionResult Detail(string firstName)
    {
        return View();
    }
}

