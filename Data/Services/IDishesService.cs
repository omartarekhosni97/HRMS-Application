using HRMS.Data.Base;
using HRMS.Data.ViewModels;
using HRMS.Models;

namespace HRMS.Data.Services
{
    public interface IDishesService : IEntityBaseRepository<Dish>
    {
        Task<Dish> GetDishByIdAsync(int id);

        Task<NewDishDropDownsVM> GetNewDishDropDownsValues();

        Task AddNewDishAsync(NewDishVM data);
        Task UpdateDishAsync(NewDishVM data);

    }
}
