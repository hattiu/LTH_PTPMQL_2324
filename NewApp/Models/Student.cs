namespace NewApp.Models
{
    public class Student: Person
    {

        public string StudentCode {get; set; }
        /*public string StudentName { get; set; }
        public int StudentID { get; set; }
        
        public void Du()
        {
            System.Console.Write("StudentName: ");
            StudentName = Console.ReadLine();

            System.Console.Write("StudentID: ");
            StudentID = Convert.ToInt16(Console.ReadLine());
            
        }
        public void In()
        {
            System.Console.WriteLine("{0} - {1}", StudentName, StudentID);
        }*/

        //ke thua class person
        public void Nhap()
        {
            //ke thua lai phuong thuc o class person
            base.Nhap();
            //phat trien them nhap thong tin cua student code
            System.Console.Write("Student code = ");
            StudentCode = Console.ReadLine();
            
        }

        public void HienThi()
        {
            //ke thua laij phuong thuc ow class person
            base.HienThi();
            //phat trien hien thi nhap tt studentcode
            System.Console.Write("- ma sinh vien: {0}", StudentCode);
        }
    }
}