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
  [Route("api/controller")]
  [ApiController]

  public class CustomerFavoriteController : ControllerBase
  {
    private readonly CustomerFavoriteRepository _custFavRepo;

    //GetBurgersByCustomerId

    [HttpGet("{id")]

    public ActionResult<IEnumerable<Burger>> GetAction(int id)
    {
      IEnumerable<Burger> result = _custFavRepo.GetBurgerByCustomerId(id);
      if (result != null)
      {
        return Ok(result);
      }
      return NotFound();
    }



    //Post: AddFavorite(CustomerBurger)

    [HttpPost]
    public ActionResult<Burger> Post([FromBody] CustomerFavorite burger)
    {
      CustomerFavorite result = _custFavRepo.AddCustomerFavorite(burger);
      return Created("/api/customerfavorite" + result.Id, result);
    }

    //Delete: RemoveFavorite(CustomerBurger)





  }





}