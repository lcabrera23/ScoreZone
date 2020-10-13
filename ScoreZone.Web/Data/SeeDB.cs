using ScoreZone.Web.Data.Entities;
using ScoreZone.Web.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoreZone.Web.Data
{
    public  class SeeDB
    {
        private readonly DataContext _dataContext;
        private readonly IUserHelper _userHelper;

        public SeeDB(DataContext dataContext ,IUserHelper userHelper)
        {
            _dataContext = dataContext;
            _userHelper = userHelper;
        }

        public  async Task SeedAsync()
        {
            _dataContext.Database.EnsureCreated();
            await CheckRoles();
            var manager = await CheckUserAsync("1010", "luis", "Luis", "luis@gmail.com", "350 634 2747", "Calle Luna Calle Sol", "Admin");
            await CheckManagerAsync(manager);
        }

        private  async Task CheckRoles()
        {
            await _userHelper.CheckRoleAsync("Admin");
            await _userHelper.CheckRoleAsync("Customer");
        }

        private  async Task<User> CheckUserAsync(string document, string firstName, string lastName, string email, string phone, string address, string role)
        {
            var user = await _userHelper.GetUserByEmailAsync(email);
            if (user == null)
            {
                user = new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    UserName = email,
                    PhoneNumber = phone,
                    Address = address,
                    Document = document
                };

                await _userHelper.AddUserAsync(user, "123456");
                await _userHelper.AddUserToRoleAsync(user, role);
            }

            return user;
        }

        private  async Task CheckManagerAsync(User user)
        {
            if (!_dataContext.Managers.Any())
            {
                _dataContext.Managers.Add(new Manager { User = user });
                await _dataContext.SaveChangesAsync();
            }
        }
    }
}
