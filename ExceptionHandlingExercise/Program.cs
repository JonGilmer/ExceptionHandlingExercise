using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            char[] arr = new char[9] { '9', '4', 'J', '6', 'A', '3', '1', '8', 'G' };
            List<int> numbers = new List<int>();
            string str = "";

            foreach (var item in arr)
            {
                try
                {
                    str = item.ToString();
                    int parsedChar = int.Parse(str);
                    numbers.Add(parsedChar);
                }
                catch (System.FormatException e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine($"********* Unable to Parse '{item}'");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine($"********* Unable to Parse '{item}'");
                }
                finally
                {
                    Console.WriteLine(item);
                }
            }

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
