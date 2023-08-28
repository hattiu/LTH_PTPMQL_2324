namespace NewApp.Models
{
    public class SinhVien : Person
    {
        public string SinhVienCode { get; set; }
        
        public string HoTen { get; set;}
        public string diaChi { get; set;}
        public int Age { get; set; }
        public int SDT { get; set; }
        public void NhapTTSV()
        {
            
            System.Console.WriteLine("Ho va Ten  :");
            HoTen = Console.ReadLine();
            System.Console.WriteLine("Dia chi :");
            diaChi = Console.ReadLine();
            System.Console.WriteLine("Tuoi :");
            Age = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("SDT :");
            SDT = Convert.ToInt32(Console.ReadLine());

            try{
                SDT = Convert.ToInt16(Console.ReadLine());
                
            }catch(Exception e)
            {
                //cau lenh xu li ngoai le
                SDT = 0;
            }

        }
        public void HienThiTTSV()
        {
            
            System.Console.WriteLine("Sinh vien {0} - Dia chi {1} - {2} Tuoi - SDT: {3}",HoTen,diaChi,Age,SDT);
        }

        /*public void Nhap()
        {
            base.Nhap();
            System.Console.Write("Student Code = ");
            SinhVienCode = Console.ReadLine();
            
        }

        public void HienThi()
        {
            base.HienThi();
            System.Console.Write("- Ma sinh vien: {0}", SinhVienCode);
        }*/
    }
}