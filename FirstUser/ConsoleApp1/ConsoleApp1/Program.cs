﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Dati ceva");
String a = Console.ReadLine();
Console.WriteLine("First user");
<<<<<<< HEAD
Console.WriteLine("First user text conflict");
=======
Console.WriteLine("Second User comment");
>>>>>>> 4f1ed44d349f6ebf78fa64895df7c3f1fbc6ab0d
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

