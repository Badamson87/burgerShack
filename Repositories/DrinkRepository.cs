using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using burgerShack.Models;

namespace burgerShack.Repositories
{
  public class DrinkRepository
  {
    public readonly IDbConnection _db;


    public DrinkRepository(IDbConnection db)
    {
      _db = db;
    }

    public IEnumerable<Drink> GetAll()
    {
      return _db.Query<Drink>("SELECT * FROM drink");
    }

    public Drink GetDrinkById(int id)
    {
      return _db.QueryFirstOrDefault<Drink>($"SELECT * FROM drink WHERE id = @id", new { id });
    }

    public Drink AddDrink(Drink newDrink)
    {
      int id = _db.ExecuteScalar<int>(@"
      INSERT INTO drink(name, description, price) Values (@Name, @ Description, @Price);
        SELECT LAST_INSERT_ID()", newDrink);
      if (id == 0) return null;
      newDrink.Id = id;
      return newDrink;
    }


    public Drink EditDrink(int id, Drink newDrink)
    {
      newDrink.Id = id;
      try
      {
        return _db.QueryFirstOrDefault<Drink>($@"
        UPDATE Drink SET
        Name = @Name,
        Description = @Description,
        Price = @Price
        WHERE Id = @Id;
        SELECT * FROM Drink where id = @Id;
        ", newDrink);
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return null;
      }
    }

    public bool DeleteDrink(int id)
    {
      _db.Execute("Delete FROM Drink WHERE ID = @Id", new { ID = id });
      return true;
    }



















  }
}