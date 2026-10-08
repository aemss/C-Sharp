
using Behaviour.Models;

var employees = new Employee[]
{
    new Employee(1,"Ahmet",30_000m),
    new Employee(2,"Enes",50_000m),
    new Employee(3,"Arda",60_000m),
    new Employee(4,"Ali",55_000m),
    new Employee(5,"Mehmet",40_000m)
};

Array.Sort(employees);

foreach(var employee in employees)
{
    Console.WriteLine(employee);

}

