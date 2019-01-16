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
//   [Route("api/[controller]")]
//   [ApiController]

//   public class SidesController : ControllerBase
//   {

//     private readonly SideRepository _SideRepo;

//     public IEnumerable<Side> Sides { get; private set; }


//     public SidesController(SideRepository sideRepo)
//     {
//       _SideRepo = sideRepo;
//     }

//     // Get Api/side

//     [HttpGet]
//     public IEnumerable<Side> Get()
//     {
//       return _SideRepo.GetAll();
//     }


//     // Get Api Side/id

//     [HttpGet("{id}")]
//     public ActionResult<Side> GetAction(int id)
//     {
//       Side result = _SideRepo.GetSideById(id);
//       if (result != null)
//       {
//         return Ok(result);
//       }
//       return NotFound();
//     }


//     // post Api/sides

//     [HttpPost]
//     public ActionResult<Side> Post([FromBody] Side side)
//     {
//       return Created("api/sides/", _SideRepo.AddSide(side));
//     }


//     // put Api/sides/id

//     [HttpPut("{id}")]

//     public ActionResult<Side> Put(int id, [FromBody] Side side)
//     {
//       Side result = _SideRepo.EditSide(id, side);
//       if (result != null)
//       {
//         return result;
//       }
//       return NotFound();
//     }


//     //  Delete Api/side

//     [HttpDelete("{id")]

//     public ActionResult<Side> Delete(int id)
//     {
//       if (_SideRepo.DeleteSide(id))
//       {
//         return Ok("Success");
//       }
//       return NotFound("no side to delete");
//     }













//   }
// }