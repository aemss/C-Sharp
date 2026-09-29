using System;
using System.Collections.Generic;


namespace List;

internal class CityManager
{
    private readonly List<City> cities;

    public CityManager()
    {
        cities = new List<City>();
        
    }

    public void AddCity(int id, String name)
    {
        //var city = new City(id, name);
        cities.Add(new City(id, name));
    }
    public void PrintAllCities()
    {
        Console.WriteLine("===Şehir Listesi===");
        foreach(var city in cities)
        {
            Console.WriteLine(city);
        }
    
    
    }

    

}



