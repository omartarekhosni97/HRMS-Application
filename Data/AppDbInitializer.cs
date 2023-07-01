using HRMS.Data.Enums;
using HRMS.Models;
using HRMS.Data;
using HRMS.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRMS.Data.Static;

namespace HRMS.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                
                //Items
                if (!context.Items.Any())
                {
                    context.Items.AddRange(new List<Item>()
                    {
                        new Item()
                        {
                            Name = "Grilled Chicken",
                            ItemAvailable = ItemAvailable.Yes
                            
                        },
                        new Item()
                        {
                            Name = "Charcoal Chicken",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "Rice",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "Fries",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "Garlic dip",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "Ketchup",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "Pickles",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "Bread",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "Burger",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "Sweet potato",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "Quinoa patty",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "Cucumber",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "Avocado slices",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "Cereals toasted",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "Salad",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "Potato bun",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "Beef patty",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "melted cheddar cheese",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "Crispy onion",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "BBQ sauce",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "Caramelized onion",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "Crispy bacon",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "Honey mustard",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "Crispy slaw",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "Tilapia fish",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "Grey mullet fish",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "Shrimp",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "Fish fillet",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "Squid",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "Soup",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "Rizo",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "Cheesy fries",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "Motzarella cheese sticks",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "sweet chili sauce",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "lemon",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "ginger",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "carrot",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "apple",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "orange",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "raspberry",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "kiwi",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "coca-cola can",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "Espresso",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "Milk",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "Spanish latte",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "Fanta can",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "water",
                            ItemAvailable = ItemAvailable.Yes

                        },
                        new Item()
                        {
                            Name = "tea",
                            ItemAvailable = ItemAvailable.Yes

                        }
                    });
                    context.SaveChanges();
                }
                
                //Dishes
                if (!context.Dishes.Any())
                {
                    context.Dishes.AddRange(new List<Dish>()
                    {
                        new Dish()
                        {
                            Name = "Dish 1",
                            Description = "This is dish description",
                            Price = 39.50,
                            DishCategory = DishCategory.Beef

                        },
                        new Dish()
                        {
                            Name = "Dish 2",
                            Description = "This is dish description",
                            Price = 69.50,
                            DishCategory = DishCategory.Beef

                        },
                        new Dish()
                        {
                            Name = "Dish 3",
                            Description = "This is dish description",
                            Price = 60.50,
                            DishCategory = DishCategory.Chicken

                        },
                        new Dish()
                        {
                            Name = "Dish 4",
                            Description = "This is dish description",
                            Price = 76.50,
                            DishCategory = DishCategory.Chicken

                        },
                        new Dish()
                        {
                            Name = "Dish 5",
                            Description = "This is dish description",
                            Price = 20.50,
                            DishCategory = DishCategory.Fish

                        },
                        new Dish()
                        {
                            Name = "Dish 6",
                            Description = "This is dish description",
                            Price = 39.50,
                            DishCategory = DishCategory.Desert

                        },
                        new Dish()
                        {
                            Name = "Dish 7",
                            Description = "This is dish description",
                            Price = 69.50,
                            DishCategory = DishCategory.Drink

                        },
                        new Dish()
                        {
                            Name = "Dish 8",
                            Description = "This is dish description",
                            Price = 99.50,
                            DishCategory = DishCategory.Appetizer

                        },
                        new Dish()
                        {
                            Name = "Dish 9",
                            Description = "This is dish description",
                            Price = 139.50,
                            DishCategory = DishCategory.Appetizer

                        },
                        new Dish()
                        {
                            Name = "Dish 10",
                            Description = "This is dish description",
                            Price = 88.50,
                            DishCategory = DishCategory.Drink

                        },
                        new Dish()
                        {
                            Name = "Dish 11",
                            Description = "This is dish description",
                            Price = 120.50,
                            DishCategory = DishCategory.Drink

                        },
                        new Dish()
                        {
                            Name = "Dish 12",
                            Description = "This is dish description",
                            Price = 38.50,
                            DishCategory = DishCategory.Beef

                        },
                        new Dish()
                        {
                            Name = "Dish 13",
                            Description = "This is dish description",
                            Price = 39.50,
                            DishCategory = DishCategory.Beef

                        },
                        new Dish()
                        {
                            Name = "Dish 14",
                            Description = "This is dish description",
                            Price = 65.50,
                            DishCategory = DishCategory.Appetizer

                        },
                        new Dish()
                        {
                            Name = "Dish 15",
                            Description = "This is dish description",
                            Price = 98.50,
                            DishCategory = DishCategory.Desert

                        },
                        new Dish()
                        {
                            Name = "Dish 16",
                            Description = "This is dish description",
                            Price = 47.50,
                            DishCategory = DishCategory.Appetizer

                        },
                        new Dish()
                        {
                            Name = "Dish 17",
                            Description = "This is dish description",
                            Price = 70.50,
                            DishCategory = DishCategory.Drink

                        },
                        new Dish()
                        {
                            Name = "Dish 18",
                            Description = "This is dish description",
                            Price = 99.50,
                            DishCategory = DishCategory.Chicken

                        }
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Items_Dishes.Any())
                {
                    context.Items_Dishes.AddRange(new List<Item_Dish>()
                    {
                        new Item_Dish()
                        {
                            ItemId = 2,
                            DishId = 18
                        },
                        new Item_Dish()
                        {
                            ItemId = 5,
                            DishId = 18
                        },
                        new Item_Dish()
                        {
                            ItemId = 16,
                            DishId = 18
                        },
                        new Item_Dish()
                        {
                            ItemId = 10,
                            DishId = 2
                        },
                        new Item_Dish()
                        {
                            ItemId = 12,
                            DishId = 2
                        },
                        new Item_Dish()
                        {
                            ItemId = 11,
                            DishId = 2
                        },
                        new Item_Dish()
                        {
                            ItemId = 2,
                            DishId = 2
                        },
                        new Item_Dish()
                        {
                            ItemId = 35,
                            DishId = 3
                        },
                        new Item_Dish()
                        {
                            ItemId = 30,
                            DishId = 3
                        },
                        new Item_Dish()
                        {
                            ItemId = 24,
                            DishId = 4
                        },
                        new Item_Dish()
                        {
                            ItemId = 46,
                            DishId = 4
                        },
                        new Item_Dish()
                        {
                            ItemId = 44,
                            DishId = 5
                        },
                        new Item_Dish()
                        {
                            ItemId = 42,
                            DishId = 6
                        },
                        new Item_Dish()
                        {
                            ItemId = 41,
                            DishId = 7
                        },
                        new Item_Dish()
                        {
                            ItemId = 40,
                            DishId = 8
                        },
                        new Item_Dish()
                        {
                            ItemId = 30,
                            DishId = 9
                        },
                        new Item_Dish()
                        {
                            ItemId = 22,
                            DishId = 9
                        },
                        new Item_Dish()
                        {
                            ItemId = 11,
                            DishId = 10
                        },
                        new Item_Dish()
                        {
                            ItemId = 12,
                            DishId = 10
                        },
                        new Item_Dish()
                        {
                            ItemId = 11,
                            DishId = 11
                        },
                        new Item_Dish()
                        {
                            ItemId = 35,
                            DishId = 11
                        },
                        new Item_Dish()
                        {
                            ItemId = 17,
                            DishId = 11
                        },
                        new Item_Dish()
                        {
                            ItemId = 3,
                            DishId = 12
                        },
                        new Item_Dish()
                        {
                            ItemId = 5,
                            DishId = 12
                        },
                        new Item_Dish()
                        {
                            ItemId = 38,
                            DishId = 12
                        },
                        new Item_Dish()
                        {
                            ItemId = 39,
                            DishId = 13
                        },
                        new Item_Dish()
                        {
                            ItemId = 11,
                            DishId = 14
                        },
                        new Item_Dish()
                        {
                            ItemId = 36,
                            DishId = 14
                        },
                        new Item_Dish()
                        {
                            ItemId = 26,
                            DishId = 14
                        },
                        new Item_Dish()
                        {
                            ItemId = 5,
                            DishId = 14
                        },
                        new Item_Dish()
                        {
                            ItemId = 27,
                            DishId = 15
                        },
                        new Item_Dish()
                        {
                            ItemId = 31,
                            DishId = 15
                        },
                        new Item_Dish()
                        {
                            ItemId = 9,
                            DishId = 16
                        },
                        new Item_Dish()
                        {
                            ItemId = 7,
                            DishId = 17
                        },
                        new Item_Dish()
                        {
                            ItemId = 6,
                            DishId = 17
                        },
                        new Item_Dish()
                        {
                            ItemId = 15,
                            DishId = 17
                        },
                        new Item_Dish()
                        {
                            ItemId = 25,
                            DishId = 17
                        }


                    });
                    context.SaveChanges();
                }
            }

        }
        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));
                if (!await roleManager.RoleExistsAsync(UserRoles.Staff))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Staff));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                string adminUserEmail = "admin@HRMS.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding@1234");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }


                string appUserEmail = "user@HRMS.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Application User",
                        UserName = "user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Coding@1234");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }


                string staffUserEmail = "staff@HRMS.com";

                var staffUser = await userManager.FindByEmailAsync(staffUserEmail);
                if (staffUser == null)
                {
                    var newStaffUser = new ApplicationUser()
                    {
                        FullName = "Staff User",
                        UserName = "staff",
                        Email = staffUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newStaffUser, "Coding@1234");
                    await userManager.AddToRoleAsync(newStaffUser, UserRoles.Staff);
                }
            }
        }

    }
}