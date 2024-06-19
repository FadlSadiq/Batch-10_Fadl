using Microsoft.AspNetCore.Mvc;

public class BrandController : Controller
{
    private readonly MyDatabase _db;
    public BrandController(MyDatabase database)
    {
        _db = database;
    }
    public IActionResult Index()
    {
        List<Brand> brands = _db.Brands.ToList();
        return View(brands);
    }
    public IActionResult Create()
    {
        return View();
    }
    public IActionResult Edit(int? id)
    {
        if (id == null || id == 0) {return NotFound();}
        Brand brand = _db.Brands.Find(id);
        return View(brand);
    }
    [HttpPost]
    public async Task<IActionResult> Edit(Brand brand)
    {
        Brand existingBrand = _db.Brands.Find(brand.BrandId);
        existingBrand.BrandName = brand.BrandName;
        existingBrand.Description = brand.Description;
        await _db.SaveChangesAsync();
        return RedirectToAction("Index");
    }
    public IActionResult Delete()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Create(Brand brand)
    {
        _db.Brands.Add(brand);
        await _db.SaveChangesAsync();
        return RedirectToAction("Index");
    }
}