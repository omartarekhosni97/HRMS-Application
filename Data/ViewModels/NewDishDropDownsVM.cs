using HRMS.Models;

namespace HRMS.Data.ViewModels
{
    public class NewDishDropDownsVM
    {
        public NewDishDropDownsVM()
        {

            Items = new List<Item>();
        }

        public List<Item> Items { get; set; }
    }


}
