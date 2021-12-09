using System;
using System.Collections.Generic;

namespace Note_App
{
    
    class Program
    {
       
        static void Main(string[] args)
        {
            List<string> Title = new List<string>();
            List<string> Description = new List<string>();
            string delNum;
          
            string choice = "Enter what you would like to do:" +
                "Add " +
                "Delete " +
                "Read " +
                "Exit";
            Console.WriteLine(choice);
            string input = Console.ReadLine();
            while(input != "Exit")
            {
                if (input == "Add")
                {
                    Console.WriteLine("Enter the title:");
                    Title.Add(Console.ReadLine());
                    Console.WriteLine("Enter the description");
                    Description.Add(Console.ReadLine());
                }
                else if (input == "Delete")
                {
                    Console.WriteLine("Enter which note you would like to delete:");
                    foreach (string t in Title)
                    {
                        Console.WriteLine(t);
                        
                    };
                    
                    delNum = Console.ReadLine();
                    Title.Remove(delNum);
                }else if(input == "Read")
                {
                    int num = Title.Count;
                    for(int i = 0; i < num; i++)
                    {
                        Console.WriteLine($"Title:{Title[i]}");
                        Console.WriteLine($"Description:{Description[i]}");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input!");
                }
                Console.WriteLine(choice);
                input = Console.ReadLine();
                

            }
            Console.WriteLine("Thank you for using Note App!");


        }
    }
}
