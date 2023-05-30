using ItGeek.BLL1;
using ItGeek.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ItGeek.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserProfilesController : Controller
    {
        private readonly UnitOfWork _uow;

        public UserProfilesController(UnitOfWork uow)
        {
            _uow = uow;
        }
        public async Task<IActionResult> Index()
        {

            return View(await _uow.UserProfileRepository.ListAllAsync());
        }
        public async Task<IActionResult> Details(int id)
        {

            return View(await _uow.UserProfileRepository.GetByIdAsync(id));
        }
        public async Task<IActionResult> Delete(int id)
        {
            UserProfile userprofile = await _uow.UserProfileRepository.GetByIdAsync(id);

            if (userprofile != null)
            {
                await _uow.UserProfileRepository.DeleteAsync(userprofile);
            }
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task <IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(UserProfile userprofile)
        {
            if(ModelState.IsValid) 
            {
                await _uow.UserProfileRepository.InsertAsync(userprofile);
                return RedirectToAction(nameof(Index));    
            }
            return View(userprofile);
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            UserProfile userprofile = await _uow.UserProfileRepository.GetByIdAsync(id);
            if (userprofile != null)
            {
                return NotFound();
            }
            return View(userprofile);
        }
        [HttpPost]
        public async Task<IActionResult> Update(UserProfile userprofile)
        {
            if(ModelState.IsValid)
            {
                await _uow.UserProfileRepository.UpdateAsync(userprofile);
                return RedirectToAction(nameof(Index));
            }
            return View(userprofile);
        }
    }
}
