using System.Runtime.Intrinsics.Arm;

internal class Program
{
    private static void Main(string[] args)
    {
     for(int i=0; i<10; i++)
     {
        if(i == 5) continue;
        System.Console.WriteLine("vong lap thu {0}", i);
     }
    }
}