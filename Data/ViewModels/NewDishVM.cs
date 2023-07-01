using HRMS.Data.Enums;
using HRMS.Data.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMS.Data.ViewModels
{
    public class NewDishVM
    {
        public int Id { get; set; }

        [Display(Name = "Dish name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Display(Name = "Dish description")]
        public string Description { get; set; }

        [Display(Name = "Price in $")]
        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }

        [Display(Name = "Dish poster URL")]
        public string? ImageURL { get; set; }

        [Display(Name = "Dish Discount")]
        public double Discount { get; set; }


        [Display(Name = "Select a category")]
        [Required(ErrorMessage = "Dish category is required")]
        public DishCategory DishCategory { get; set; }

        //Relationships
        [Display(Name = "Select item(s)")]
        [Required(ErrorMessage = "Dish item(s) is required")]
        public List<int> ItemIds { get; set; }


    }
}
