// using System;
// using System.Collections.Generic;
// using System.Linq;
// using burgerShack.Models;
// using System.Net.Http;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using burgerShack.Repositories;

// namespace burgerShack.Controllers
// {
//   [Route("api/controller]")]
//   [ApiController]

//   public class DrinksController : ControllerBase
//   {

//     private readonly DrinkRepository _drinkRepo;
//     //get api
//     public IEnumerable<Drink> Drinks { get; private set; }

//     public DrinksController(DrinkRepository drinkRepo)
//     {
//       _drinkRepo = drinkRepo;
//     }


//     [HttpGet]
//     public IEnumerable<Drink> GetDrinks()
//     {
//       return _drinkRepo.GetAll();
//     }




//     // get api drinks/by id
//     [HttpGet("{id}")]

//     public ActionResult<Drink> GetAction(int id)
//     {
//       Drink result = _drinkRepo.GetDrinkById(id);
//       if (result != null)
//       {
//         return Ok(result);
//       }
//       return NotFound();
//     }


//     // post Api drink
//     [HttpPost]
//     public ActionResult<Drink> Post([FromBody] Drink drink)
//     {
//       return Created("/api/drinks", _drinkRepo.AddDrink(drink));
//     }

//     // put api/drink id

//     [HttpPut("{id}")]
//     public ActionResult<Drink> Put(int id, [FromBody] Drink drink)
//     {
//       Drink result = _drinkRepo.EditDrink(id, drink);
//       if (result != null)
//       {
//         return result;
//       }
//       return NotFound();
//     }


//     //Delete Api/ drink

//     [HttpDelete("{id}")]

//     public ActionResult<Drink> Delete(int id)
//     {
//       if (_drinkRepo.DeleteDrink(id))
//       {
//         return Ok("success");
//       }
//       return NotFound("no drink found");
//     }




//   }
// }