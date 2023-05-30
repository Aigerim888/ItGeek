using ItGeek.BLL1;
using ItGeek.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ItGeek.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MenuItemsController : Controller
    {
        private readonly UnitOfWork _uow;

        public MenuItemsController(UnitOfWork uow)
        {
            _uow = uow;
        }
        public async Task<IActionResult> Index()
        {

            return View(await _uow.MenuItemRepository.ListAllAsync());
        }
        public async Task<IActionResult> Details(int id)
        {

            return View(await _uow.MenuItemRepository.GetByIdAsync(id));
        }
        public async Task<IActionResult> Delete(int id)
        {
            MenuItem menuitem = await _uow.MenuItemRepository.GetByIdAsync(id);

            if (menuitem != null)
            {
                await _uow.MenuItemRepository.DeleteAsync(menuitem);
            }
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task <IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(MenuItem menuitem)
        {
            if(ModelState.IsValid) 
            {
                await _uow.MenuItemRepository.InsertAsync(menuitem);
                return RedirectToAction(nameof(Index));    
            }
            return View(menuitem);
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            MenuItem menuitem = await _uow.MenuItemRepository.GetByIdAsync(id);
            if (menuitem != null)
            {
                return NotFound();
            }
            return View(menuitem);
        }
        [HttpPost]
        public async Task<IActionResult> Update(MenuItem menuitem)
        {
            if(ModelState.IsValid)
            {
                await _uow.MenuItemRepository.UpdateAsync(menuitem);
                return RedirectToAction(nameof(Index));
            }
            return View(menuitem);
        }
    }
}
