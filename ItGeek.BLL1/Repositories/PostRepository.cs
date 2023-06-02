using ItGeek.DAL.Data;
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
    }
}
