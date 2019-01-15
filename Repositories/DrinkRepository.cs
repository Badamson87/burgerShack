using System;
using System.Collections.Generic;
using burgerShack.Db;
using burgerShack.Models;

namespace burgerShack.Repositories
{
  public class DrinkRepository
  {

    public IEnumerable<Drink> GetAll()
    {
      return FakeDb.Drinks;
    }

    public Drink GetDrinkById(int id)
    {
      try
      {
        return FakeDb.Drinks[id];
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return null;
      }
    }

    public Drink AddDrink(Drink newDrink)
    {
      FakeDb.Drinks.Add(newDrink);
      return newDrink;
    }


    public Drink EditDrink(int id, Drink newDrink)
    {
      try
      {
        FakeDb.Drinks[id] = newDrink;
        return newDrink;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return null;
      }
    }

    public bool DeleteDrink(int id)
    {
      try
      {
        FakeDb.Drinks.Remove(FakeDb.Drinks[id]);
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