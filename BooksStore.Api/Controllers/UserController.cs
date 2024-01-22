namespace BooksStore.Api.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class UserController(IUserService userService) : ControllerBase
{
    private readonly IUserService _userService = userService;

    [HttpGet]
    public async Task<IActionResult> GetAllUsers()
        => Ok(await _userService.GetAll());

    [HttpPost]
    public async Task<IActionResult> Add(User user, CancellationToken ct)
        => Ok(await _userService.Add(user, ct));
}
