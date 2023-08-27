namespace NewApp.Models
{
    public class Employee
    {
        public int MaNV { get; set;}
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
        }
    }
}