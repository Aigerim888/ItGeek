﻿using ItGeek.DAL.Data;
using ItGeek.DAL.Entities;
using ItGeek.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItGeek.BLL1.Repositories
{
	public class CategoryRepository : GenericRepositoryAsync<Category>, ICategoryRepository
	{
        private readonly AppDbContext _db;

        public CategoryRepository(AppDbContext db) : base(db)
		{
            _db = db;
        }
        public async Task<Category> GetBySlugAsync(string slug)
        {
            return await _db.Categories.Where(x => x.Slug == slug).FirstAsync();
        }
    }
}
