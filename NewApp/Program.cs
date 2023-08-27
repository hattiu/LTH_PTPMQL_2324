using System.Runtime.Intrinsics.Arm;

internal class Program
{
    private static void Main(string[] args)
    {
     int a = 1;
     while(a<10)
     {
        System.Console.WriteLine("vong lap thu {0}", a);
        a++;
     }
    }
}