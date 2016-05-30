﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Webbshop.Data;
using Webbshop.Models;

namespace Webbshop.Services
{
    public class StoreService
    {
        private readonly StoreContext _db;

        public StoreService() : this(new StoreContext()) { } //Nollargumentskonstruktor
        
        public StoreService(StoreContext context) //konstruktor med egen context(db)
        {
            _db = context;
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await _db.Categories.OrderBy(c => c.Name).ToArrayAsync();
        }

        public async Task<IEnumerable<Product>> GetProductsForAsync(string category)
        {
            return await _db.Products.Include("Category")
                .Where(p => p.Category.Name == category).ToArrayAsync();

        }

        public async Task<Product> GetProductByIDAsync(int id)
        {
            return await _db.Products.Include("Category")
                .Where(p => p.ProductId == id).SingleOrDefaultAsync();
        } 

    }
}