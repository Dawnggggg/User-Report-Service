using Microsoft.AspNetCore.Mvc;

namespace WarehouseService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReportsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetReports()
    {
        var reports = new[]
        {
            new
            {
                TotalUsers = 120,
                TotalOrders = 450,
                Revenue = 150000
            }
        };

        return Ok(reports);
    }
}