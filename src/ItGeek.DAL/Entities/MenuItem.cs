﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItGeek.DAL.Entities
{
	public class MenuItem:BaseEntity
	{
		public int MenuId { get; set; }
		public virtual Menu? Menu { get; set; }	
		public string Name { get; set; }
		public string Slug { get; set; }
		public int Position { get; set; } = 0;

	}
}
