using NewApp.Models;
public class Program
{
    private static void Main(string[] args)
    {
        /*Employee mpl = new Employee ();
        mpl.NhapTT();
        mpl.HienThiTT();*/
        
        /*Person ps1 = new Person();
        Person ps2 = new Person();
        
        //gán giá trị cho thuộc tính đối tượng ps1

        ps1.Name = "Nguyan Van B";
        ps1.Address = "ha noi";
        ps1.Age = 18;
        //gọi phương thưcs hiển thịthoong tin
        ps1.HienThi();
        ps2.HienThi();

        /*SinhVien sv = new SinhVien();
        sv.NhapTTSV();
        sv.HienThiTTSV();*/

        /*Person ps = new Person();
        string str = "Nguyen Van A";
        int a = 22;
        Console.WriteLine("{0} sinh nam {1}", str,ps.GetYearOfBirth(a));*/

        /*GiaiPT gpt = new GiaiPT();
        gpt.GPTBac1();
        gpt.GPTBac2();*/

        SinhVien sv = new SinhVien();
        sv.Nhap();
        sv.SinhVienCode = "123456789";
        sv.HienThi();


    }
}