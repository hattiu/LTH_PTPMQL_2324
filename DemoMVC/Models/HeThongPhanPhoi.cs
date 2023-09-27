using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class HeThongPhanPhoi
    {
        [Key]
        public string MaHeThong { get; set; }
        
        public string HeThongPhanPhoiName { get; set; }
        public string Address { get; set; }
        public string NamHeThong { get; set; }
        
        
        
        
        
        
    }
}