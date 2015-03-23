using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IBFree.Models
{
    public class UserInput
    {
        public String  FoodName { get; set; }

        public Symptoms Symptoms { get; set; }


    }

    public enum Symptoms
    {
        Bloating, Distention, Constipation, Diarrhoea, Flatulence, Other
    }
}