using ItGeek.DAL.Data;
using ItGeek.DAL.Entities;
using ItGeek.DAL.Enum;
using ItGeek.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItGeek.BLL1.Repositories
{
	public class RoleRepository : GenericRepositoryAsync<Role>, IRoleRepository
	{
        private readonly AppDbContext _db;

        public RoleRepository(AppDbContext db) : base(db)
		{
            _db = db;
        }

        public  async Task<int> GetBasicAsync()
        {
            return await _db.Roles.Where(x=>x.RoleName==RoleName.Basic).Select(x=>x.Id).FirstAsync();
        }
    }
}
