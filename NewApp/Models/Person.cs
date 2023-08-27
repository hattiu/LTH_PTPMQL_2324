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
    }
}