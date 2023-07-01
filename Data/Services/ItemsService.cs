using HRMS.Data;
using HRMS.Data.Base;
using HRMS.Models;
using Microsoft.EntityFrameworkCore;

namespace HRMS.Data.Services
{
    public class ItemsService : IOrdersService<Item>, IItemsService
    {

        public ItemsService(AppDbContext context) : base(context)
        {

        }

    }
}
