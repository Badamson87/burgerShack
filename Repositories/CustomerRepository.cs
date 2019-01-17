using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using burgerShack.Models;

namespace burgerShack.Repositories
{
  public class CustomerRepository
  {
    //private readonly FakeDb _db;

    public readonly IDbConnection _db;
    public CustomerRepository(IDbConnection db)
    {
      _db = db;
    }

    public IEnumerable<Customer> Getall()
    {
      return _db.Query<Customer>("SELECT * FROM customer");
    }


    public Customer GetCustomerById(int id)
    {
      return _db.QueryFirstOrDefault<Customer>($"SELECT * FROM customer WHERE id = @id", new { id });
    }


    public Customer AddCustomer(Customer customer)
    {
      int id = _db.ExecuteScalar<int>(@"
      INSERT INTO customer(name) Values (@Name);
        SELECT LAST_INSERT_ID()", customer);
      if (id == 0) return null;
      customer.Id = id;
      return customer;
    }



    public bool DeleteCustomer(int id)
    {
      _db.Execute("Delete FROM Customer WHERE ID = @Id", new { ID = id });
      return true;
    }




  }
}