using System;
using System.ComponentModel.DataAnnotations;
namespace burgerShack.Models
{


  public class CustomerFavorite
  {
    public int Id { get; set; }
    public int CustomerId { get; set; }

    public int BurgerId { get; set; }
  }



  public class Customer
  {

    [Required]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }



  }
}