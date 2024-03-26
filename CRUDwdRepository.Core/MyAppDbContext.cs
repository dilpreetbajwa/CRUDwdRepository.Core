using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CRUDwdRepository.Core
{
	public class MyAppDbContext : DbContext
    {

        public MyAppDbContext(DbContextOptions<MyAppDbContext> options)
            : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

		
	}
}

