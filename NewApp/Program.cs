using NewApp.Models;
public class Program
{
    private static void Main(string[] args)
    {
        Person ps1 = new Person();
        Person ps2 = new Person();

        ps1.Name = "Nguyen Van A";
        ps1.Address = "Ha Noi";
        ps1.Age = 18;

        ps1.HienThi();

    }
}