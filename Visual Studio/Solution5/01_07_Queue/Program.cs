
using Queue;

var c1 = new Customer(1,"Enes ");
var c2 = new Customer(2,"Ali");
var c3 = new Customer(3,"Mehmet");
var c4 = new Customer(4, "Kerem");

var desk = new ServicesDesk();

desk.Enqueue(new Ticket(101,c1,"Şifre Sıfırlama "));
desk.Enqueue(new Ticket(201, c2, "Ödeme Sorunu "));
desk.Enqueue(new Ticket(301, c3, "Giriş Hatası "));

desk.PrintQueue();

desk.PeekNext();
desk.ProcessNext();
desk.ProcessNext();

desk.PrintQueue();
desk.ProcessNext();
desk.ProcessNext();





