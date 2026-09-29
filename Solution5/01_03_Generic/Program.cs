
using Generic;

var intRepo = new GenericReposity<int>();

intRepo.Add(1);
intRepo.Add(2);
intRepo.Add(3);
intRepo.Add(4);

intRepo.PrintWithMessage("Tam sayı listesi ");

var strRepo = new GenericReposity<String>();

strRepo.Add("Enes");
strRepo.Add("Mehmet");
strRepo.Add("Batrakov");

strRepo.PrintWithMessage("İsim listesi ");

