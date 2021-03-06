using System.Collections.Generic;
using System.Linq;
using System;

public class ComplexType
{
    public void LearnLINQ()
    {
         // Program for countries
            var countries = Country.GetCountries();

            var asianCountries = from country in countries
                                 where country.Continent == "Asia"
                                 select country.Name;
            foreach (var country in asianCountries)
            {
                Console.WriteLine(country);
            }



            // Q1: List countries in EUROPE which has population less than 100k
             var europeCountries = from country in countries
                                   where country.Continent == "Europe" && country.Population < 100000
                                   select country.Name;
                                      
                                      

            foreach(var country in europeCountries)
            {
                Console.WriteLine(country);
            }


           
            // Q2: List countries in ASIA which are never invaded.
            var asianCountries1 = from country in countries
                                  where country.Continent == "Asia" && country.IndependenceDay == default
                                  select country.Name;
            
            foreach(var country in asianCountries1)
            {
                Console.WriteLine(country);
            }

         //HW: Is there any african country in your country collection
        var southAsianCountries = countries.Any(x => x.Continent == "Africa");
        Console.WriteLine(southAsianCountries);

          //HW: Print first two largest asian countries
        var largest = countries.OrderByDescending (asianCountries => asianCountries.Area);
        Console.WriteLine("Two largest Asian countries are:");

        foreach (var country  in largest.Take(2))
        {
                Console.WriteLine(country.Name);
        }




    }
}