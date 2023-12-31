﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NimapMachineTerst.Models
{
    public class Product
    {
        [Key] 
        public int ProductId { get; set; }
        [Required] 
        public string ProductName { get; set;}
        public int ProductCategoryId { get; set;}
        [Required]
        public string CategoryName { get; set;}
    }
}