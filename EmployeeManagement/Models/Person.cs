using System.Collections.Generic;
using System;
public class Person
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string SurName { get; set; }
    public string Address { get; set; }
    public char Gender { get; set; } = 'M';
    public double Salary { get; set; }

    public static List<Person> GetEmployees()
    {
        Person empl1 = new Person() { Id=Guid.NewGuid(), FirstName= "Sehun", SurName = "Oh",Address = "Kathmandu",Salary = 2000.0};
        Person empl2 = new Person() { Id=Guid.NewGuid(), FirstName= "Kai", SurName = "Kim",Address = "Kathmandu",Salary = 2000.0};
        Person empl3 = new Person() { Id=Guid.NewGuid(), FirstName= "Chanyeol", SurName = "Park",Address = "Kathmandu",Salary = 2000.0};
        Person empl4 = new Person() { Id=Guid.NewGuid(), FirstName= "Chen", SurName = "Kim",Address = "Kathmandu",Salary = 2000.0};
        Person empl5 = new Person() { Id=Guid.NewGuid(), FirstName= "Baekhyun", SurName = "Byun",Address = "Kathmandu",Salary = 2000.0};
        Person empl6 = new Person() { Id=Guid.NewGuid(), FirstName= "Lay", SurName = "Zhang",Address = "Kathmandu",Salary = 2000.0};
        List<Person> employees = new List<Person>() { empl1, empl2, empl3, empl4, empl5, empl6 };
        return employees;
        
    }
}