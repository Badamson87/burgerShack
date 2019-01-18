using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using burgerShack.Models;

namespace burgerShack.Repositories
{
  public class CustomerFavoriteRepository
  {

    public readonly IDbConnection _db;
    public CustomerFavoriteRepository(IDbConnection db)
    {
      _db = db;
    }

    //get favorite by customer id

    public IEnumerable<Burger> GetBurgerByCustomerId(int id)
    {
      return _db.Query<Burger>($@"
      SELECT * FROM customerFavorite cf
      INNER JOIN burger b on b.id = cf.burgerId
      WHERE (burgerId = @id)", new { id }
      );
    }


    // add fav burger

    public CustomerFavorite AddCustomerFavorite(CustomerFavorite cf)
    {
      int id = _db.ExecuteScalar<int>(@"
        INSERT INTO CustomerFavorite(burgerId, customerId)
        Values(@BurgerId, @CustomerId);
        SELECT LAST_INSER_ID();
        ", cf);
      cf.Id = id;
      return cf;
    }



    public bool DeleteCustomerFavorite(CustomerFavorite cf)
    {
      int success = _db.Execute(@"DELETE FROM CustomerFavorite WHERE burgerId = @BurgerId AND customerId = @CustomerId", cf);
      return success != 0;
    }





  }
}