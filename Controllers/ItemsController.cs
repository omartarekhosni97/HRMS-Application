using HRMS.Data.Services;
using HRMS.Data.Static;
using HRMS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HRMS.Data;

namespace HRMS.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    [Authorize(Roles = UserRoles.Staff)]
    public class ItemsController : Controller
    {

        public IItemsService _service;

        public ItemsController(IItemsService service)
        {
            _service = service;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var allItems = await _service.GetAllAsync();
            return View(allItems);
        }

        //GET: Actors/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,Available")] Item item)
        {
            if (!ModelState.IsValid)
            {
                return View(item);
            }
            await _service.AddAsync(item);
            return RedirectToAction(nameof(Index));
        }

        //GET: Actors/Details/1
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var itemDetails = await _service.GetByIdAsync(id);
            if (itemDetails == null)
            {
                return View("NotFound");
            }
            return View(itemDetails);
        }


        //GET: Actors/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var itemDetails = await _service.GetByIdAsync(id);
            if (itemDetails == null)
            {
                return View("NotFound");
            }
            return View(itemDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Item item)
        {
            if (id != item.Id) return View("NotFound");
            if (!ModelState.IsValid)
            {
                return View(item);
            }
            await _service.UpdateAsync(id, item);
            return RedirectToAction(nameof(Index));
        }

        //GET: Actors/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var itemDetails = await _service.GetByIdAsync(id);
            if (itemDetails == null)
            {
                return View("NotFound");
            }
            return View(itemDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var itemDetails = await _service.GetByIdAsync(id);
            if (itemDetails == null)
            {
                return View("NotFound");
            }
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
