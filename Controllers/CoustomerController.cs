using System;
using System.Collections.Generic;
using System.Linq;
using burgerShack.Models;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using burgerShack.Repositories;

namespace burgerShack.Controllersustomer
{
  [Route("api/[controller]")]
  [ApiController]

  public class CustomerController : ControllerBase
  {
    private readonly CustomerRepository _customerRepo;

    public IEnumerable<Customer> Customers { get; private set; }


    public CustomerController(CustomerRepository customerRepo)
    {
      _customerRepo = customerRepo;
    }

    [HttpGet]

    public IEnumerable<Customer> Get()
    {
      return _customerRepo.Getall();
    }


    [HttpGet("{id}")]

    public ActionResult<Customer> GetAction(int id)
    {
      Customer result = _customerRepo.GetCustomerById(id);
      if (result != null)
      {
        return Ok(result);
      }
      return NotFound();
    }

    [HttpPost]

    public ActionResult<Customer> Post([FromBody] Customer customer)
    {
      return Created("/api/customers", _customerRepo.AddCustomer(customer));
    }


    [HttpDelete("{id}")]

    public ActionResult<Customer> Delete(int id)
    {
      if (_customerRepo.DeleteCustomer(id))
      {
        return Ok("success");
      }
      return NotFound("No Customer found");
    }







  }
}