using System.Collections.Generic;
using burgerShack.Models;
using Microsoft.AspNetCore.Mvc;

namespace burgerShack.Db
{
  static class FakeDb
  {
    // public class DrinksController : ControllerBase
    // {
    //   public List<Drink> Drinks = new List<Drink>()
    // {
    //   new Drink("Pepsi", "I could really go for one right now", 1.50f),
    //   new Drink("rootBeer", "An old school fav", 1.25f),
    //   new Drink("Cola", "its LIke Pepsi but for sad people", .25f),
    // };
    // }


    // public class SidesController : ControllerBase
    // {

    //   public List<Side> Sides = new List<Side>()
    // {
    //   new Side("Potato Salad", "Better then all the other sides", 3.25f),
    //   new Side("Coleslaw", "Ohh getting hungry now", 2.50f),
    //   new Side("Fries", "Still made from tatos so they got that going for them.", 1),
    // };
    // }


    public static List<Burger> Burgers = new List<Burger>()
    {
      new Burger("Mark Burger", "A delicous burger made by mark", 7.50f),
      new Burger("brian burger", "its made from elk", 9.99f),
      new Burger("porter-house", "this was a well done joke/pbj", 4.95f)
    };









  }
}
