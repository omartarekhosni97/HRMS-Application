using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMS.Models
{
    public class Room
    {
        [Key]
        [Display(Name = "Room no.")]
        [Required(ErrorMessage = "Room no. is required")]
        public int ID { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public double TotalCheck { get; set; }
        public string UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public ApplicationUser? User { get; set; }

    }
}
