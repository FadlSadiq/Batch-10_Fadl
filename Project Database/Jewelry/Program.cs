class Program
{
    static void Main()
    {
        using (Northwind db = new())
        {
            // Test Connection
            bool status = db.Database.CanConnect();
            System.Console.WriteLine(status);
        }

        // Read Brand Table
        using (Northwind db = new())
        {
            List<Brand> brands = db.Categories.ToList();
            foreach (var category in categories)
            {
                System.Console.WriteLine($"Category id: {category.CategoryId} | Category name: {category.CategoryName} | Category description: {category.Description}");
            }
        }
        // Read Filter
        using (Northwind db = new())
        {
            string filter = "Seafood";
            IQueryable<Category> categories = db.Categories.Where(data => data.CategoryName == filter);
            foreach (var category in categories)
            {
                System.Console.WriteLine(category.Description);
            }

        }
        // Create
        using (Northwind db = new())
        {
            bool isActive = true;
            while (isActive == true)
            {
                Category category2 = new();
                category2.CategoryName = Console.ReadLine();
                category2.Description = Console.ReadLine();
                System.Console.WriteLine("Create new Item? y/n");
                ConsoleKey keyPressed

                if (keyPressed == ConsoleKey.y)
                {
                    isActive = true;
                }
                else (keyPressed == ConsoleKey.n)
                {
                    isActive = false;
                    db.SaveChanges();
                    System.Console.WriteLine("Your Database has been updated");
                }
                //bisa dibuat readline lalu looping
            }
        }
    }
}
