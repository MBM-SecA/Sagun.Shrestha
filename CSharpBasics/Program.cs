﻿using System.Diagnostics;
using LearnCollections;
public class Program
{
    static void Main()
    {
        //Collections collections = new Collections();
        //collections.LearnDictionary();


        Square square = new Square(12.4);
        //square.Side = 12;
        square.Display();
       //var SquareArea = square.GetArea();
 
        Rectangle rect = new Rectangle(12.4 , 16.1);
        var AreaRect =  rect.GetArea();
        var CircRect = rect.GetCircumference();

    

 

    }
}