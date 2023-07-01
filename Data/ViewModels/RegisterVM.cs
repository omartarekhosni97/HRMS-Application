using System.ComponentModel.DataAnnotations;

namespace HRMS.Data.ViewModels
{
    public class RegisterVM
    {
        public RegisterVM()
        {
        }

        public RegisterVM(string fullName, string emailAddress, string password, string confirmPassword)
        {
            FullName = fullName ?? throw new ArgumentNullException(nameof(fullName));
            EmailAddress = emailAddress ?? throw new ArgumentNullException(nameof(emailAddress));
            Password = password ?? throw new ArgumentNullException(nameof(password));
            ConfirmPassword = confirmPassword ?? throw new ArgumentNullException(nameof(confirmPassword));
        }

        [Display(Name = "Full name")]
        [Required(ErrorMessage = "Full name is required")]
        public string FullName { get; set; }

        [Display(Name = "Email address")]
        [Required(ErrorMessage = "Email address is required")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirm password")]
        [Required(ErrorMessage = "Confirm password is required")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }
    }
}
