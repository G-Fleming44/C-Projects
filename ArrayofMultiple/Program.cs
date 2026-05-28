using System.Diagnostics.Metrics;
using System.Globalization;

int num = 7;
int length = 5;
int[] result = new int[length];
int counter = 0;


for (int i = 1 ; i  <= result.Length; i++, counter++)
{
    result[counter] = num * i;

}

foreach (var nums in result)
{
    Console.WriteLine($"{nums} ");
}