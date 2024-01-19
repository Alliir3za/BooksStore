using BooksStore.Shared;
using BookStore.Domain.Dto;
using BookStore.Domain.Entities;

namespace BookStore.Services;
public interface IUserService
{
    Task<IActionResponse<object>> Add(User user, CancellationToken ct);
    Task<IActionResponse<UserDto>> GetAll();
    Task<IActionResponse<object>> Update(User user, CancellationToken ct);
    Task<IActionResponse<bool>> Delete(int userId, CancellationToken ct);
}
