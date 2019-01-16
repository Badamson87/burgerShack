// using System;
// using System.Collections.Generic;
// using burgerShack.Db;
// using burgerShack.Models;

// namespace burgerShack.Repositories
// {
//   public class SideRepository
//   {

//     public IEnumerable<Side> GetAll()
//     {
//       return FakeDb.Sides;
//     }

//     public Side GetSideById(int id)
//     {
//       try
//       {
//         return FakeDb.Sides[id];
//       }
//       catch (Exception ex)
//       {
//         Console.WriteLine(ex);
//         return null;
//       }
//     }


//     public Side AddSide(Side newSide)
//     {
//       FakeDb.Sides.Add(newSide);
//       return newSide;
//     }


//     public Side EditSide(int id, Side newSide)
//     {
//       try
//       {
//         FakeDb.Sides[id] = newSide;
//         return newSide;
//       }
//       catch (Exception ex)
//       {
//         Console.WriteLine(ex);
//         return null;
//       }
//     }

//     public bool DeleteSide(int id)
//     {
//       try
//       {
//         FakeDb.Sides.Remove(FakeDb.Sides[id]);
//         return true;
//       }
//       catch (Exception ex)
//       {
//         Console.WriteLine(ex);
//         return false;
//       }
//     }









//   }
// }