using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
{
    [Table("DaiLys")]
    public class DaiLy
    {
        [Key]
        public string DaiLyId { get; set; }
        public string DaiLyName { get; set; }
        public string Address { get; set; }
        
        
        
        
        
        
    }
}