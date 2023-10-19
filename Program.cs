using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace Zoo;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("välkommen till mitt zoo!");
        Console.WriteLine("här finns lejon, elefant och valar. nedan kan du se information om dessa");

        Console.WriteLine("<------------------------------------------------------------------>");
        Console.WriteLine("information om Lejonet:\n");
        LionPrintInfo();

        Console.WriteLine("<------------------------------------------------------------------>");
        Console.WriteLine("information om elefanten:\n");
        ElephantPrintInfo();

        Console.WriteLine("<------------------------------------------------------------------>");
        Console.WriteLine("allmän information om valar:\n");
        WhalePrintInfo();

        Console.WriteLine("<------------------------------------------------------------------>");
        Console.WriteLine("information om blåvalen:\n");
        BlueWhalePrintInfo();

        Console.WriteLine("<------------------------------------------------------------------>");
        Console.WriteLine("information om späckhuggaren:\n");
        KillerWhalePrintInfo();
    }

    public static void LionPrintInfo() // method to print out lion class
    {
        Lion lion = new Lion("orange", "hona", 7, "Maja", "kött", "mjuk"); // object for lion class

        Console.WriteLine("namn: {0}, färg: {1}, kön: {2}, ålder: {3} år, favoritmat: {4}, pälsen: {5}",
            lion._name, lion._color, lion._gender, lion._age, lion._favoriteFood, lion._fur);

        // call for the methods in lion class 
        lion.makeSound();
        lion.origin();
        lion.speedLimit();
        lion.lionMovie();
    }
    public static void ElephantPrintInfo() // method to print out elephant class
    {
        Elephant elephant = new Elephant("grå", "hane", 10, "felix", "frukter", 3.2); // object for elephant class

        Console.WriteLine("Namn: {0}, Färg: {1}, Kön: {2}, Ålder: {3} år, Favoritmat: {4}, Höjd: {5} meter",
            elephant._name, elephant._color, elephant._gender, elephant._age, elephant._favoriteFood, elephant._height);

        // call for the methods in elephant class
        elephant.makeSound();
        elephant.origin();
        elephant.speedLimit();
        elephant.amountElephant();
    }
    public static void WhalePrintInfo() // method to print out whale class
    {
        Whale whale = new Whale();// object for whale class 

        Console.WriteLine("Namn: {0}, Färg: {1}, Kön: {2}, Ålder: {3} år, Favoritmat: {4}, Vikt: {5} kg",
            whale._name, whale._color, whale._gender, whale._age, whale._favoriteFood, whale._weight);

        // call for the methods in whale class
        whale.makeSound();
        whale.origin();
        whale.speedLimit();
        whale.sleep();
    }
    public static void BlueWhalePrintInfo() // method to print out bluewhale class
    {
        BlueWhale blueWhale = new BlueWhale("blå", "hane", 40, "Kalle", "fiskar", 140000, 24); //object for bluewhale class

        Console.WriteLine("Namn: {0}, Färg: {1}, Kön: {2}, Ålder: {3} år, Favoritmat: {4},Vikt: {5}, Längd: {6} meter",
        blueWhale._name, blueWhale._color, blueWhale._gender, blueWhale._age, blueWhale._favoriteFood,
        blueWhale._weight,blueWhale._lenght);

        // call for the methods in bluewhale class
        blueWhale.dive();
        blueWhale.origin();
    }
    public static void KillerWhalePrintInfo() // method to print out killerwhale class 
    {
        KillerWhale killerWhale = new KillerWhale("blå", "hona", 40, "Stina", "fiskar", 4000, 8); // object for killerwhale class

        Console.WriteLine("Namn: {0}, Färg: {1}, Kön: {2}, Ålder: {3} år, Favoritmat: {4},Vikt: {5}, Längd: {6} meter",
        killerWhale._name, killerWhale._color, killerWhale._gender, killerWhale._age, killerWhale._favoriteFood,
        killerWhale._weight, killerWhale._lenght);

        // call for the methods in killerwhale class
        killerWhale.friendlyWhale();
        killerWhale.speedLimit();
    }

}