using HRMS.Data.Base;
using HRMS.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMS.Models
{
    public class Dish : IEntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string? ImageURL { get; set; }
        public int SaleCount { get; set; }
        public double Discount { get; set; }
        public double Rating { get; set; }


        public DishCategory DishCategory { get; set; }

        // relationships
        public List<Item_Dish>? Items_Dishes { get; set; }



    }
}
