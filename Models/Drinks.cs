using System.ComponentModel.DataAnnotations;

namespace burgerShack.Models
{
  public class Drink
  {

    [Required]

    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    [MinLength(3)]

    public string Description { get; set; }
    [Range(1, float.MaxValue)]

    public float Price { get; set; }

    // public Drink(string name, string desc, float price)
    // {
    //   Name = name;
    //   Description = desc;
    //   Price = price;
    // }











  }
}