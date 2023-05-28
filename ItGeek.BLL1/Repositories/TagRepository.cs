﻿using ItGeek.DAL.Data;
using ItGeek.DAL.Entities;
using ItGeek.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItGeek.BLL1.Repositories
{
	public class TagRepository : GenericRepositoryAsync<Tag>, ITagRepository
	{
		public TagRepository(AppDbContext db) : base(db)
		{
		}
	}
}