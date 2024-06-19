public class TypeModule
{
    private readonly MyDatabase _db;
    public TypeModule(MyDatabase db)
    {
        _db = db;
    }
    // Get
    public IEnumerable<Type> Get()
    {
        return _db.Types.ToList();
    }
    // Create
    public bool Create(Type type)
    {
        _db.Types.Add(type);
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