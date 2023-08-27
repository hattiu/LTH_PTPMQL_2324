namespace NewApp.Models
{
    public class Person
    {
        //khai bao cac thuoc tinh
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        //khai bao cac phuong thuc
        public void Nhap()
        {
            System.Console.Write("Name: ");
            Name = Console.ReadLine();

            System.Console.Write("Address: ");
            Address = Console.ReadLine();

            System.Console.Write("Age: ");
            Age = Convert.ToInt16(Console.ReadLine());
            
        }

        public void HienThi()
        {
           
            System.Console.WriteLine("{0} - {1} -{2} tuoi",Name, Address,Age);
        }

        //xây dựng phương thức Display2(), chứa 2 tham số ten (kiểu string) và tuoi (kiểu int)
        public void HienThi2(string Name, int Age)
        {
            System.Console.WriteLine("{0} - {1} tuoi",Name,Age);
        }

        //xây dựng phương thức GetYearOfBirth(), sử dụng để tính năm sinh dựa trên tuổi của đối tượng (được truyền vào dưới dạng tham số)
        public int GetYearOfBirth(int age)
        {
            int yearOfBirth = 2023 - age;
            return yearOfBirth;
        }

        
        
        
        
        
        
    }
}