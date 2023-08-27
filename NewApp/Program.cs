using NewApp.Models;
public class Program
{
    private static void Main(string[] args)
    {
        /*Employee mpl = new Employee ();
        mpl.NhapTT();
        mpl.HienThiTT();*/
        
        Person ps1 = new Person();
        Person ps2 = new Person();
        
        //gán giá trị cho thuộc tính đối tượng ps1

        ps2.Name = "Nguyan Van B";
        ps2.Address = "ha noi";
        ps2.Age = 18;
        //gọi phương thưcs hiển thịthoong tin
        ps2.HienThi();

    }
}