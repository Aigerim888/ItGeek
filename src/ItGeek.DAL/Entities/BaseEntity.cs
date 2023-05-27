using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItGeek.DAL.Entities
{
	public class BaseEntity
	{
		[Key]
		public int Id { get; set; }
	}
}
