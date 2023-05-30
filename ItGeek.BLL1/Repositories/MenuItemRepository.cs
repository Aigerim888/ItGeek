using ItGeek.DAL.Data;
using ItGeek.DAL.Entities;
using ItGeek.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItGeek.BLL1.Repositories
{
    public class MenuItemRepository : GenericRepositoryAsync<MenuItem>, IMenuItemRepository
    {
        public MenuItemRepository(AppDbContext db) : base(db)
        {
        }
    }
}
