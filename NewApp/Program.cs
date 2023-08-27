internal class Program
{
    private static void Main(string[] args)
    {
       string str = "123";
       int ketQua;
       bool kiemTra = false;
       kiemTra = int.TryParse(str,out(ketQua));
       System.Console.WriteLine("Ket qua = "+ ketQua);
    }
}