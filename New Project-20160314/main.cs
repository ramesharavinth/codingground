using System.IO;
using System;
using System.Collections.Generic;

public class Cat{
        
    public int Age { get; set; }
        
    public string Name { get; set; }
        
    }
    
class Program
{
    
    
    static void Main()
    {
        
        var primes = new List<Cat>
        {
            new Cat(){ Name = "Sylvester", Age=8 },
            new Cat(){ Name = "Whiskers", Age=2 },
            new Cat(){ Name = "Sasha", Age=14 }
        };
         foreach(var item in primes){
            item.Add("Test",10);
             Console.WriteLine(item.Name + " " + item.Age);
         }
        foreach(var item in primes){
          
            Console.WriteLine(item.Name + " " + item.Age);
       }
        
    }
}
