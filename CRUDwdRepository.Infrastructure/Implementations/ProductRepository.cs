using System;
using System.Collections.Generic;
using CRUDwdRepository.Core;
using CRUDwdRepository.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CRUDwdRepository.Infrastructure.Implementations
{
    public class ProductRepository : IProductRepository
    {

        private readonly MyAppDbContext _context;

        public ProductRepository(MyAppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            var products = await _context.Products.ToListAsync();
            return products;
        }

        public async Task<Product> GetById(int id)
        {
            return await _context.Products.FindAsync(id);
            
        }

        public int GetV()
        {
            return _context.SaveChanges();
        }

        public  async Task Add(Product model)
        {
           await _context.Products.AddAsync(model);
           await Save();
        }

        public async Task Delete(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if(product != null)
            {
                _context.Products.Remove(product);
                await Save();
            }
        }

        public async Task Update(Product model)
        {
            var products = await _context.Products.FindAsync(model.Id);
            if(products != null)
            {
                products.ProductName = model.ProductName;
                products.Price = model.Price;
                products.Qty = model.Qty;
                _context.Update(products);
                await Save();
            }
        }
        private async Task Save()
        {
           await _context.SaveChangesAsync();
        }
    }
}

