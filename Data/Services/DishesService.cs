using HRMS.Data;
using HRMS.Data.Base;
using HRMS.Data.ViewModels;
using HRMS.Models;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HRMS.Data.Services
{
    public class DishesService : IOrdersService<Dish>, IDishesService
    {
        private readonly AppDbContext _context;
        public DishesService(AppDbContext context) : base(context)
        {
            _context = context;

        }

        public async Task AddNewDishAsync(NewDishVM data)
        {
            var newDish = new Dish()
            {
                Name = data.Name,
                Description = data.Description,
                Price = data.Price,
                ImageURL = data.ImageURL,
                DishCategory = data.DishCategory,
                Discount = data.Discount
            };
            await _context.Dishes.AddAsync(newDish);
            await _context.SaveChangesAsync();

            //Add Dish Items
            foreach (var actorId in data.ItemIds)
            {
                var newItemDish = new Item_Dish()
                {
                    DishId = newDish.Id,
                    ItemId = actorId
                };
                await _context.Items_Dishes.AddAsync(newItemDish);
            }
            await _context.SaveChangesAsync();
        }

        public async Task<Dish> GetDishByIdAsync(int id)
        {
            var dishDetails = await _context.Dishes
                .Include(am => am.Items_Dishes).ThenInclude(a => a.Item)
                .FirstOrDefaultAsync(n => n.Id == id);
            return dishDetails;

        }

        public async Task<NewDishDropDownsVM> GetNewDishDropDownsValues()
        {
            var response = new NewDishDropDownsVM()
            {
                Items = await _context.Items.OrderBy(n => n.Name).ToListAsync(),

            };

            return response;

        }

        public async Task UpdateDishAsync(NewDishVM data)
        {
            var dbDish = await _context.Dishes.FirstOrDefaultAsync(n => n.Id == data.Id);

            if (dbDish != null)
            {
                dbDish.Name = data.Name;
                dbDish.Description = data.Description;
                dbDish.Price = data.Price;
                dbDish.ImageURL = data.ImageURL;
                dbDish.DishCategory = data.DishCategory;
                dbDish.Discount = data.Discount;
                await _context.SaveChangesAsync();
            }

            //Remove existing items
            var existingItemsDb = _context.Items_Dishes.Where(n => n.DishId == data.Id).ToList();
            _context.Items_Dishes.RemoveRange(existingItemsDb);
            await _context.SaveChangesAsync();

            //Add Dish Items
            foreach (var itemId in data.ItemIds)
            {
                var newItemDish = new Item_Dish()
                {
                    DishId = data.Id,
                    ItemId = itemId
                };
                await _context.Items_Dishes.AddAsync(newItemDish);
            }
            await _context.SaveChangesAsync();

        }
    }
}
