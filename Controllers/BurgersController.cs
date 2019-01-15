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
      _burgerRepo = burgerRepo;
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
    public ActionResult<Burger> Post([FromBody] Burger burger)
    {
      return Created("/api/burgers", _burgerRepo.AddBurger(burger));
    }


    // PUT api/burgers/id

    [HttpPut("{id}")]
    public ActionResult<Burger> Put(int id, [FromBody] Burger burger)
    {
      Burger result = _burgerRepo.EditBurger(id, burger);
      if (result != null)
      {
        return result;
      }
      return NotFound();
    }



    // Delete api/Burger

    [HttpDelete("{id}")]
    public ActionResult<Burger> Delete(int id)
    {
      if (_burgerRepo.DeleteBurger(id))
      {
        return Ok("success");
      }
      return NotFound("No burger to delete")
    }



  }
}