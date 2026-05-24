using Microsoft.AspNetCore.Mvc;

namespace UserReportService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    [HttpGet]
    public IActionResult GetUsers()
    {
        var users = new[]
        {
            new
            {
                Id = 1,
                Name = "Admin",
                Role = "Manager"
            },

            new
            {
                Id = 2,
                Name = "Nguyen Van A",
                Role = "Staff"
            }
        };

        return Ok(users);
    }
}