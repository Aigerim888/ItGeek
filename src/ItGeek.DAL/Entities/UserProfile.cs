﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItGeek.DAL.Entities
{
	public class UserProfile
	{
		public int UserId { get; set; }
		public User User { get; set; }
		public string FirstName { get;set; }
		public string LastName { get; set; }
		public DateTime Birtday { get; set; }

	}
}