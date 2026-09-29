
using System.Globalization;

namespace Behaviour.Models;

public class Employee : IComparable
{
    public int ID { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }

    public Employee(int id, string name, decimal salary)
    {
        ID = id;
        Name = name;
        Salary = salary;

    }

    public override string ToString()
    {
        return$"{Name, -20} : {Salary, -8}" +
            $"{Salary.ToString("C2",new CultureInfo("en-US")), -8}";
        
    }

    public int CompareTo(object? obj)
    {
        Employee emp = obj as Employee;
        if (emp != null)
        {
            return Salary.CompareTo(emp.Salary);
        }
        return 0;


    }   
}
