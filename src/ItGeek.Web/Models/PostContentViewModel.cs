using ItGeek.DAL.Entities;

namespace ItGeek.Web.Models
{
    public class PostContentViewModel
    {
        public Post post { get; set; }  
        public PostContent postContent { get; set; }
        public Category category { get; set; }
    }
}
