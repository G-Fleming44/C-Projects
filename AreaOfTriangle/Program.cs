

using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

int width = ReadInt("Width");
int height = ReadInt("height");

Console.WriteLine($"The area is {AreaOfTriangle(width, height)}");


static int AreaOfTriangle(int width, int height)
{
    return (width * height) / 2;
}

static int ReadInt(string message)
{
    Console.Write($"Enter {message}");
    return Convert.ToInt32(Console.ReadLine());
}




