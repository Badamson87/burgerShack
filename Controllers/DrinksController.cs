using System;
using System.Collections.Generic;
using System.Linq;
using burgerShack.Models;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace burgerShack.Controllers
{
  [Route("api/controller]")]
  [ApiController]

  public class DrinksController : ControllerBase
  {
    public List<Drink> Drinks = new List<Drink>()
    {
      new Drink("Pepsi", "I could really go for one right now", 1.50f),
      new Drink("rootBeer", "An old school fav", 1.25f),
      new Drink("Cola", "its LIke Pepsi but for sad people", .25f),
    };

    //get api

    [HttpGet]
    public IEnumerable<Drink> Get()
    {
      return Drinks;
    }


    // get api drinks/by id
    [HttpGet("{id}")]

    public ActionResult<Drink> GetAction(int Id)
    {
      try
      {
        return Drinks[Id];
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return NotFound("{\"error\": \"NO SUCH BURGER\"}");
      }
    }


    // post Api drink
    [HttpPost]
    public ActionResult<List<Drink>> Post([FromBody] Drink drink)
    {
      Drinks.Add(drink);
      return Drinks;
    }

    // put api/drink id

    [HttpPut("{id}")]
    public ActionResult<List<Drink>> Put(int id, [FromBody] Drink drink)
    {
      try
      {
        Drinks[id] = drink;
        return Drinks;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return NotFound("{\"error\": \"NO SUCH BURGER\"}");
      }
    }


    //Delete Api/ drink

    [HttpDelete("{id}")]

    public ActionResult<List<Drink>> Delete(int id)
    {
      try
      {
        Drinks.Remove(Drinks[id]);
        return Drinks;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return NotFound("{\"error\": \"NO SUCH BURGER\"}");
      }
    }




  }
}