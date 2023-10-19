using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo;

public class Animal
{
    // fields for base class animal with default values 
    public int _age { get; set; } = 0;
    public string _gender { get; set; } = "okänd";
    public string _color { get; set; } = "okänd";
    public string _favoriteFood { get; set; } = "okänd";
    public string _name { get; set; } = "okänd";

    // methods that every class has with dufault values 
    public virtual void makeSound()
    {
        Console.WriteLine("djuren låter");
    }
    public virtual void origin()
    {
        Console.WriteLine("alla djur har olika ursprung");
    }
    public virtual void speedLimit()
    {
        Console.WriteLine("alla djur tar sig fram olika snabbt");
    }

}
