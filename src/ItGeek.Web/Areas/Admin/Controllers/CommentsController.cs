using ItGeek.BLL1;
using ItGeek.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ItGeek.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentsController : Controller
    {
        private readonly UnitOfWork _uow;

        public CommentsController(UnitOfWork uow)
        {
            _uow = uow;
        }
        public async Task<IActionResult> Index()
        {

            return View(await _uow.CommentRepository.ListAllAsync());
        }
        public async Task<IActionResult> Details(int id)
        {

            return View(await _uow.CommentRepository.GetByIdAsync(id));
        }
        public async Task<IActionResult> Delete(int id)
        {
            Comment comment = await _uow.CommentRepository.GetByIdAsync(id);

            if (comment != null)
            {
                await _uow.CommentRepository.DeleteAsync(comment);
            }
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task <IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Comment comment)
        {
            if(ModelState.IsValid) 
            {
                await _uow.CommentRepository.InsertAsync(comment);
                return RedirectToAction(nameof(Index));    
            }
            return View(comment);
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            Comment comment = await _uow.CommentRepository.GetByIdAsync(id);
            if (comment != null)
            {
                return NotFound();
            }
            return View(comment);
        }
        [HttpPost]
        public async Task<IActionResult> Update(Comment comment)
        {
            if(ModelState.IsValid)
            {
                await _uow.CommentRepository.UpdateAsync(comment);
                return RedirectToAction(nameof(Index));
            }
            return View(comment);
        }
    }
}
