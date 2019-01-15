using System;
using System.Collections.Generic;
using burgerShack.Db;
using burgerShack.Models;

namespace burgerShack.Repositories
{
  public class BurgerRepository
  {
    //private readonly FakeDb _db;

    public IEnumerable<Burger> Getall()
    {
      return FakeDb.Burgers;
    }


    public Burger GetBurgerById(int id)
    {
      try
      {
        return FakeDb.Burgers[id];
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return null;
      }
    }


    public Burger AddBurger(Burger newBurger)
    {
      FakeDb.Burgers.Add(newBurger);
      return newBurger;
    }


    public Burger EditBurger(int id, Burger newBurger)
    {
      try
      {
        FakeDb.Burgers[id] = newBurger;
        return newBurger;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return null;
      }
    }

    public bool DeleteBurger(int id)
    {
      try
      {
        FakeDb.Burgers.Remove(FakeDb.Burgers[id]);
        return true;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return false;
      }
    }




  }
}