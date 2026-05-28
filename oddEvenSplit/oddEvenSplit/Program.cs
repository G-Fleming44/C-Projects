
using System.Diagnostics.Contracts;

List<int> odd = new List<int>();
List<int> even = new List<int>();


for (int i = 0; i <= 20; i++)
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