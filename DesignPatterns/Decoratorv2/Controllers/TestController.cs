using Decoratorv2.TestDbContextDirectory;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Decoratorv2.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TestController : ControllerBase
{
    [HttpGet("Test")]
    public IActionResult Get()
    {
        using var context = new TestDbContext();
        context.Users.Add(new UserEntity()
        {
            Id=1,
            FullName = "Batuhan Bedir"
        });
        return Ok();
    }
}
