namespace BookStore.Services.Implementation;

public class UserService : IUserService
{
    private readonly IAppUnitOfWork _uow;

    public UserService(IAppUnitOfWork uow) => _uow = uow;


    public async Task<IActionResponse<object>> Add(User user, CancellationToken ct)
    {
        User users = new()
        {
            FirstName = user.FirstName,
            LastName = user.LastName,
            Age = user.Age,
            Email = user.Email,
            Gender = user.Gender,
            PhoneNumber = user.PhoneNumber
        };

        await _uow.UserRepo.AddAsync(users, ct);
        var result = await _uow.SaveChangesAsync(ct);
        if (result is null)
            return new ActionResponse<object>(ActionResponseStatusCode.BadRequest, message: ServiceMessage.UserNotFound);
        return new ActionResponse<object>(result);
    }

    public Task<IActionResponse<bool>> Delete(int userId, CancellationToken ct)
    {
        throw new NotImplementedException();
    }

    public async Task<IActionResponse<UserDto>> GetAll()
    {
        var users = await _uow.UserRepo.ToListAsync();

        if (users is null)
            return new ActionResponse<UserDto>(ActionResponseStatusCode.BadRequest, message: ServiceMessage.UserNotFound);

        return new ActionResponse<UserDto>(users);
    }

    public Task<IActionResponse<object>> Update(User user, CancellationToken ct)
    {
        throw new NotImplementedException();
    }
}
