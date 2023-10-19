using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Zoo;

public class Whale : Animal
{
    // specific field for only whale class 
    public int _weight { get; set; } = 3000;

    // declaring default values for the class  
    public Whale()
    {
        _color = "grå";
        _gender = "kön";
        _age = 0;
        _name = "val namn";
        _favoriteFood = "fisk";
    }

    // controktor for custom values 
    public Whale(string color, string gender, int age, string name, string favoriteFood, int weight)
    {
        _color = color;
        _gender = gender;
        _favoriteFood = favoriteFood;
        _weight = weight;
        _name = name;
        _age = age;
    }

    // specifik metod for this class 
    public void sleep()
    {
        Console.WriteLine("valar sover i flock desutom sover dem vertikalt");
    }

    // overide inherited methods from animal class 
    public override void makeSound()
    {
        Console.WriteLine("valen ger ifrån sig ljudvågor genom att blåsa");
    }
    public override void origin()
    {
        Console.WriteLine("valen bor i havet");
    }
    public override void speedLimit()
    {
        Console.WriteLine("valar kan simma upp till 56km/h");
    }

}


