using System.ComponentModel.DataAnnotations;

namespace HRMS.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int Id { get; set; }

        public Dish Dish { get; set; }
        public int Amount { get; set; }


        public string ShoppingCartId { get; set; }
    }
}
