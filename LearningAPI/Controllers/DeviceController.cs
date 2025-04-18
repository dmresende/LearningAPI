using Microsoft.AspNetCore.Mvc;

namespace LearningAPI.Controllers;

public class DeviceController : LearningApiBaseController
{
    [HttpGet]
    public IActionResult get()
    {
        return Ok(Author);
    }
}
