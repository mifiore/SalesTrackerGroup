﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class SalesDetailModel
    {
        public int SalesId { get; set; }

        public DateTime Date { get; set; }

        public string Client { get; set; }

        public string Address { get; set; }

        public float SalesPrice { get; set; }

        public float Commission { get; set; }

        public string Source { get; set; }
    }
}