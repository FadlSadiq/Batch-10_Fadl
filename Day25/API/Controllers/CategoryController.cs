using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

public class CategoryController : ApiBaseController
{
    private readonly CategoryModule _categoryModule;
    public CategoryController(Database db, CategoryModule categoryModule) : base(db)
    {
        _categoryModule = categoryModule;
    }
    [HttpGet]
    public IActionResult GetCategory()
    {
        return Ok(_categoryModule.Get());
    }

    [HttpPost]
    public IActionResult PostCategory(Category category)
    {
        bool status = _categoryModule.Create(category);
        if (status)
        {
            return Ok(category);
        }
        return BadRequest();
    }
    // private readonly IMapper _map;
    // public CategoryController(Database db, IMapper map) : base(db)
    // {
    //     _map = map;
    // }
    // [HttpGet]
    // public IActionResult GetCategory()
    // {
    //     return Ok(_db.Categories.ToList());
    // }

    // [HttpPost]
    // public IActionResult CreateCategory(CategoryDTO category)
    // {
    //     Category cat = _map.Map<Category>(category);
    //     //IEnumerable<Category> categories = _map.Map<IEnumerable<Category>>(collectionOfCategoryDTO); //ini digunakan jika terdapat array CategoryDTO ingin dipassing ke Array Category
    //     // Category cat = new ()
    //     // {
            
    //     //     CategoryName = category.CategoryName,
    //     //     Description = category.Description
    //     // };
    //     _db.Categories.Add(cat);
    //     _db.SaveChanges();
    //     return Ok();
    // }
    // [HttpPut]
    // public IActionResult UpdateCategory(int id, Category category)
    // {
    //     Category? cat = _db.Categories.Find(id);
    //     if(cat == null)
    //     {
    //         return NotFound($"id {id} not found");
    //     }
    //     cat.CategoryName = category.CategoryName;
    //     cat.Description = category.Description;
    //     _db.SaveChanges();
    //     return Ok(cat);
    // }
    // [HttpDelete]
    // public IActionResult RemoveDataCategory(int id)
    // {
    //     Category? cat = _db.Categories.Find(id);
    //     if(cat == null)
    //     {
    //         return NotFound($"id {id} not found");
    //     }
    //     _db.Categories.Remove(cat);
    //     _db.SaveChanges();
    //     return Ok(cat);
    // }
}