using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Errors;

namespace Model;

public class Person
{
    private int age;

    public Person(int age, string? name)
    {
       Age = age;
        Name = name;
    }

    public String? Name { get; set; } = string.Empty;
    public int Age
    {
        get
        {
            return Age;
        }
        set
        {
            if(value < 20 || value > 90)
            {
                throw new  InvalidAgeException("Yaş 20 ve 90 aralığında olmalıdır!");
            }
            age = value;
        
        }
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Kişi: {Name,-10} Yaş: {Age}");
    }




}
