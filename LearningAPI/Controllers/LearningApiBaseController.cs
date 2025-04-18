using Microsoft.AspNetCore.Mvc;

namespace LearningAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class LearningApiBaseController : ControllerBase
{
    public string  Author { get; set; } = "MyName";
}
