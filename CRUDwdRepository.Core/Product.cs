﻿using System;
using System.ComponentModel.DataAnnotations;

namespace CRUDwdRepository.Core
{
	public class Product
	{
		public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string ProductName { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Qty { get; set; }
    }
}

