using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public  class Student
    {
        [Key]
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        
        
        
        
    }
}