using BooksStore.Shared.Core.Extension;
using System.ComponentModel.DataAnnotations;

namespace BooksStore.Shared.Core.Data;
public class SaveChangeResult
{
    public SaveChangeResult()
    {
        IsSuccess = true;
        Message = ResultType.GetDisplayName();
        ResultType = SaveChangesResultType.Success;
    }

    public SaveChangeResult(SaveChangesResultType resultType)
    {
        IsSuccess = resultType switch
        {
            SaveChangesResultType.Success => true,
            _ => false
        };
        ResultType = resultType;
        Message = resultType.GetDisplayName();
    }

    public SaveChangeResult(SaveChangesResultType resultType, string message) : this(resultType)
    {
        Message = message;
    }

    public bool IsSuccess { get; set; }
    public string Message { get; set; }
    public SaveChangesResultType ResultType { get; set; }
}





public enum SaveChangesResultType : byte
{
    [Display(Name = "Success")]
    Success = 1,
    [Display(Name = "UpdateException")]
    UpdateException = 2,
    [Display(Name = "UpdateConcurrencyException")]
    UpdateConcurrencyException = 3,
}

