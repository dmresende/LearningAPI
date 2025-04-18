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

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromBody] RequestUpdatedUserJson request)
    {
        var response = new RequestUpdatedUserJson
        {
            Name = "MyName"
        };
        return NoContent();
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete()
    {
        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<User>), StatusCodes.Status200OK)]
    public IActionResult GelAll()
    {
        var response = new List<User>
        {
            new User{Id =1, Age =7, Name = "John Doe"},
            new User{Id =2, Age =9, Name = "Maria"},
            new User{Id =3, Age =8, Name = "Joana"},
        };
        return Ok(response);
    }

    [HttpPut("change-password")]
    [ProducesResponseType(typeof(RequestChangePasswordJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult ChangePassword( [FromBody] RequestChangePasswordJson request)
    {
        return NoContent();
    }

}
