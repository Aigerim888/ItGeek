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
	public class PostRepository : GenericRepositoryAsync<Post>, IPostRepository
	{
        private readonly AppDbContext _db;

        public PostRepository(AppDbContext db) : base(db)
		{
            _db = db;
        }
        public async Task<Post> GetBySlugAsync(string slug)
        {
            return await _db.Posts.Where(x => x.Slug == slug).FirstAsync();
        }
        public async Task<List<Post>> ListByCategoryIdAsync(int categoryId)
        {
            Category cat =await _db.Categories.FindAsync(categoryId);

            List<PostCategory> postCategory=await _db.PostCategories.Where(x => x.CategoryId == cat.Id).ToListAsync();
           
            List<Post> post = new List<Post>();

            foreach (var pc in postCategory)
            {
                Post post1=await _db.Posts.Where(x=>x.Id==pc.PostId).FirstAsync();
                post.Add(post1);
            }

            return post;

		}
    }
}
