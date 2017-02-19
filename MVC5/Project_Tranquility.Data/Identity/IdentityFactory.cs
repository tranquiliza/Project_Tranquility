using Microsoft.AspNet.Identity;
using Project_Tranquility.Data.Identity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;


namespace Project_Tranquility.Data.Identity
{
    public class IdentityFactory
    {
        public static UserManager<ApplicationIdentityUser, int> CreateUserManager(DbContext context)
        {
            var manager = new UserManager<ApplicationIdentityUser, int>(new UserStore<ApplicationIdentityUser, ApplicationIdentityRole, int, ApplicationIdentityUserLogin, ApplicationIdentityUserRole, ApplicationIdentityUserClaim>(context));

            //Validation logic for usernames / email.
            manager.UserValidator = new UserValidator<ApplicationIdentityUser, int>(manager)
            {
                AllowOnlyAlphanumericUserNames = false,
                RequireUniqueEmail = true
            };

            //Validation logic for passwords
            manager.PasswordValidator = new PasswordValidator
            {
                RequiredLength = 6,
                RequireNonLetterOrDigit = false,
                RequireDigit = true,
                RequireLowercase = true,
                RequireUppercase = true
            };

            manager.UserLockoutEnabledByDefault = true;
            manager.DefaultAccountLockoutTimeSpan = TimeSpan.FromMinutes(5);
            manager.MaxFailedAccessAttemptsBeforeLockout = 5;

            manager.RegisterTwoFactorProvider("PhoneCode", new PhoneNumberTokenProvider<ApplicationIdentityUser, int>
            {
                MessageFormat = "Your security code is: {0}"
            });

            manager.RegisterTwoFactorProvider("EmailCode", new EmailTokenProvider<ApplicationIdentityUser, int>
            {
                Subject = "SecurityCode",
                BodyFormat = "Your security code is {0}"
            });
            manager.EmailService = new EmailService();
            manager.SmsService = new SmsService();
            return manager;
        }

        public static RoleManager<ApplicationIdentityRole, int> CreateRoleManager(DbContext context)
        {
            return new RoleManager<ApplicationIdentityRole, int>(new RoleStore<ApplicationIdentityRole, int, ApplicationIdentityUserRole>(context));
        }
    }
}
