﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Dati ceva");
String a = Console.ReadLine();
Console.WriteLine("Second user");
Console.WriteLine("TRALALALALAAALALALA");
Console.WriteLine("First user for conflict");
Console.WriteLine("First user in development branch");
Console.WriteLine("TRALAALALALA AL LAALALAL FIRST USER CHANGES");
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

