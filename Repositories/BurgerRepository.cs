using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using burgerShack.Models;

namespace burgerShack.Repositories
{
  public class BurgerRepository
  {
    //private readonly FakeDb _db;

    public readonly IDbConnection _db;
    public BurgerRepository(IDbConnection db)
    {
      _db = db;
    }

    public IEnumerable<Burger> Getall()
    {
      return _db.Query<Burger>("select * FROM burger");
    }


    public Burger GetBurgerById(int id)
    {
      return _db.QueryFirstOrDefault<Burger>($"SELECT * FROM burger WHERE id = @id", new { id });
    }


    public Burger AddBurger(Burger burger)
    {
      int id = _db.ExecuteScalar<int>(@"
      INSERT INTO burger(name, description, price) Values (@Name, @Description, @Price);
        SELECT LAST_INSERT_ID()", burger);
      if (id == 0) return null;
      burger.Id = id;
      return burger;
    }


    public Burger EditBurger(int id, Burger newBurger)
    {
      newBurger.Id = id;
      try
      {
        return _db.QueryFirstOrDefault<Burger>($@"
        UPDATE Burger SET
        Name = @Name,
        Description = @Description,
        Price = @Price
        WHERE Id = @Id;
        SELECT * FROM Burger WHERE id = @Id;
        ", newBurger);
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return null;
      }
    }

    public bool DeleteBurger(int id)
    {
      _db.Execute("Delete FROM Burger WHERE ID = @Id", new { ID = id });
      return true;
    }




  }
}