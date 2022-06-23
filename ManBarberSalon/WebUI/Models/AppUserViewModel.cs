using System.ComponentModel.DataAnnotations;

namespace WebUI.Models
{
    public class AppUserViewModel
    {
        public string userName { get; set; }
        [Required(ErrorMessage = "Lütfen adı boş geçmeyiniz...")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Lütfen soyadı boş geçmeyiniz...")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Lütfen emaili boş geçmeyiniz...")]
        [EmailAddress(ErrorMessage = "Lütfen email formatında bir değer belirtiniz...")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi boş geçmeyiniz...")]
        [DataType(DataType.Password, ErrorMessage = "Lütfen şifreyi tüm kuralları göz önüne alarak giriniz...")]
        [Display(Name = "Şifre")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen telefon numarasını boş geçmeyiniz...")]
        [StringLength(11, ErrorMessage = "Lütfen telefon numarınızı 11 haneli giriniz...", MinimumLength = 11)]
        public string PhoneNumber { get; set; }
    }
}
