using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo;

public class Elephant : Animal
{   
    // specific field for only elephant class 
    public double _height { get; set; } = 3.2;

    // declaring default values for the class 
    public Elephant()
    {
        _color = "grå";
        _gender = "kön";
        _age = 10;
        _name = "elefant namn";
        _favoriteFood = "frukt";
    }

    // controktor for custom values 
    public Elephant(string color, string gender, int age, string name, string favoriteFood, double height)
    {
        _color = color;
        _gender = gender;
        _age = age;
        _name = name;
        _favoriteFood = favoriteFood;
        _height = height;
    }

    // specifik metod for this class 
    public void amountElephant()
    {
        Console.WriteLine("det finns runt 400 000 elefanter kvar i världen");
    }

    // overide inherited methods from animal class 
    public override void makeSound()
    {
        Console.WriteLine("elefanten låter som en trumpet med sin snabel");
    }
    public override void origin()
    {
        Console.WriteLine("elefanter kommer från dom tropiska skogarna");
    }
    public override void speedLimit()
    {
        Console.WriteLine("elefanter kan springa upp till 40km/h");
    }
}
