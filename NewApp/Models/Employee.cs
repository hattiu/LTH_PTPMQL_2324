namespace NewApp.Models
{
    public class Employee
    {
        public int EmployeeID { get; set;}
        public string EmployeeName { get; set;}
        public int Age { get; set; }
        public float Luong { get; set; }
        public void Input()
        {
            
            System.Console.WriteLine("Nhap vao ID nhan vien :");
            EmployeeID = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Nhap vao ten :");
            EmployeeName = Console.ReadLine();
            System.Console.WriteLine("Nhap vao tuoi :");
            Age = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Nhap vao luong :");
            Luong = Convert.ToSingle(Console.ReadLine());

        }
        public void Display()
        {
            
            System.Console.WriteLine("Nhan vien {0} - Id {1} - tuoi la {2} co luong la {3}",EmployeeName,EmployeeID,Age,Luong);
        }
    }
}