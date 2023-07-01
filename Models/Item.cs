using HRMS.Data.Base;
using HRMS.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMS.Models
{
    public class Item : IEntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Item name is required")]
        public string Name { get; set; }


        [Display(Name = "Available")]
        public ItemAvailable ItemAvailable { get; set; }

        // relationships
        public List<Item_Dish>? Items_Dishes { get; set; }


    }
}
