using Microsoft.AspNetCore.Identity;

namespace WebUI.ValidationRules.CustomValidations
{
    public class CustomIdentityErrorDescriber : IdentityErrorDescriber
    {
        public override IdentityError DuplicateEmail(string email) => new IdentityError { Code = "DuplicateEmail", Description = $"\"{email}\" başka bir kullanıcı tarafından kullanılmaktadır." };
        public override IdentityError InvalidEmail(string email) => new IdentityError { Code = "InvalidEmail", Description = "Geçersiz email." };
        public override IdentityError DuplicateUserName(string userName) => new IdentityError
        {
            Code = "DuplicateUserName", Description = $"{userName} Telefon numarası başka bir kullanıcı tarafından kullanılmaktadır."
        };

        public override IdentityError PasswordTooShort(int length) => new IdentityError
        { Code = "PasswordLength", Description = "Lütfen şifreyi en az 5 karakter giriniz." };
    }
}
