using System.Linq;
using System.Data;
using System.Collections.Generic;
using System;

namespace calendar
{
    class Program
    {
         static void Main(string[] args)
        {
            string command = Console.ReadLine();
            string[] parameters = command.Split(" ");
            if (parameters.Length == 2)
            {
                if (parameters[0].Equals("calendar"))
                {
                    Calendar calendar = new Calendar();

                    if (parameters[1] != null)
                    {
                        calendar.Month = Convert.ToInt32(parameters[1]);
                    }
                    
                    calendar.Show();
                } 
            }
            else if (parameters.Length == 3)
            {
                if (parameters[0].Equals("calendar"))
                {
                    Calendar calendar = new Calendar();

                    if (parameters[1] != null)
                    {
                        calendar.Month = Convert.ToInt32(parameters[1]);
                    }

                    if (parameters[2] != null)
                    {
                        calendar.Year = Convert.ToInt32(parameters[2]);
                    }
                    
                    calendar.Show();
                }
            }
            else if (parameters.Length == 1)
            {
                if (parameters[0].Equals("calendar"))
                {
                    Calendar calendar = new Calendar();
                    calendar.Show();
                }
            }
            else 
            {
                Console.WriteLine($"{command}: command not found");
            }

            
        }

    }
}
