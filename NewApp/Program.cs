using System.Security.Cryptography;
using System.Transactions;
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

        /*SinhVien sv = new SinhVien();
        sv.Nhap();
        sv.SinhVienCode = "123456789";
        sv.HienThi();*/

        /*Employee emp = new Employee();
        emp.Nhap();
        emp.EmployeeCode = "987456123";
        emp.HienThi();*/

        /*SinhVien sv = new SinhVien();
        sv.Nhap();
        sv.HienThi();*/

        /*Employee emp = new Employee();
        emp.NhapTT();
        emp.HienThiTT();*/

        //xu li ngoaij le
        /*Person ps = new Person();
        ps.Nhap();
        ps.HienThi();*/

        /*SinhVien sv = new SinhVien();
        sv.NhapTTSV();
        sv.HienThiTTSV();*/

        int n = 0;
        do
        {
            Console.WriteLine("Nhap vao n = ");
            n = Convert.ToInt32(Console.ReadLine());
            
        } while (n <0);

        SinhVien[] sinhvienArr = new SinhVien[n];
        //nhap thong tin sinh vien
        for(int i = 0; i < sinhvienArr.Length; i ++)
        {
            System.Console.WriteLine("nhap vao phan tu thu {0}",i);
            SinhVien sv = new SinhVien();
            sv.NhapTTSV();
            sinhvienArr[i] = sv;
        }
        //hien thi thong tin sinh vien
        foreach(SinhVien sv in sinhvienArr)
        {
            sv.HienThiTTSV();

        }
        //sua thong tin sinh vien
        foreach(SinhVien sv in sinhvienArr)
        {
            System.Console.WriteLine("thong tin sua la: {0} tuoi",sv.Age);
            //SinhVien svUpdate = new SinhVien();
            //svUpdate.HienThiTTSV();
            sv.HienThiTTSV();

        }
        //xoa thong tin sinh vien
        foreach(SinhVien sv in sinhvienArr)
        {
            sv.Age=null;
            sv.HienThiTTSV();

        }





    }
}