using BookStore.Domain.Entities;
using BookStore.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;

namespace BooksStore.Api.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
        => _userService = userService;


    [HttpGet]
    public async Task<IActionResult> GetAllUsers()
        => Ok(await _userService.GetAll());

    [HttpPost]
    public async Task<IActionResult> Add(User user, CancellationToken ct)
        => Ok(await _userService.Add(user, ct));
}
