using System;
using System.Collections.Generic;
using System.Linq;
using burgerShack.Models;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using burgerShack.Repositories;

namespace burgerShack.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class BurgersController : ControllerBase
  {
    private readonly BurgerRepository _burgerRepo;

    public IEnumerable<Burger> Burgers { get; private set; }

    public BurgersController(BurgerRepository burgerRepo)
    {
      _burgerRepo = _burgerRepo;
    }






    //Get api/burgers 

    [HttpGet]
    public IEnumerable<Burger> Get()
    {
      return _burgerRepo.Getall();
    }



    //get api/burgers/by Id
    [HttpGet("{id}")]
    public ActionResult<Burger> GetAction(int id)
    {
      Burger result = _burgerRepo.GetBurgerById(id);
      if (result != null)
      {
        return Ok(result);
      }
      return NotFound();
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