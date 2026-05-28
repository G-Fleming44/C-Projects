
using System.Diagnostics.Contracts;

List<int> odd = new List<int>();
List<int> even = new List<int>();


Console.WriteLine("Please enter a number");
int nums = Convert.ToInt32(Console.ReadLine());


for (int i = 0; i <= nums; i++)
{

    if (i % 2 == 0)
    {
        even.Add(i);
    }
    else 
    {
        odd.Add(i);
    }
}

    Console.WriteLine("Now printing even numbers");

    foreach (var item in even)
    {
        Console.Write($"{item} ");
    }

    Console.WriteLine(Environment.NewLine + "Now printing odd numbers");
    foreach (var item in odd)
    {
        Console.Write($"{item} ");
    }

    Console.ReadLine();