using System.ComponentModel.DataAnnotations;
namespace burgerShack.Models
{

  public class Side
  {
    [Required]
    public string Name { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    public float Price { get; set; }

    public Side(string name, string desc, float price)
    {
      Name = name;
      Description = desc;
      Price = price;
    }






  }
}