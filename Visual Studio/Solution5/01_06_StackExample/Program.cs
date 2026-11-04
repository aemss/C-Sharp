using StackExample;
using System;
using System.Collections.Generic;


static void Main()
{
    IChecker checker = new BracketChecker();

    string dengeliMetin = "{[(a+b) * c]}";
    string dengesizMetin = "[(a+b) * c]";

    Console.WriteLine($"{dengeliMetin} -> {checker.Check(dengeliMetin)}");
    Console.WriteLine($"{dengesizMetin} -> {checker.Check(dengesizMetin)}");
}
