using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

public class CategoryController : ApiBaseController
{
    private readonly BrandModule _brandModule;
    public CategoryController(MyDatabase db, BrandModule brandModule) : base(db)
    {
        _brandModule = brandModule;
    }
    [HttpGet]
    public IActionResult GetCategory()
    {
        return Ok(_brandModule.Get());
    }

    [HttpPost]
    public IActionResult PostCategory(Brand brand)
    {
        bool status = _brandModule.Create(brand);
        if (status)
        {
            return Ok(brand);
        }
        return BadRequest();
    }
}