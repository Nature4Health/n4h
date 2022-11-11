using System.Diagnostics.Metrics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectLexiconWebApp.Models;
using static ProjectLexiconWebApp.ViewModels.UserRoleViewModel;

namespace ProjectLexiconWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



            Brand brand1 = new Brand() { Id = 1, Name = "New Foods" };
            Brand brand2 = new Brand() { Id = 2, Name = "Holistic" };
            Brand brand3 = new Brand() { Id = 3, Name = "Happy Green" };
            Brand brand4 = new Brand() { Id = 4, Name = "RawFood" };

            /*Add more brands*/
            Brand brand5 = new Brand() { Id = 5, Name = "NaturGreen" };
            Brand brand6 = new Brand() { Id = 6, Name = "Ecobasics" };
            Brand brand7 = new Brand() { Id = 7, Name = "Primeal" };
            Brand brand8 = new Brand() { Id = 8, Name = "Probios" };
            Brand brand9 = new Brand() { Id = 9, Name = "Vegetalia" };
            Brand brand10 = new Brand() { Id = 10, Name = "Nature4Health" };


            modelBuilder.Entity<Brand>().HasData(brand1);
            modelBuilder.Entity<Brand>().HasData(brand2);
            modelBuilder.Entity<Brand>().HasData(brand3);
            modelBuilder.Entity<Brand>().HasData(brand4);

            modelBuilder.Entity<Brand>().HasData(brand5);
            modelBuilder.Entity<Brand>().HasData(brand6);
            modelBuilder.Entity<Brand>().HasData(brand7);
            modelBuilder.Entity<Brand>().HasData(brand8);
            modelBuilder.Entity<Brand>().HasData(brand9);
            modelBuilder.Entity<Brand>().HasData(brand10);



            Category category1 = new Category() { Id = 1, Name = "Nuts and seeds" };
            Category category2 = new Category() { Id = 2, Name = "Drink" };
            Category category3 = new Category() { Id = 3, Name = "Tea" };
            Category category4 = new Category() { Id = 4, Name = "Sweeteners" };
            Category category5 = new Category() { Id = 5, Name = "Food" };
            Category category6 = new Category() { Id = 6, Name = "Coffee" };

            modelBuilder.Entity<Category>().HasData(category1);
            modelBuilder.Entity<Category>().HasData(category2);
            modelBuilder.Entity<Category>().HasData(category3);
            modelBuilder.Entity<Category>().HasData(category4);
            modelBuilder.Entity<Category>().HasData(category5);
            modelBuilder.Entity<Category>().HasData(category6);


            Product p1 = new Product() { Id = 1, Name = "Honey", Description = "Sweet and good for your body. Perfect combo with tea.", UnitPrice = 34.5m, DiscountedPrice = 0.0m, Size = "100g", Quantity = 20, ProductRate = 8, CategoryId = 4, BrandId = 1, Picture = "honey-main.png" };

            Product p2 = new Product() { Id = 2, Name = "Macadamia nuts", Description = "De extra stora macadamia nötterna är torrostade och smaksatta med en liten gnutta havssalt. Torrostningen framhäver den fina nötsmaken och gör dem lagom knapriga. Macadamianötter är en av de fetaste nötterna och är rika på omega fettsyror, protein samt fibrer och en del mineraler.", UnitPrice = 132.35m, DiscountedPrice = 0.0m, Size = "100g", Quantity = 20, ProductRate = 8, CategoryId = 1, BrandId = 2, Picture = "macadamina-main.png" };

            Product p3 = new Product() { Id = 3, Name = "Granola", Description = "Starta dagen med den smakrika och knapriga granolan från Clean Eating. Gjord på naturliga ingredienser utan tillsatser. Clean Eating Granola är ugnsrostad i kokosolja och sötad med honung och juice från frukter som ger en naturligt god och söt smak. Granolan passar både stora som små i familjen, och är ett nyttigare och godare alternativ till frukosten eller mellanmålet. Clean Eating Granola finns i tre goda smaker som passar de flesta smaklökar!", UnitPrice = 80.6m, DiscountedPrice = 0.0m, Size = "500g", Quantity = 20, ProductRate = 8, CategoryId = 5, BrandId = 3, Picture = "granola-main.png" };

            Product p4 = new Product() { Id = 4, Name = "Chamomile", Description = "Örtagubben Kamomill (Matricaria recutita) består av torkade kamomillblommor från ekologisk odling. Kamomill har en aromatisk doft och en milt bitter smak som många uppskattar. Kamomill är en välbekant blomma i den svenska floran, och en vanlig ört att använda i örtteer. Drick en kopp kamomillte på kvällen när du vill lugna ner dig och komma till ro inför natten. Kamomill är en ettårig, aromatiskt doftande ört som kan bli upp till fyra decimeter hög. Blomkorgarna är prästkragelika och sitter på långa skaft. Kamomill är ett ogräs som förekommer tämligen allmänt upp till Gästrikland och blommar från juni till oktober. Ursprungligen hör den hemma i södra och östra Europa men är numera spridd i nästan hela Europa, såväl som i Kanada och USA.", UnitPrice = 60.00m, DiscountedPrice = 0.0m, Size = "100g", Quantity = 20, ProductRate = 3, CategoryId = 3, BrandId = 4, Picture = "chamomile-main.png" };


            modelBuilder.Entity<Product>().HasData(p1);
            modelBuilder.Entity<Product>().HasData(p2);
            modelBuilder.Entity<Product>().HasData(p3);
            modelBuilder.Entity<Product>().HasData(p4);

            /* Add more products */

            Product p5 = new Product() { Id = 5, Name = "Organic apple compote", Description = "Apple puree from organic farming 98% and organic sugar.", UnitPrice = 55.26m, DiscountedPrice = 0.0m, Size = "620g", Quantity = 20, ProductRate = 8, CategoryId = 4, BrandId = 5, Picture = "apple-compot.jpeg" };


            Product p6 = new Product() { Id = 6, Name = "organic coconut oil", Description = "organically grown coconut oil, rich in nutrients and fatty acids such as lauric acid.", UnitPrice = 66.98m, DiscountedPrice = 0.0m, Size = "500ml", Quantity = 20, ProductRate = 8, CategoryId = 4, BrandId = 10, Picture = "coconut-oil.jpeg" };

            Product p7 = new Product() { Id = 7, Name = "Organic red lentils", Description = "Very healthy source of protein and carbohydrates with few calories.", UnitPrice = 36.92m, DiscountedPrice = 0.0m, Size = "500g", Quantity = 20, ProductRate = 9, CategoryId = 5, BrandId = 5, Picture = "red-lentils.jpeg" };

            Product p8 = new Product() { Id = 8, Name = "Organic lentils", Description = "Very healthy source of protein and carbohydrates with few calories.", UnitPrice = 31.43m, DiscountedPrice = 0.0m, Size = "500g", Quantity = 20, ProductRate = 9, CategoryId = 5, BrandId = 6, Picture = "linser.jpeg" };


            Product p9 = new Product() { Id = 9, Name = "Peanut butter", Description = "Peanut butter with peanut pieces and Himalayan salt is an organic and crunchy cream. It is made from peanuts and a pinch of Himalayan salt. Nothing more.", UnitPrice = 36.88m, DiscountedPrice = 0.0m, Size = "250g", Quantity = 20, ProductRate = 10, CategoryId = 4, BrandId = 6, Picture = "Peanut-butter.jpeg" };

            Product p10 = new Product() { Id = 10, Name = "Organic tapioca flour", Description = "Tapioca is a type of flour that can be used for sweet and savory preparations. Rich in carbohydrates, rich in fibre, it provides energy and contains vitamins and minerals and is easily digestible.", UnitPrice = 41.05m, DiscountedPrice = 0.0m, Size = "400g", Quantity = 20, ProductRate = 8, CategoryId = 5, BrandId = 7, Picture = "Tapioka.jpeg" };

            Product p11 = new Product() { Id = 11, Name = "Ayurveda Tea Turmeric", Description = "An organic tea completely free of caffeine and added flavorings - in other words, a richly good & spicy tea! Turmeric Relax is based on turmeric root with spicy elements of ginger, cinnamon and anise.", UnitPrice = 39.99m, DiscountedPrice = 0.0m, Size = "100g", Quantity = 20, ProductRate = 8, CategoryId = 3, BrandId = 10, Picture = "Ayurveda-Tea-Turmeric.jpeg" };

            Product p12 = new Product() { Id = 12, Name = "Roasted and Ground Organic Coffee", Description = "Arabica coffee harvested and roasted in an artisanal way, in the beautiful region of Matas de Minas Gerais. Cultivated in mountains with altitudes of 900 to 1200 meters. Chocolate, nuts and red fruits.", UnitPrice = 93.99m, DiscountedPrice = 0.0m, Size = "250g", Quantity = 20, ProductRate = 10, CategoryId = 6, BrandId = 10, Picture = "Coffee.jpeg" };


            modelBuilder.Entity<Product>().HasData(p5);
            modelBuilder.Entity<Product>().HasData(p6);
            modelBuilder.Entity<Product>().HasData(p7);
            modelBuilder.Entity<Product>().HasData(p8);
            modelBuilder.Entity<Product>().HasData(p9);
            modelBuilder.Entity<Product>().HasData(p10);
            modelBuilder.Entity<Product>().HasData(p11);
            modelBuilder.Entity<Product>().HasData(p12);




            Customer c1 = new Customer() { Id = 1, FirstName = "Pedro", LastName = "Feitoza", EMail = "user@user.com", Address = "Kungsgatan 1", ZipCode = "00000", City = "Göteborg", Phone = "46780964", CreatedAt = DateTime.Today, Wallet = 1000.0M };

            modelBuilder.Entity<Customer>().HasData(c1);


            Order order1 = new Order() { Id = 1, OrderDate = DateTime.Today, Status = "pending", CustomerId = 1 };


            OrderItem orderItem1 = new OrderItem() { Id = 1, OrderId = order1.Id, ProductId = p1.Id, Quantity = 2 };
            OrderItem orderItem2 = new OrderItem() { Id = 2, OrderId = order1.Id, ProductId = p2.Id, Quantity = 2 };
            OrderItem orderItem3 = new OrderItem() { Id = 3, OrderId = order1.Id, ProductId = p3.Id, Quantity = 3 };
            OrderItem orderItem4 = new OrderItem() { Id = 4, OrderId = order1.Id, ProductId = p4.Id, Quantity = 2 };

            modelBuilder.Entity<Order>().HasData(order1);
            modelBuilder.Entity<OrderItem>().HasData(orderItem1);
            modelBuilder.Entity<OrderItem>().HasData(orderItem2);
            modelBuilder.Entity<OrderItem>().HasData(orderItem3);
            modelBuilder.Entity<OrderItem>().HasData(orderItem4);

            //Seed shipper table
            modelBuilder.Entity<Shipper>().HasData
            (
                new Shipper { Id = 1, Name = "PostNord" },
                new Shipper { Id = 2, Name = "DHL" },
                new Shipper { Id = 3, Name = "DB Schenker" }
            );

            // ------------------------------------- Roles guid

            string adminRoleId = Guid.NewGuid().ToString();
            string userRoleId = Guid.NewGuid().ToString();
            string userId = Guid.NewGuid().ToString();

            PasswordHasher<ApplicationUser> hasher = new PasswordHasher<ApplicationUser>();

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = adminRoleId, Name = "Admin", NormalizedName = "ADMIN" });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole { Id = userRoleId, Name = "User", NormalizedName = "USER" });

            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = userId,
                Email = "admin@n4h.com",
                NormalizedEmail = "ADMIN@N4H.COM",
                UserName = "admin@n4h.com",
                NormalizedUserName = "ADMIN@N4H.COM",
                FirstName = "Daniel",
                LastName = "O.",
                Address = "Adminsgatan 1",
                ZipCode = "10001",
                City = "Borås",
                Phone = "10101010101",
                PasswordHash = hasher.HashPassword(null, "password")
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = adminRoleId,
                UserId = userId
            });



        }



    }

}

