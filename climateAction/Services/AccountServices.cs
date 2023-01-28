using climateAction.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace climateAction.Services
{
    public class AccountServices: IAccountServices
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        public AccountServices(UserManager<ApplicationUser> _userManager,
            SignInManager<ApplicationUser> _signInManager)
        {
            userManager = _userManager;
            signInManager = _signInManager;
        }
        public async Task<IdentityResult> createAccount(signUpModel signUpModel)
        {
            ApplicationUser user = new ApplicationUser();
            user.UserName = signUpModel.Username;
            user.Email = signUpModel.Username;

            var r = await userManager.CreateAsync(user, signUpModel.password);
            return r;
        }
        public async Task<string> login(SignInModel signInModel)
        {
            var r = await signInManager.PasswordSignInAsync(signInModel.Username, signInModel.password, signInModel.RememberMe, false);
            if (!r.Succeeded)
            {
                return null;
            }
            return r.ToString();
        }
    }
}
