using climateAction.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace climateAction.Services
{
    public interface IAccountServices
    {
        Task<IdentityResult> createAccount(signUpModel signUpModel);
        Task<string> login(SignInModel signInModel);
    }
}
