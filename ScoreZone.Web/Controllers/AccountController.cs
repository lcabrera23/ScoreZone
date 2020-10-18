using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ScoreZone.Web.Data;
using ScoreZone.Web.Data.Entities;
using ScoreZone.Web.Helpers;
using ScoreZone.Web.Models;

namespace ScoreZone.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserHelper _userHelper;
        private readonly DataContext _dataContext;

        public AccountController(IUserHelper userHelper,DataContext dataContext)
        {
            _userHelper = userHelper;
            _dataContext = dataContext;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _userHelper.LoginAsync(model);
                if (result.Succeeded)
                {
                    if (Request.Query.Keys.Contains("ReturnUrl"))
                    {
                        return Redirect(Request.Query["ReturnUrl"].First());
                    }

                    return RedirectToAction("Index", "Home");
                }

            }
            ModelState.AddModelError(string.Empty, "Failed to login.");

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {

            await _userHelper.LogoutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Register(){
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(AddUserViewModel view)
        {
            if (ModelState.IsValid)
            {
                var user = await AddUser(view);
                if (user == null)
                {
                    ModelState.AddModelError(string.Empty, "This email is already used.");
                    return View(view);
                }

                var nuewCustomer = new Customer
                {
                    User = user

                };

                _dataContext.Customers.Add(nuewCustomer);
                await _dataContext.SaveChangesAsync();

                var login = new LoginViewModel
                {
                    Password = view.Password,
                    UserName =user.UserName,
                    RememberMe =false
                };
               await _userHelper.LoginAsync(login);
                return RedirectToAction("Index","Home");
            }

            return View(view);
       
        }

        private async Task<User> AddUser(AddUserViewModel view)
        {
            var user = new User
            {
                Address = view.Address,
                Document = view.Document,
                Email = view.Username,
                FirstName = view.FirstName,
                LastName = view.LastName,
                PhoneNumber = view.PhoneNumber,
                UserName = view.Username
            };

            var result = await _userHelper.AddUserAsync(user, view.Password);
            if (result != IdentityResult.Success)
            {
                return null;
            }

            var newUser = await _userHelper.GetUserByEmailAsync(view.Username);
            await _userHelper.AddUserToRoleAsync(newUser, "Customer");
            return newUser;
        }

    }

}
