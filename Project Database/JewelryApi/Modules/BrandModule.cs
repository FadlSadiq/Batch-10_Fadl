public class BrandModule
{
    private readonly MyDatabase _db;
    public BrandModule(MyDatabase db)
    {
        _db = db;
    }
    public IEnumerable<Brand> Get()
    {
        return _db.Brands.ToList();
    }
    public bool Create(Brand brand)
    {
        _db.Brands.Add(brand);
        int value = _db.SaveChanges();
        if (value > 0)
        {
            return true;
        }
        return false;
    }
    // Update
    
    // Delete
}