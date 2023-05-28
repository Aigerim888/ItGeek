using ItGeek.DAL.Data;
using ItGeek.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItGeek.DAL.Interfaces;
namespace ItGeek.BLL1.Repositories
{
	public class UserRepository : GenericRepositoryAsync<User>, I
	{
		public UserRepository(AppDbContext db) : base(db)
		{
		}
	}
}
