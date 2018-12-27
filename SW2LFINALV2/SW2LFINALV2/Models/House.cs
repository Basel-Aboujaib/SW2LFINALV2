﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SW2LFINALV2.Models
{
    public class House
    {
        [Key]
        public string House_ID { get; set; }
        public string House_Location { get; set; }
        public int House_Price { get; set; }
    }
}