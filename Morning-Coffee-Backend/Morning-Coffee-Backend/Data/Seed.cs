using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Morning_Coffee_Backend.Models;
using Newtonsoft.Json;

namespace Morning_Coffee_Backend.Data
{
    public class Seed
    {
        public static void SeedUsers(UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            if (!userManager.Users.Any())
            {
                //var userData = System.IO.File.ReadAllText("Data/UserSeedData.json");
                //var users = JsonConvert.DeserializeObject<List<User>>(userData);

                //create roles to add to the database
                //If you want to change the Role the Data Containes
                //Chnage Here
                var roles = new List<Role>
                {
                    new Role{Name = "Project Owner"},
                    new Role{Name = "Admin"},
                    new Role{Name = "Project Member"},
                    new Role{Name = "Site Moderator"},
                    new Role{Name = "Projectless"}
                };

                //Seed the roles into the role Manage
                //Each Roll will be associated with a numerical Id
                foreach (var role in roles)
                {
                    roleManager.CreateAsync(role).Wait();
                }


                //Once I have Finalized Login Credentials
                //I will loop through and seed fake user in to
                //the Database
                /*
                foreach (var user in users)
                {
          
                    userManager.CreateAsync(user, "password").Wait();
                    userManager.AddToRoleAsync(user, "Member");
                }
                */

                //Creating the Admin Account
                var adminUser = new User
                {
                    UserName = "Admin"
                };

                //Getting the Admin account and setting the password to password
                var result = userManager.CreateAsync(adminUser, "password").Result;

                //If the request was successfull 
                if (result.Succeeded)
                {
                    //We will find the admin account
                    var admin = userManager.FindByNameAsync("Admin").Result;
                    //Once the account has been found we will give the Admin access to admin and site Moderator Priviliges
                    userManager.AddToRolesAsync(admin, new[] { "Admin", "Site Moderator" });
                }
            }
        }
    }
}
