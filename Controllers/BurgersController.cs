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
  public class BurgersController : ControllerBase
  {
    public List<Burger> Burgers = new List<Burger>()
    {
      new Burger("Mark Burger", "A delicous burger made by mark", 7.50f),
      new Burger("brian burger", "its made from elk", 9.99f),
      new Burger("porter-house", "this was a well done joke/pbj", 4.95f)
    };


    //Get api/burgers

    [HttpGet]
    public IEnumerable<Burger> Get()
    {
      return Burgers;
    }



    //get api/burgers/by Id
    [HttpGet("{id}")]
    public ActionResult<Burger> GetAction(int id)
    {
      try
      {
        return Burgers[id];
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return NotFound("{\"error\": \"NO SUCH BURGER\"}");
      }
    }


    //post api burgers

    [HttpPost]
    public ActionResult<List<Burger>> Post([FromBody] Burger burger)
    {
      Burgers.Add(burger);
      return Burgers;
    }


    // PUT api/burgers/id

    [HttpPut("{id}")]
    public ActionResult<List<Burger>> Put(int id, [FromBody] Burger burger)
    {
      try
      {
        Burgers[id] = burger;
        return Burgers;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return NotFound("{\"Error\": \"NO SUCH BURGER\"}");

      }
    }



    // Delete api/Burger

    [HttpDelete("{id}")]
    public ActionResult<List<Burger>> Delete(int id)
    {
      try
      {
        Burgers.Remove(Burgers[id]);
        return Burgers;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return NotFound("{\"Error\": \"NO SUCH BURGER\"}");

      }
    }



  }
}