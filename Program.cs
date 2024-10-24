using ReflectionClasses.Models;
using System.Reflection;
Orange orange = new Orange();
Orange orange1 = new Orange();
Apple apple = new Apple();
Apple apple2 = new Apple();
PineApple pineapple = new PineApple();
PineApple pineapple2 = new PineApple();

Fruit[] basket = { apple, apple2, pineapple, pineapple2, orange, orange1 };
Assembly assembly = Assembly.GetExecutingAssembly();

foreach (Type type in assembly.GetTypes())
{
    Console.WriteLine("+-+-+-+-+-+-+-+-+---+-+-+-+-+-+-+\n");
    Console.WriteLine(type.Name);
    Console.WriteLine("><><><><><><><><><><><><><><><><>");
    foreach (PropertyInfo property in type.GetProperties())
    {
        Console.WriteLine(property.Name);
    }
}

