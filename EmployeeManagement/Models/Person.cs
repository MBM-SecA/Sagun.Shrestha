using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

public class Person
{
    public int Id {get; set; }

    [Required]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "We need Last Name.")]
    [Display(Name = "Last Name")]
    public string SurName { get; set; }
    public string Address { get; set; }
    public char? Gender { get; set; } = 'M';
    public double? Salary { get; set; }


    public Department Department { get; set; }
    public int DepartmentId { get; set; }

    // public static List<Person> GetEmployees()
    // {
    //     Person empl1 = new Person() { Id= 1, FirstName= "Sehun", SurName = "Oh",Address = "Kathmandu",Salary = 2000.0};
    //     Person empl2 = new Person() { Id= 2, FirstName= "Kai", SurName = "Kim",Address = "Kathmandu",Salary = 2000.0};
    //     Person empl3 = new Person() { Id= 3, FirstName= "Chanyeol", SurName = "Park",Address = "Kathmandu",Salary = 2000.0};
    //     Person empl4 = new Person() { Id= 4, FirstName= "Chen", SurName = "Kim",Address = "Kathmandu",Salary = 2000.0};
    //     Person empl5 = new Person() { Id= 5, FirstName= "Baekhyun", SurName = "Byun",Address = "Kathmandu",Salary = 2000.0};
    //     Person empl6 = new Person() { Id= 6, FirstName= "Lay", SurName = "Zhang",Address = "Kathmandu",Salary = 2000.0};
    //     List<Person> employees = new List<Person>() { empl1, empl2, empl3, empl4, empl5, empl6 };
    //     return employees;
        
    // }

    
}