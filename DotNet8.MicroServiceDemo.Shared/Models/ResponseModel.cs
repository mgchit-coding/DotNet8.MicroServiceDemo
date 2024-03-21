namespace DotNet8.MicroServiceDemo.Shared.Models;

public class ResponseModel
{
    public ResponseModel(bool isSuccess, Error error)
    {
        IsSuccess = isSuccess;
        Error = error;
    }

    public bool IsSuccess { get; }
    public bool IsFailure => !IsSuccess;
    public Error Error;
    public static ResponseModel Success(Error error) => new(true, error);
    public static ResponseModel Failure(Error error) => new(false, error);
}

public record Error(string Code, string? Description= null);