using Core.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace EF_Infrastructure
{
    public class AvansFoodDbContext : DbContext
    {
        public DbSet<Canteen>? Canteens { get; set; }
        public DbSet<CanteenEmployee>? CanteenEmployees { get; set; }
        public DbSet<FoodPackage>? FoodPackages { get; set; }
        public DbSet<Product>? Products { get; set; }
        public DbSet<Student>? Students { get; set; }

        public AvansFoodDbContext(DbContextOptions<AvansFoodDbContext> contextOptions) : base(contextOptions)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Creating canteens seeding data
            IEnumerable<Canteen> canteens = new List<Canteen>
            {
                new Canteen
                {
                    Id = 1, City = CityEnum.Breda, HotMeals = true, Location = LocationEnum.LaGebouw
                },
                new Canteen
                {
                    Id = 2, City = CityEnum.DenBosch, HotMeals = false, Location = LocationEnum.DbGebouw
                },
            };

            //Creating canteen employees seeding data
            IEnumerable<CanteenEmployee> canteenEmployees = new List<CanteenEmployee>
            {
                new CanteenEmployee
                {
                    Id = 1, Canteen = canteens.ToList()[0], EmployeeNumber = "12345", FirstName = "Quincy", LastName = "Van Deursen"
                },
                new CanteenEmployee
                {
                    Id = 2, Canteen = canteens.ToList()[1], EmployeeNumber = "678910", FirstName = "Sybrand", LastName = "Bos"
                },
            };

            //Creating products seeding data
            IEnumerable<Product> products = new List<Product>
            {
                new Product
                {
                    Id = 1, Name = "Stokbrood", ContainsAlcohol = false
                },
                new Product
                {
                    Id = 2, Name = "Croissant", ContainsAlcohol = false
                },
                new Product
                {
                    Id = 3, Name = "Komkommer", ContainsAlcohol = false
                },
                new Product
                {
                    Id = 4, Name = "Winterpeen", ContainsAlcohol = false
                }
            };

            //Creating food package categories seeding data
            IEnumerable<FoodPackageCategory> foodPackageCategories = new List<FoodPackageCategory>
            {
                new FoodPackageCategory
                {
                    Id = 1, Name = "Broodbox", ProductList = new List<Product>() { products.ToList()[0], products.ToList()[1] }, ContainsAlcohol = true
                },
                new FoodPackageCategory
                {
                    Id = 2, Name = "Groentebox", ProductList = new List<Product>() { products.ToList()[2], products.ToList()[3] }, ContainsAlcohol = true

                }
            };

            //Creating students seeding data
            IEnumerable<Student> students = new List<Student>
            {
                new Student
                {
                    Id = 1, FirstName = "Anna", LastName = "Janssen", EmailAddress = "Annajanssen@gmail.com", StudentNumber = "2185642", CityOfStudy = CityEnum.Breda, PhoneNumber = "0612345678", BirthDate = new DateOnly(2000, 07, 23)
                },
                new Student
                {
                    Id = 2, FirstName = "Peter", LastName = "de Jong", EmailAddress = "PeterDeJong@gmail.com", StudentNumber = "2187823", CityOfStudy = CityEnum.DenBosch, PhoneNumber = "0687498274", BirthDate = new DateOnly(2001, 03, 01)
                }
            };

            //Creating food packages seeding data
            IEnumerable<FoodPackage> foodPackages = new List<FoodPackage>
            {
                new FoodPackage
                {
                    Id = 1, Canteen = canteens.ToList()[0], PickUpDate = new DateOnly(2022, 10, 12), PickUpTime = new TimeOnly(17, 00), Price = 5.00, Category = foodPackageCategories.ToList()[0], TypeOfMeal = MealTypeEnum.Beverage, ReservedBy = students.ToList()[0]
                },
                new FoodPackage
                {
                    Id = 2, Canteen = canteens.ToList()[1], PickUpDate = new DateOnly(2022, 09, 29), PickUpTime = new TimeOnly(17, 00), Price = 5.00, Category = foodPackageCategories.ToList()[1], TypeOfMeal = MealTypeEnum.Beverage, ReservedBy = students.ToList()[1]
                },
            };

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Canteen>().HasData(canteens);
            modelBuilder.Entity<CanteenEmployee>().HasData(canteenEmployees);
            modelBuilder.Entity<Product>().HasData(products);
            modelBuilder.Entity<FoodPackageCategory>().HasData(foodPackageCategories);
            modelBuilder.Entity<Student>().HasData(students);
            modelBuilder.Entity<FoodPackage>().HasData(foodPackages);
        }
    }
}
