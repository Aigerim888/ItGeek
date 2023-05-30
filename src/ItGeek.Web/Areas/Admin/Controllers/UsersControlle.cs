using ItGeek.BLL1;
using ItGeek.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ItGeek.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsersController : Controller
    {
        private readonly UnitOfWork _uow;

        public UsersController(UnitOfWork uow)
        {
            _uow = uow;
        }
        public async Task<IActionResult> Index()
        {

            return View(await _uow.UserRepository.ListAllAsync());
        }
        public async Task<IActionResult> Details(int id)
        {

            return View(await _uow.UserRepository.GetByIdAsync(id));
        }
        public async Task<IActionResult> Delete(int id)
        {
            User user= await _uow.UserRepository.GetByIdAsync(id);

            if (user != null)
            {
                await _uow.UserRepository.DeleteAsync(user);
            }
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task <IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            if(ModelState.IsValid) 
            {
                await _uow.UserRepository.InsertAsync(user);
                return RedirectToAction(nameof(Index));    
            }
            return View(user);
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            User user = await _uow.UserRepository.GetByIdAsync(id);
            if (user != null)
            {
                return NotFound();
            }
            return View(user);
        }
        [HttpPost]
        public async Task<IActionResult> Update(User user)
        {
            if(ModelState.IsValid)
            {
                await _uow.UserRepository.UpdateAsync(user);
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }
    }
}
