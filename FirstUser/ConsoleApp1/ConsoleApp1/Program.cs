﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Dati ceva");
String a = Console.ReadLine();

try
{
    if(Int32.TryParse(a,out int b))
    {
        Console.WriteLine(b + "is a integer");
    }
    else
    {
        Console.WriteLine(a + " is not a integer!");
    }
}catch(Exception ex)
{
   Console.WriteLine(ex.ToString());
}

