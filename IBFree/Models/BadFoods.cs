﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace IBFree.Models
{
    public class BadFoods
    {
        [Key]
        public String NameId { get; set; }

        public bool Fructan { get; set; }

        public bool Sorbitol { get; set; }

        //private bool sorbitol=true;
        //public bool Sorbitol
        //{
        //    get
        //    {
        //        return sorbitol;
        //    }
        //    set
        //    {
        //        this.Sorbitol = value;
        //    }
        //}

        public bool Mannitol { get; set; }

        public bool Fructose { get; set; }

        public bool GOS { get; set; }

        public bool Lactose { get; set; }

        

    }
}