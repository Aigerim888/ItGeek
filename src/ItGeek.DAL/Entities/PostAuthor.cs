using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItGeek.DAL.Entities
{
	public class PostAuthor
	{
		public int PostId { get; set; }
		public int AuthorId { get; set;}
		public Post Post { get; set; }= null!;
		public Author Author { get; set; }	= null!;
	}
}
