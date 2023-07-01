using HRMS.Data.Services;
using HRMS.Data.Static;
using HRMS.Data.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HRMS.Data;

namespace HRMS.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class DishesController : Controller
    {
        public IDishesService _service;

        public DishesController(IDishesService service)
        {
            _service = service;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var allDishes = await _service.GetAllAsync();
            return View(allDishes);
        }
        [AllowAnonymous]
        public async Task<IActionResult> Filter(string searchString)
        {
            var allDishes = await _service.GetAllAsync();

            if (!string.IsNullOrEmpty(searchString))
            {
                var filteredResult = allDishes.Where(n => n.Name.ToLower().Contains(searchString.ToLower()) || n.Description.ToLower().Contains(searchString.ToLower())).ToList();

                //var filteredResultNew = allMovies.Where(n => string.Equals(n.Name, searchString, StringComparison.CurrentCultureIgnoreCase) || string.Equals(n.Description, searchString, StringComparison.CurrentCultureIgnoreCase)).ToList();

                return View("Index", filteredResult);
            }

            return View("Index", allDishes);
        }
        //GET: Dishes/Details/1
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var dishDetails = await _service.GetDishByIdAsync(id);
            if (dishDetails == null)
            {
                return View("NotFound");
            }
            return View(dishDetails);
        }
        //GET: Dishes/Create
        public async Task<IActionResult> Create()
        {
            var dishDropDownsData = await _service.GetNewDishDropDownsValues();
            ViewBag.Items = new SelectList(dishDropDownsData.Items, "Id", "Name");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewDishVM dish)
        {
            if (!ModelState.IsValid)
            {
                var dishDropDownsData = await _service.GetNewDishDropDownsValues();
                ViewBag.Actors = new SelectList(dishDropDownsData.Items, "Id", "Name");
                return View(dish);
            }
            await _service.AddNewDishAsync(dish);
            return RedirectToAction(nameof(Index));
        }

        //GET: Dishes/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var dishDetails = await _service.GetDishByIdAsync(id);
            if (dishDetails == null) return View("NotFound");

            var response = new NewDishVM()
            {
                Id = dishDetails.Id,
                Name = dishDetails.Name,
                Description = dishDetails.Description,
                Price = dishDetails.Price,
                ImageURL = dishDetails.ImageURL,
                DishCategory = dishDetails.DishCategory,
                ItemIds = dishDetails.Items_Dishes.Select(n => n.ItemId).ToList(),
            };

            var dishDropdownsData = await _service.GetNewDishDropDownsValues();

            ViewBag.Items = new SelectList(dishDropdownsData.Items, "Id", "Name");

            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, NewDishVM dish)
        {
            if (id != dish.Id) return View("NotFound");

            if (!ModelState.IsValid)
            {
                var dishDropdownsData = await _service.GetNewDishDropDownsValues();


                ViewBag.Items = new SelectList(dishDropdownsData.Items, "Id", "Name");

                return View(dish);
            }

            await _service.UpdateDishAsync(dish);
            return RedirectToAction(nameof(Index));
        }
    }
}
