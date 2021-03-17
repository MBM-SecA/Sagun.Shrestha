using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

public class StateController: Controller
{
    public ViewResult First()
    {
       //statemanagement
       //1. Client side
       //1.1 Cookies
       var name = "Sagun Shrestha"; 
       Response.Cookies.Append ("user", name);

       //2. Server side
       //2.1 Session
       HttpContext.Session.SetString("Address", "ktm");
       return View();
       
      
    }

    public ViewResult Second(string name, int age)  //1.2 Query String (Query parameters)
    {
        var userAddress = HttpContext.Session.GetString("Address");
        //2.2 Temp data
        TempData["CollegeName"] = "MBM College";
        return View();
    }

     public ViewResult Third() 
    {
        var cName =TempData["CollegeName"];
       byte value = 67;
       ViewData["Name"] = "abc from ViewData";
       ViewBag.Name = "abc from ViewBag";
        return View(value);
    }

    [HttpPost]
    public bool Second(string collegeName)  //1.3 Hidden fields
    {
        return true;
    }
    
}