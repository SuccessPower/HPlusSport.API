using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace HPlusSport.API.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Active Men"},
                new Category { Id = 2, Name = "Active Women" },
                new Category { Id = 3, Name = "Mineral Water" },
                new Category { Id = 4, Name = "Publications" },
                new Category { Id = 5, Name = "Supplements" }
                );

            modelBuilder.Entity<Product>().HasData(
            // Products for "Active Men" category
            new Product { Id = 1, CategoryId = 1, Name = "Men's Running Shoes", Description = "High-performance running shoes for men", Price = 99.99m, IsAvailable = true, Sku = "MRS001" },
            new Product { Id = 2, CategoryId = 1, Name = "Men's Workout Shorts", Description = "Comfortable and stylish workout shorts for men", Price = 29.99m, IsAvailable = false, Sku = "MWS001" },
            new Product { Id = 3, CategoryId = 1, Name = "Men's Gym T-Shirt", Description = "Breathable and moisture-wicking t-shirt for workouts", Price = 19.99m, IsAvailable = true, Sku = "MGT001" },
            new Product { Id = 4, CategoryId = 1, Name = "Men's Fitness Tracker", Description = "Track your fitness goals with this smartwatch", Price = 149.99m, IsAvailable = false, Sku = "MFT001" },
            new Product { Id = 5, CategoryId = 1, Name = "Men's Yoga Mat", Description = "Non-slip yoga mat for men's yoga practice", Price = 39.99m, IsAvailable = true, Sku = "MYM001" },

            // Products for "Active Women" category
            new Product { Id = 6, CategoryId = 2, Name = "Women's Yoga Pants", Description = "Flexible and breathable yoga pants for women", Price = 49.99m, IsAvailable = true, Sku = "WYP001" },
            new Product { Id = 7, CategoryId = 2, Name = "Women's Running Shoes", Description = "Lightweight running shoes for women", Price = 89.99m, IsAvailable = false, Sku = "WRS001" },
            new Product { Id = 8, CategoryId = 2, Name = "Women's Sports Bra", Description = "Supportive sports bra for workouts", Price = 24.99m, IsAvailable = true, Sku = "WSB001" },
            new Product { Id = 9, CategoryId = 2, Name = "Women's Gym Leggings", Description = "Stretchy leggings for gym sessions", Price = 29.99m, IsAvailable = false, Sku = "WGL001" },
            new Product { Id = 10, CategoryId = 2, Name = "Women's Water Bottle", Description = "Leak-proof water bottle for staying hydrated", Price = 9.99m, IsAvailable = true, Sku = "WWB001" },

            // Products for "Mineral Water" category
            new Product { Id = 11, CategoryId = 3, Name = "Natural Spring Water (1L)", Description = "Purified natural spring water in a 1-liter bottle", Price = 1.99m, IsAvailable = true, Sku = "NW1L001" },
            new Product { Id = 12, CategoryId = 3, Name = "Sparkling Mineral Water (500ml)", Description = "Bubbly mineral water in a 500ml bottle", Price = 2.49m, IsAvailable = false, Sku = "SMW500ML001" },
            new Product { Id = 13, CategoryId = 3, Name = "Electrolyte-Infused Water (750ml)", Description = "Hydration with added electrolytes in a 750ml bottle", Price = 2.99m, IsAvailable = true, Sku = "EIW750ML001" },
            new Product { Id = 14, CategoryId = 3, Name = "Flavored Water Variety Pack (12-Pack)", Description = "Assorted flavored water bottles in a 12-pack", Price = 11.99m, IsAvailable = false, Sku = "FWVP12PK001" },
            new Product { Id = 15, CategoryId = 3, Name = "Alkaline Water (1.5L)", Description = "High pH alkaline water in a 1.5-liter bottle", Price = 3.49m, IsAvailable = true, Sku = "AW1.5L001" },

            // Products for "Publications" category
            new Product { Id = 16, CategoryId = 4, Name = "Fitness Magazine", Description = "Monthly fitness magazine with workout tips and more", Price = 4.99m, IsAvailable = true, Sku = "FM001" },
            new Product { Id = 17, CategoryId = 4, Name = "Healthy Cooking Cookbook", Description = "Cookbook with delicious and healthy recipes", Price = 19.99m, IsAvailable = false, Sku = "HCCBK001" },
            new Product { Id = 18, CategoryId = 4, Name = "Running Guide Book", Description = "Comprehensive guide to running and training", Price = 12.99m, IsAvailable = true, Sku = "RGBK001" },
            new Product { Id = 19, CategoryId = 4, Name = "Yoga Instruction DVD Set", Description = "DVD set for yoga practice and meditation", Price = 14.99m, IsAvailable = false, Sku = "YIDVDSET001" },
            new Product { Id = 20, CategoryId = 4, Name = "Health and Wellness Journal", Description = "Journal for tracking your health and wellness journey", Price = 9.99m, IsAvailable = true, Sku = "HWJ001" },

            // Products for "Supplements" category
            new Product { Id = 21, CategoryId = 5, Name = "Protein Powder (2 lbs)", Description = "Whey protein powder for muscle recovery", Price = 29.99m, IsAvailable = true, Sku = "PP2LB001" },
            new Product { Id = 22, CategoryId = 5, Name = "Multivitamin Tablets (90ct)", Description = "Daily multivitamin tablets for overall health", Price = 14.99m, IsAvailable = false, Sku = "MVT90CT001" },
            new Product { Id = 23, CategoryId = 5, Name = "Fish Oil Capsules (120ct)", Description = "Omega-3 fish oil capsules for heart health", Price = 19.99m, IsAvailable = true, Sku = "FOC120CT001" },
            new Product { Id = 24, CategoryId = 5, Name = "Pre-Workout Supplement", Description = "Energy-boosting pre-workout supplement", Price = 34.99m, IsAvailable = false, Sku = "PWS001" },
            new Product { Id = 25, CategoryId = 5, Name = "Vitamin D3 (60ct)", Description = "Vitamin D3 capsules for bone health", Price = 9.99m, IsAvailable = true, Sku = "VDD60CT001" });
        }
    }
}
