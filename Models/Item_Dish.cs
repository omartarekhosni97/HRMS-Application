namespace HRMS.Models
{
    public class Item_Dish
    {
        

        public int ItemId { get; set; }
        public Item Item { get; set; }
        public int DishId { get; set; }
        public Dish Dish { get; set; }
    }
}
