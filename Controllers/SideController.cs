using System;
using System.Collections.Generic;
using System.Linq;
using burgerShack.Models;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace burgerShack.Controllers
{
  [Route("api/[controller]")]
  [ApiController]

  public class SidesController : ControllerBase
  {

    public List<Side> Sides = new List<Side>()
    {
      new Side("Potato Salad", "Better then all the other sides", 3.25f),
      new Side("Coleslaw", "Ohh getting hungry now", 2.50f),
      new Side("Fries", "Still made from tatos so they got that going for them.", 1),
    };

    // Get Api/side

    [HttpGet]
    public IEnumerable<Side> Get()
    {
      return Sides;
    }


    // Get Api Side/id

    [HttpGet("{id}")]
    public ActionResult<Side> GetAction(int id)
    {
      try
      {
        return Sides[id];
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return NotFound("{\"error\": \"NO SUCH BURGER\"}");
      }
    }


    // post Api/sides

    [HttpPost]
    public ActionResult<List<Side>> Post([FromBody] Side side)
    {
      Sides.Add(side);
      return Sides;
    }


    // put Api/sides/id

    [HttpPut("{id}")]

    public ActionResult<List<Side>> Put(int id, [FromBody] Side side)
    {
      try
      {
        Sides[id] = side;
        return Sides;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return NotFound("{\"error\": \"NO SUCH BURGER\"}");
      }
    }


    //  Delete Api/side

    [HttpDelete("{id")]

    public ActionResult<List<Side>> Delete(int id)
    {
      try
      {
        Sides.Remove(Sides[id]);
        return Sides;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return NotFound("{\"error\": \"NO SUCH BURGER\"}");
      }
    }













  }
}