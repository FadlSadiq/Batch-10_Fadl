using EntityFramework;

class Program
{
    static void Main()
    {   //READ ALL
        using (Northwind db = new())
        {
            // Test Connection
            bool status = db.Database.CanConnect();
            System.Console.WriteLine(status);

            List<Category> categories = db.Categories.ToList();
            foreach (var category in categories)
            {
                System.Console.WriteLine($"Category id: {category.CategoryId} | Category name: {category.CategoryName} | Category description: {category.Description}");
            }

            // Category? category1 = db.Categories.Find(4);
            // Category? category2 = db.Categories.Where(c => c.CategoryId == 5).First();
            // Category? seafood = db.Categories.Where(c => c.CategoryName == "Seafood").FirstOrDefault();
            // Category? seafood2 = db.Categories.FirstOrDefault(c => c.CategoryName == "Seafood");
            // int category5 = db.Categories.Find(4).CategoryId;
            // int category6 = db.Categories.FirstOrDefault(c => c.CategoryId == 5)?.CategoryId ?? 0;
            // System.Console.WriteLine($"Category id: {category1.CategoryId} | Category name: {category1.CategoryName} | Category description: {category1.Description}");
            // System.Console.WriteLine($"Category id: {category2.CategoryId} | Category name: {category2.CategoryName} | Category description: {category2.Description}");
            // System.Console.WriteLine($"Category id: {seafood.CategoryId} | Category name: {seafood.CategoryName} | Category description: {seafood.Description}");
            // System.Console.WriteLine($"Category id: {category5}");
            // System.Console.WriteLine($"{category6}");


            // Category category3 = new()
            // {
            //     CategoryName = "yanto",
            //     Description = "Eat Something",

            // };
            // db.Categories.Update(category3);
            // db.SaveChanges();
            // Category? sumanto = db.Categories.Where(c => c.CategoryName == "yanto").First();
            // System.Console.WriteLine($"{sumanto.CategoryName} want to {sumanto.Description}");
            // db.Categories.Update
            // Category categoryToUpdate = db.Categories.Where(c => c.CategoryId == 9).FirstOrDefault();
            // if (categoryToUpdate != null)
            // {
            //     categoryToUpdate.CategoryName = "Fruit";
            //     categoryToUpdate.Description = "Apple, orange";
            //     db.SaveChanges();
            // }
            // else
            // {
            //     System.Console.WriteLine("Can't Update");
            // }
            // // db.Categories.Remove
            // Category categoryToRemove = db.Categories.FirstOrDefault(c => c.CategoryId == 9);
            // if (categoryToRemove != null)
            // {
            //     db.Categories.Remove(categoryToRemove);
            //     db.SaveChanges();
            // }
        }

        //READ FILTER
        using (Northwind db = new())
        {
            string filter = "Seafood";
            IQueryable<Category> categories = db.Categories.Where(data => data.CategoryName == filter);
            foreach (var category in categories)
            {
                System.Console.WriteLine(category.Description);
            }

        }
        //Create
        // using (Northwind db = new())
        // {
        //     Category? category = new()
        //     {
        //         CategoryName = "Fish",
        //         Description = "Tuna, Salmon, and Patin",
        //     };
        //     Category category2 = new();
        //     category2.CategoryName = "Snacks";
        //     category2.Description = "Hello Panda";

        //     List<Category> categories1 = new()
        //     {
        //         category, category2
        //     };
        //     // Insert Data
        //     db.Categories.AddRange(categories1);
        //     // db.Categories.Add(category2);
        //     // Save DB
        //     db.SaveChanges();
        //     bool isActive = true;
        //     while (isActive == true)
        //     {
        //         //bisa dibuat readline lalu looping
        //     }
        // }
        //Update
        using (Northwind db = new())
        {
            Category? category = db.Categories.Where(data => data.CategoryName.Contains("Snacks")).FirstOrDefault();
            // IQueryable category = db.Categories.Where(data => data.CategoryName.Contains("Snacks"));
            category.Description = "Taro";
            db.SaveChanges();
        }

        // using (Northwind db = new())
        // {
        //     Category? category = db.Categories.Find(15);
        //     // IQueryable category = db.Categories.Where(data => data.CategoryName.Contains("Snacks"));
        //     category.Description = "Chiki";
        //     db.SaveChanges();
        // }

        //Delete
        using (Northwind db = new())
        {
            Product? product = db.Products.Find(21);
            // Category? category = db.Categories.Where(data => data.CategoryName.Contains("Snacks")).FirstOrDefault();
            // IQueryable category = db.Categories.Where(data => data.CategoryName.Contains("Snacks"));
            // db.Categories.Remove(category);
            db.Products.Remove(product);
            db.SaveChanges();
        }
    }
}