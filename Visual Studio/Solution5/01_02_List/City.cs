
using System.Collections.Generic;


namespace List;

internal class City
{
    public City(int id,String name) 
    {
        ID = id;
        Name = name;
    }
    

    public int ID { get; }
    public String Name { get;}

    public override string ToString() =>
        $"{ID,-5} {Name,-20}";

}
