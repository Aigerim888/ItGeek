﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItGeek.DAL.Entities
{
	
	public class PostCategory:BaseEntity
	{
		public int PostId { get; set; }
		public int CategoryId { get; set; }
		public Post Post { get; set; }=null!;
		public Category Category { get; set; }= null!;
	}
}
