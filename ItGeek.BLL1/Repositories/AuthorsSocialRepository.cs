using ItGeek.DAL.Data;
using ItGeek.DAL.Entities;
using ItGeek.DAL.Interfaces;

namespace ItGeek.BLL.Repositories;

public class AuthorsSocialRepository : GenericRepositoryAsync<AuthorSocial>, IAuthorSocialRepository
{
	public AuthorsSocialRepository(AppDbContext db) : base(db)
	{
	}
}
