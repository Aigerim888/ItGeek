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
	public class PostContentRepository : GenericRepositoryAsync<PostContent>, IPostContentRepository
	{
        private readonly AppDbContext _db;

        public PostContentRepository(AppDbContext db) : base(db)
		{
            _db = db;
        }
        public async Task<PostContent> GetByPostIdAsync(int postId)
		{
			return await _db.PostContents.Where(x=>x.PostId==postId).FirstAsync();
		}
    }
}
