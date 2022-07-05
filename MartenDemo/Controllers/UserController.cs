using MartenDemo.Entities;
using MartenDemo.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MartenDemo.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser([FromBody] User user)
    {
        await _userService.CreateUserAsync(user);
        return Ok();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetUser([FromRoute] Guid id) 
        => Ok(await _userService.GetSingleUserAsync(id));

    [HttpGet]
    public async Task<IActionResult> GetUsers() 
        => Ok(await _userService.GetAllUsersAsync());
}