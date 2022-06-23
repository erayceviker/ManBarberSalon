using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Internal;

namespace WebUI.ValidationRules.CustomValidations
{
    public class CustomPasswordValidation : IPasswordValidator<AppUser>
    {
        public Task<IdentityResult> ValidateAsync(UserManager<AppUser> manager, AppUser user, string password)
        {
            List<IdentityError> errors = new List<IdentityError>();
            if (password.ToLower().Contains(user.PhoneNumber.ToLower())) 
                errors.Add(new IdentityError { Code = "PasswordContainsPhoneNumber", Description = "Lütfen şifre içerisinde telefon numaranızı yazmayınız." });

            if (!errors.Any())
            {
                return Task.FromResult(IdentityResult.Success);
            }
            return Task.FromResult(IdentityResult.Failed(errors.ToArray()));
        }
    }
}
