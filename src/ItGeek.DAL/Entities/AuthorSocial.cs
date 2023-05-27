using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItGeek.DAL.Entities
{
	public class AuthorSocial:BaseEntity
	{
		public int AuthorId { get; set; }
		public Author Author { get; set; }
		public Enum SocialName { get; set; }	
		public string SocailLink { get; set; }
	}
}
