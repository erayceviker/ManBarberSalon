using System.ComponentModel.DataAnnotations;

namespace WebUI.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Lütfen e-posta adresini boş geçmeyiniz.")]
        [EmailAddress(ErrorMessage = "Lütfen uygun formatta e-posta adresi giriniz.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi boş geçmeyiniz.")]
        [DataType(DataType.Password, ErrorMessage = "Lütfen şifreyi tüm kuralları göz önüne alarak giriniz...")]
        public string Password { get; set; }

        public bool Lock { get; set; }
    }
}
