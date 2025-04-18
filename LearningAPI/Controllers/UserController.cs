using LearningAPI.Comunication.Requests;
using LearningAPI.Comunication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace LearningAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult GetById([FromRoute] int id)
    {
        var respoonse = new User
        {
            Id= id,
            Age = 25,
            Name = "John Doe"
        };

        return Ok(respoonse);
    }

    [HttpPost]
    [ProducesResponseType(typeof(RequestRegisterUserJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult Create([FromBody] RequestRegisterUserJson request)
    {
        var response = new ResponseRegisteredUserJson
        {
            Id = 1,
            Name ="MyName"
        };


        return Created(string.Empty, response);
    }
}
