using System;
using System.Collections.Generic;
using System.Text;

namespace Queue;

public class Customer
{
    public int ID { get;}
    public String FullName { get; }

    public Customer(int id, string fullname)
    {
        ID = id;
        FullName = fullname;
    }

    public override string ToString() =>
        $"{FullName,-20} #{ID}";
    
       
    

}
