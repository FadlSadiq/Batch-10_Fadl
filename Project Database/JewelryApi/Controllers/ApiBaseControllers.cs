using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class ApiBaseController : ControllerBase
{
    protected readonly MyDatabase db;
    public ApiBaseController(MyDatabase database)
    {
        db = database;
    }
}