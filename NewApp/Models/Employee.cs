namespace NewApp.Models
{
    public class Employee : Person
    {
        public string EmployeeCode { get; set; }
        
        
        /*public int MaNV { get; set;}
        public string TenNV { get; set;}
        public int Age { get; set; }
        public float Luong { get; set; }
        public void NhapTT()
        {
            
            System.Console.WriteLine("Nhap vao ID nhan vien :");
            MaNV = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Nhap vao ten :");
            TenNV = Console.ReadLine();
            System.Console.WriteLine("Nhap vao tuoi :");
            Age = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Nhap vao luong :");
            Luong = Convert.ToSingle(Console.ReadLine());

        }
        public void HienThiTT()
        {
            
            System.Console.WriteLine("Nhan vien {0} - Id {1} - tuoi la {2} co luong la {3}",TenNV,MaNV,Age,Luong);
        }*/

        public void Nhap()
        {
            base.Nhap();
            System.Console.Write("Employee Code = ");
            EmployeeCode = Console.ReadLine();
            
        }
        

        public void HienThi()
        {
            base.HienThi();
            System.Console.Write("- Ma sinh vien: {0}", EmployeeCode);
        }
    }
}