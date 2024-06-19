public class FactoryModule
{
    private readonly MyDatabase _db;
    public FactoryModule(MyDatabase db)
    {
        _db = db;
    }
    // Get
    public IEnumerable<Factory> Get()
    {
        return _db.Factories.ToList();
    }
    // Create
    public bool Create(Factory factory)
    {
        _db.Factories.Add(factory);
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