using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;  //added
using IBFree.Controllers; //added

namespace IBFree.Models
{
    public class BadFoodInitializer : DropCreateDatabaseIfModelChanges<IBFreeContext>
    {
        protected override void Seed(IBFreeContext context)
        {

            List<BadFoods> listfoods = new List<BadFoods>
        {
            new BadFoods{NameId = "Apple", Fructan = true, Sorbitol = true, Mannitol = false, Fructose= true, GOS =false, Lactose = false},
            
            new BadFoods{NameId = "Apricot", Fructan = true, Sorbitol = true, Mannitol = false, Fructose= true, GOS =false, Lactose = false},
            
            new BadFoods{NameId = "Blackberry", Fructan = true, Sorbitol = true, Mannitol = false, Fructose= true, GOS =false, Lactose = false},
            
            new BadFoods{NameId = "Boysonberry", Fructan = true, Sorbitol = true, Mannitol = false, Fructose= true, GOS =false, Lactose = false},
            new BadFoods{NameId = "Coconut", Fructan = true, Sorbitol = true, Mannitol = false, Fructose= true, GOS =false, Lactose = false},
            new BadFoods{NameId = "Cherry", Fructan = true, Sorbitol = true, Mannitol = false, Fructose= true, GOS =false, Lactose = false},
    
          
        };

            foreach (var item in listfoods)
            {
                context.BoldFoods.Add(item);
            }

            context.SaveChanges();
        }

      
    }
}