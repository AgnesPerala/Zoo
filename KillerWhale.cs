using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo;

public class KillerWhale : Whale // inherit from whale class as well as animal class 
{
    // specific field for only killerwhale class 
    public int _weight { get; set; } = 4000;
    public int _lenght { get; set; } = 8;

    // declaring default values for the class 
    public KillerWhale()
    {
        _color = "svart och vit";
        _gender = "kön";
        _age = 10;
        _name = "val namn";
        _favoriteFood = "hajar";
    }

    // controktor for custom values 
    public KillerWhale(string color, string gender, int age, string name, string favoriteFood, int weight, int lenght)
    {
        _color = color;
        _gender = gender;
        _age = age;
        _name = name;
        _favoriteFood = favoriteFood;
        _weight = weight;
        _lenght = lenght;
    }

    // specifik metod for this class 
    public void friendlyWhale()
    {
        Console.WriteLine("späckhuggare kan vara vänliga mot människor pga deras höga inteligens");
    }
    // overide inherited methods from whale class
    public override void speedLimit()
    {
        Console.WriteLine("späckhugare kan simma upp till 60km/h");
    }
}
