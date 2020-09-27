using System;
using System.Collections.Generic;

public class Country
{
    private string v1;
    private string v2;
    private int v3;
    private DateTime dateTime;

    public string Name { get; set;}
    public string Continent { get; set;}
    public double Area { get; set;}
    public long Population { get; set;}
    public DateTime IndependenceDay { get; set;}


    public Country( string n, string c, double a, long p, DateTime i = default)
    {
        Name = n;
        Continent = c;
        Area = a;
        Population = p;
        IndependenceDay = i;
    }

    public Country(string v1, string v2, int v3, DateTime dateTime)
    {
        this.v1 = v1;
        this.v2 = v2;
        this.v3 = v3;
        this.dateTime = dateTime;
    }

    public static List<Country> GetCountries()
    {
        Country c1 = new Country( "Nepal", "Asia", 4765, 4632467);
        Country c2 = new Country( "India", "Asia", 4765575, DateTime.Parse("1934/3/3"));
        Country c3 = new Country( "Russia", "Europe", 47653.34, 8347377);
        Country c4 = new Country( "USA", "North America", 78453.45, 845747);
        Country c5 = new Country( "China", "Asia", 837483.43, 34456545);
        Country c6 = new Country( "Thailand", "Asia", 327647324.34, 3456545);
        Country c7 = new Country( "Saudi Arabia", "Asia", 847598.34, 3456545);
        Country c8 = new Country( "Algeria", "Africa", 283728.34, 3456545);
        Country c9 = new Country( "Ghana", "Africa", 837476.34, 3456545);
        Country c10 = new Country( "Canada", "North America", 615652.34, 3456545);
        Country c11 = new Country( "Jamaica", "North America", 132451.34, 3456545);
        Country c12 = new Country( "Argentina", "South America", 2636253.34, 3456545);
        Country c13 = new Country( "Peru", "South America", 6354653.34, 3456545);
        Country c14 = new Country( "Uruguay", "South America", 732648732.34, 3456545);
        Country c15 = new Country( "Brazil", "South America", 3632476.34, 3456545);
        Country c16 = new Country( "Austria", "Europe", 32764, 34565);
        Country c17 = new Country( "Belgium", "Europe", 87347623876.34, 3456545);
        Country c18 = new Country( "Cyprus", "Europe", 37264.34, 34565);
        Country c19 = new Country( "Denmark", "Europe", 21353.34, 3456);
        Country c20 = new Country( "Finland", "Europe", 65377.34, 3456545);
        
        var countries = new List<Country>() {c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15, c16, c17, c18, c19, c20 };

        return countries;
    }
} 