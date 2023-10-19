using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo;

public class Lion : Animal // inherit from animal class
{
    // specific field for only class 
    public string _fur { get; set; } = "mjuk";

    // declaring default values for the class 
    public Lion() 
    {
        _color = "orange";
        _gender = "kön";
        _age = 7;
        _name = "ljon namn";
        _favoriteFood = "kött";
    }

    // controktor for custom values 
    public Lion(string color, string gender, int age, string name, string favoriteFood, string fur)
    {
        _color = color;
        _gender = gender;
        _age = age;
        _name = name;
        _favoriteFood = favoriteFood;
        _fur = fur;
    }
    
    // specifik metod for this class 
    public void lionMovie()
    {
        Console.WriteLine("det finns många filmer med lejon t.ex. narnia och lejonkungen");
    }

    // overide inherited methods from animal class 
    public override void makeSound()
    {
        Console.WriteLine("lejonet säger roarr");
    }
    public override void origin()
    {
        Console.WriteLine("lejonet bor på savananen");
    }
    public override void speedLimit()
    {
        Console.WriteLine("lejonet springer 74km/h");
    }
}
