﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class SalesCreateData
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date")]
        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Client { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public double SalesPrice { get; set; }

        [Required]
        public double Commission { get; set; }

        [Required]
        public string Source { get; set; }
    }
}