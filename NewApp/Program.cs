/*internal class Program 
{
// tính căn bậc hai
    /*static double squareRoot(int number)
        {
            double temp;
            double sr = number / 2;
 
            do
            {
                temp = sr;
                sr = (temp + (number / temp)) / 2;
            } while ((temp - sr) != 0);
            return sr;
        }
    private static void Main(string [] args)
    {
        //khai báo một biến a là số cần tính
            int a;
            //yêu cầu người dùng nhập vào số a
            Console.Write("\n Nhap vao so can tinh: ");
            a = Convert.ToInt32(Console.ReadLine());
            //gọi hàm squareRoot() đã tạo ở trên để tính căn bậc hai và hiển thị kết quả ra màn hình.
            //Kêt quả được làm trong tới 3 chữu sô thập phân
            Console.WriteLine("\n Can bac hai cua so {0} sau khi lam tron la: {1}", a , Math.Round(squareRoot(a), 3));

    }*/

        //Khai báo và gán giá trị cho 2 biến số kiểu string và int, sau đó in ra màn hình:
        /*string hoTen = "Le Thi Hoa";
        int maSV = 1921050251;
        Console.WriteLine("Sinh Vien {0} - {1} maSV", hoTen, maSV);*/

        //sử dụng để đọc 1 chuỗi ký tự nhập vào từ bàn phím và trả về chuỗi ký tự đó.
       /* Console.Write("Ho va Ten: ");
        string str = Console.ReadLine();
        Console.WriteLine("Sinh vien: " + str);*/
       
        //Khai báo và gán giá trị cho 2 hằng số kiểu string và int, sau đó in ra màn hình
        /*const string hoTen = "Le thi hoa";
        const int maSV = 1921050251;
        Console.WriteLine("Sinh vien {0} - Ma sinh vien {1}", hoTen, maSV);*/

//tính bình phương
    /// Tính bình phương của số thực double
        
       /* static void Main(string[] args)
        {
            int ketqua;
            Console.Write("\n Nhap vao so can tinh: ");
            ketqua = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bình phương là: " + ketqua);
        }

        static double BinhPhuong(double number)
        {
            double ketqua = number * number;
            return ketqua;
        }*/

using NewApp.Models;
public class Program
{
    private static void Main(string[] args)
    {
        //Cấu trúc để tạo ra một Object từ một Class:
        //tạo ra 1 đối tượng tên là ps1 từ khuôn mẫu (class) Person
        //khơir tạo hai đối tượng từ class person
        Person ps1 = new Person();
        Person ps2 = new Person();
        
        //gán giá trị cho thuộc tính đối tượng ps1

        ps1.Name = "Nguyan Van A";
        ps1.Address = "ha noi";
        ps1.Age = 18;
        //gọi phương thưcs hiển thịthoong tin
        ps1.HienThi();
    }
}

        /*Student std = new Student();
        std.StudentName = "Nguyen van b";
        std.StudentID = 123456;
        std.In();

        Person ps = new Person();
        string str = "Nguyen Van C";
        int a = 23;
        /*ps.HienThi2(str, a);
        Console.WriteLine("{0} nam sinh {1}", str,ps.GetYearOfBirth(a));

        GiaPT gpt = new GiaPT();
        gpt.GPTBac1();
        gpt.GPTBac2();
        
        Employee mpl = new Employee ();
        mpl.Input();
        mpl.Display();
        
//giải phương trình bậc nhất 
    static void Main(string[] args)
        {
            //khai báo hai biến a và b là hai cơ số mà người dùng nhập vào
            int a, b;
            //khai báo biến x là nghiệm của phương trình
            double x;
            //yêu cầu người dùng nhập vào hai số a và b
            Console.Write("\n Nhap vao so a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Nhap vao so b: ");
            b = Convert.ToInt32(Console.ReadLine());
            //hiển thị phương trình bậc nhất mà người dùng vừa nhập dưới dạng ax + b = 0
            Console.WriteLine("\n Chuong trinh ban vua nhap la {0}x + {1} = 0.", a, b);
            //kiểm tra a = 0
            if(a == 0)
            {
                //nếu a = 0 và b = 0 thì phương trình vô số nghiệm
                if(b == 0)
                {
                    Console.WriteLine("\n Phuong trinh co vo so nghiem.");
                }
                //nếu a = 0 và b != 0 thì phương trình vô nghiệm
                else
                {
                    Console.WriteLine("\n Phuong trinh vo nghiem.");
                }
            }
            //trường hợp a != 0 thì ta tính theo công thức x = -b/a
            else
            {
                x = (double)-b / a;
                //Sử dụng phương thứ Math.Round() để làm tròn kết quả lên 2 số thập phân
                Console.WriteLine("\n Phuong trinh co nghiem x = {0}", Math.Round(x,2));
            }
        }
   
//giải phương trình bậc hai
    /*static void Main(string[] args)
        {
            //khai báo hai biến a, b vầ c là va tham số mà người dùng nhập vào
            int a, b, c;
            //khai báo biến x1, x2 là nghiệm của phương trình và biến delta
            double x1, x2, delta;
            //yêu cầu người dùng nhập vào ba số a, b, c
            Console.Write("\n Nhap vao so a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Nhap vao so b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Nhap vao so c: ");
            c = Convert.ToInt32(Console.ReadLine());
            //hiển thị phương trình bậc hai mà người dùng vừa nhập dưới dạng ax^2 + bx + c = 0
            Console.WriteLine("\n Chuong trinh ban vua nhap la {0}x^2 + {1}x + {2} = 0.", a, b, c);
            //nếu a = 0 thì phương trình bậc hai trở thành phương trình bậc nhất
            if (a == 0)
            {
                //ta giải phương trình bậc nhất bx + c = 0
                if (b == 0)
                {
                    //nếu b = 0 và c = 0 thì phương trình vô số nghiệm
                    if (c == 0)
                    {
                        Console.WriteLine("\n Phuong trinh co vo so nghiem.");
                    }
                    //nếu b = 0 và c != 0 thì phương trình vô nghiệm
                    else
                    {
                        Console.WriteLine("\n Phuong trinh vo nghiem.");
                    }
                }
                else
                {
                    x1 = (double)-c / b;
                    //Sử dụng phương thứ Math.Round() để làm tròn kết quả lên 2 số thập phân
                    Console.WriteLine("\n Phuong trinh co nghiem duy nhat x = {0}", Math.Round(x1, 2));
                }
            }
            //nếu a != 0 thì ta bắt đầu giải phương trình bậc hai
            else
            {
                //tính delta
                delta = Math.Pow(b, 2) - 4 * a * c;
                //kiểm tra nếu delta < 0 thì phương trình vô nghiệm
                if (delta < 0)
                {
                    Console.WriteLine("\n Phuong trinh vo nghiem.");
                }
                //nếu delta = 0 thì phương trình có hai nghiệm kép
                else if (delta == 0)
                {
                    x1 = x2 = -b / (2 * a);
                    Console.WriteLine("\n Phuong trinh co nghiem kep x1 = x2 = {0}", x1);
                }
                //nếu delta > 0 thì phuong trình có hai nghiệm phân biệt
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("\n Phuong trinh hai nghiem phan biet:\n X1 = {0}\n X2 = {1}", x1, x2);
                }
            }
        }*/
    /*}

}*/

/*Console.Write("NHAP: ");
string str = Console.ReadLine();
str = str.ToUpper();
Console.WriteLine("CHUYEN THANH CHU HOA: {0}" , str);


//in ra kí tự hoa đầu tiên
Console.Write("NHAP: ");
string str0 = Console.ReadLine();
Console.WriteLine("Sinh vien: " + str);
string str1 = str0.Substring(0, 1);
string str2 = str0.Substring(1);
//sử dụng phương thức ToUpper() để in hoa ký tự đầu tiên, tức là str1
str1 = str1.ToUpper();
//sau đó cộng hai chuỗi str1 và str2 lại với nhau để đưuọc kết quả
str = str1 + str2;
Console.WriteLine("CHUYEN THANH CHU HOA: " + str);*/

//array
/*public class Program 
{
    private static void Main (string[] args)
    {
        ArrayList arrStudent = new ArrayList();
        System.Console.Write("nhap n=   ");
        int n = Convert.ToInt32(Console.ReadLine());
        //NHAP THONG TIN VA ADD VAO ARRAY LIST
        for( int i = 0; i < n; i ++)
        {
            Student std = new Student ();
            std.Enterdata();
            arrStudent.Add(std);
        }
        //HIEN THI THONG TIN TRONG ARRAY LIST
        foreach(Student std in arrStudent)
        {
            std.Display();
        }
        
        //SUA THONG TIN
        System.Console.WriteLine("Nhap thong tin sinh vien muon sua: ");
        string str = Console.ReadLine();
        foreach (Student std in arrStudent)
        {
            if (std.StudentID.Equals(std))
            {
                int intIndex = -1;
                while(intIndex < 0 || intIndex >= n)
                {
                    System.Console.WriteLine("Nhap chi so cua phan tu muon sua: ");
                    intIndex = Convert.ToInt32(Console.ReadLine());
                    //khai bao 1 phan tu Student moi
                    Student stdUpdate = new Student();
                    stdUpdate.Enterdata();
                    //gan phan tu moi vao phan tu co index = intIndex
                    arrStudent[intIndex] = stdUpdate;
                }
                foreach ( Student stdUpdate in arrStudent )
                {
                    stdUpdate.Display();
                }
            }
            
        }

    }
}*/

/*using NewApp.Models;
public class Program
{
    private static void Main(string[] args)
    {
        
        Student std = new Student();
        std.Nhap();
        std.StudentCode = "123456";
        std.HienThi();
    }
}*/