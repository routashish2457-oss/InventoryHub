[ApiController]
[Route("api/[controller]")]
public class InventoryController : ControllerBase
{
    [HttpGet]
    public IActionResult GetItems()
    {
        var items = new[] {
            new { Id = 1, Name = "Laptop", Quantity = 10 },
            new { Id = 2, Name = "Mouse", Quantity = 25 }
        };
        return Ok(items);
    }
}
