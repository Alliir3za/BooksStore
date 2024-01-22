using BooksStore.Data.AppContext;
using BookStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;

var _db = new BookDbContext();
//var result1 = _db.Books.Where(x => x.BookId > 2).ToList();

var res = _db.Users
    .AsSplitQuery()
    .FirstOrDefault(x => x.Age < 30);


var result2 = _db.Books
    .Include(x => x.User)
    .Where(x => x.Price > 1500)
    .Select(x => new
    {
        x.BookName,
        x.Genre,
        x.Price,
        x.Description,
        User = new
        {
            x.User.FirstName,
            x.User.LastName,
            x.User.Age,
            x.UserId
        }
    }).ToList();

Console.WriteLine(res);
Console.WriteLine(result2);