

using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Console.WriteLine("Please enter a number");
        int num = Convert.ToInt32(Console.ReadLine());





        for (int i = 0; i < 11; i++)
        {
            Console.WriteLine($"{num} * {i} = {num * i}\n");
        }
        Console.ReadKey();*/

        /*for (int i = 1; i <= 15; i++)
        {
            
            if (i % 3 == 0 && i % 5 == 0 )
            {
                Console.WriteLine("FizzBuzz");
            }
            else if(i % 3 == 0 )
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0 )
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
            

        
        }*/
        
        /*Console.WriteLine("Please enter a message");
        string message = Console.ReadLine();

       

        for (int i = 0; i < message.Length; i++)
        {
            Console.Write($"{message[i]}");
            
            
        }

        Console.WriteLine(" ");

        for (int i = message.Length - 1; i >= 0; i--)
        {   
            Console.Write($"{message[i]}");
        }*/

        Console.WriteLine("Please enter your password");
        string password = Console.ReadLine();

        Console.WriteLine("Please confirm your password");
        string confirmPassword = Console.ReadLine();


        if (string.IsNullOrEmpty(password))
        {
            Console.WriteLine("Please enter a password");
            
            if (string.IsNullOrEmpty(confirmPassword))
            {
             Console.WriteLine("Please enter a passowrd confirmation");
            }
        
        
            else{
        
                if (password == confirmPassword)
                {
                 Console.WriteLine("Passwords match");
                }
            else if (password != confirmPassword)
                {
                  Console.WriteLine("Passwords do not match");
                }
            }
        }
    }
}