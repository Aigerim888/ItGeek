using ItGeek.BLL1;
using ItGeek.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ItGeek.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthorSocialsController : Controller
    {
        private readonly UnitOfWork _uow;

        public AuthorSocialsController(UnitOfWork uow)
        {
            _uow = uow;
        }
        public async Task<IActionResult> Index()
        {

            return View(await _uow.AuthorSocialRepository.ListAllAsync());
        }
        public async Task<IActionResult> Details(int id)
        {

            return View(await _uow.AuthorSocialRepository.GetByIdAsync(id));
        }
        public async Task<IActionResult> Delete(int id)
        {
            AuthorSocial authorsocial = await _uow.AuthorSocialRepository.GetByIdAsync(id);

            if (authorsocial != null)
            {
                await _uow.AuthorSocialRepository.DeleteAsync(authorsocial);
            }
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task <IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(AuthorSocial authorsocial)
        {
            if(ModelState.IsValid) 
            {
                await _uow.AuthorSocialRepository.InsertAsync(authorsocial);
                return RedirectToAction(nameof(Index));    
            }
            return View(authorsocial);
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            AuthorSocial authorsocial = await _uow.AuthorSocialRepository.GetByIdAsync(id);
            if (authorsocial != null)
            {
                return NotFound();
            }
            return View(authorsocial);
        }
        [HttpPost]
        public async Task<IActionResult> Update(AuthorSocial authorsocial)
        {
            if(ModelState.IsValid)
            {
                await _uow.AuthorSocialRepository.UpdateAsync(authorsocial);
                return RedirectToAction(nameof(Index));
            }
            return View(authorsocial);
        }
    }
}
