using FoundationBackend.ApiCore.Errors;

using Microsoft.AspNetCore.Http;

namespace FoundationBackend.ApiCore.Results;

public class Result<T> : Result
{
    public T? Data { get; private set; }

    protected Result() {}

    public static Result<T> Ok(T data)
    {
        return new Result<T>
        {
            Success = true,
            Data = data,
            StatusCode = StatusCodes.Status200OK
        };
    }

    public static Result<T> Ok(T data, string message)
    {
        return new Result<T>
        {
            Success = true,
            Data = data,
            Message = message,
            StatusCode = StatusCodes.Status200OK
        };
    }

    public static Result<T> Created(T data)
    {
        return new Result<T>
        {
            Success = true,
            Data = data,
            StatusCode = StatusCodes.Status201Created
        };
    }

    public static Result<T> Created(T data, string message)
    {
        return new Result<T>
        {
            Success = true,
            Data = data,
            Message = message,
            StatusCode = StatusCodes.Status201Created
        };
    }

    public static Result<T> BadRequest(T data, ErrorCode codeError)
    {
        return new Result<T>
        {
            Success = false,
            Data = data,
            CodeError = codeError,
            StatusCode = StatusCodes.Status400BadRequest
        };
    }

    public static Result<T> BadRequest(T data, ErrorCode codeError, string error)
    {
        return new Result<T>
        {
            Success = false,
            Data = data,
            CodeError = codeError,
            Errors = [error],
            StatusCode = StatusCodes.Status400BadRequest
        };
    }

    public static Result<T> BadRequest(T data, ErrorCode codeError, List<string> errors)
    {
        return new Result<T>
        {
            Success = false,
            Data = data,
            CodeError = codeError,
            Errors = [.. errors],
            StatusCode = StatusCodes.Status400BadRequest
        };
    }
}
