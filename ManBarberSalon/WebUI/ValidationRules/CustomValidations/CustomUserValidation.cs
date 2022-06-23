using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete.Authentication;
using Microsoft.AspNetCore.Identity;

namespace WebUI.ValidationRules.CustomValidations
{
    public class CustomUserValidation : IUserValidator<AppUser>
    {
        public Task<IdentityResult> ValidateAsync(UserManager<AppUser> manager, AppUser user)
        {
            List<IdentityError> errors = new List<IdentityError>();

            if (user.Email.Length > 70)
                errors.Add(new IdentityError { Code = "EmailLenhth", Description = "Email 70 karakterden fazla olamaz..." });

            if (!errors.Any())
                return Task.FromResult(IdentityResult.Success);
            return Task.FromResult(IdentityResult.Failed(errors.ToArray()));
        }
    }
}
