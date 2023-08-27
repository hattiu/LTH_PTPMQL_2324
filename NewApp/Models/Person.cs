namespace NewApp.Models
{
    public class Person
    {
        //khai bao cac thuoc tinh
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        //khai bao cac phuong thuc
        public Person()
        {
            Name = "Ho ten mac dinh";
            Address = "Dia chi mac dinh";
            Age = 20;
        }
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

        public void HienThi(string ten, int tuoi)
        {
           
            System.Console.WriteLine("Sinh Vien {0} - {1} tuoi",ten, tuoi);
        }

        public void HienThi(string ten, string diaChi)
        {
           
            System.Console.WriteLine("Sinh Vien {0} - {1} ",ten, diaChi);
        }

        public int GetYearOfBirth(int age)
        {
            int yearOfBirth = 2023 - age;
            return yearOfBirth;
        }
    }
}