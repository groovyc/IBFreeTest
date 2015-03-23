using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using IBFree.Controllers; //added

namespace IBFree.Models
{
    public class IBFreeContext : DbContext
    {
        public DbSet<BadFoods> BoldFoods { get; set; }

    }
}