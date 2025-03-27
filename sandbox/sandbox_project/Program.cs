using System;
using System.Collections.Generic;


public class Program
{

    static void Main(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.
         var filename = "./census.txt";
        var degrees = new Dictionary<string, int>();
        foreach (var line in File.ReadLines(filename))
        {
            var fields = line.Split(",");
            var degree = fields[3].Trim();;
            
                if (degrees.ContainsKey(degree))
                {
                    degrees[degree]++;
                    
                }
                else
                {
                    degrees[degree] = 1;
                }
                
            
        }
            Console.WriteLine(degrees["11th"]);


        
    }

    
}


// public static int CountDuplicates(int[] data)
// {
//     // Add code here.
//     return 0;
// }