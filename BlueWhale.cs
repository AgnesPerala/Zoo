using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo;

public class BlueWhale : Whale // inherit from whale class as well as animal class  
{
    // specific field for only bluewhale class 
    public int _weight { get; set; } = 140000;
    public int _lenght { get; set; } = 24;

    // declaring default values for the class 
    public BlueWhale()
    {
        _color = "blå";
        _gender = "kön";
        _age = 40;
        _name = "val namn";
        _favoriteFood = "fiskar";
    }

    // controktor for custom values 
    public BlueWhale(string color, string gender, int age, string name, string favoriteFood, int weight, int lenght)
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
    public void dive()
    {
        Console.WriteLine("blåvalen kan dyka ner till 200 meter under ytan");
    }
    // overide inherited methods from whale class 
    public override void origin()
    {
        Console.WriteLine("blåvalen kan man hitta på stilla havet");
    }

}
