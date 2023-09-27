using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models;

public class Movie
{
    [Key]
    public string Id { get; set; }
    public string? Title { get; set; }
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }
    public string? Genre { get; set; }
    public decimal Price { get; set; }
    
}
