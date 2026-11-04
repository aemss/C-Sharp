using System;
using System.Collections.Generic;
using System.Text;

namespace Queue;




class Ticket
{


    public Ticket(int id, Customer customer, string topic)
    {
        ID = id;
        Customer = customer;
        Topic = topic;
        CreatedAt = DateTime.Now;
    }

    public int ID { get;}
    public Customer Customer { get; }
    public String Topic { get; }
    public DateTime CreatedAt { get; set; }

    public void Process()
    {
        Console.WriteLine($"İşleniyor -> # {ID, -5} | {Customer.FullName,-20} | {Topic}");

    }

    public override string ToString() => 
        $"#{ID,-5} - {Customer.FullName,-20} - {Topic,-20} - {CreatedAt:HH:mm:ss}";
        
    
    


}
