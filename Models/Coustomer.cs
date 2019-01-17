using System;
using System.ComponentModel.DataAnnotations;
namespace burgerShack.Models
{


  public class Customer
  {

    [Required]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }



  }
}