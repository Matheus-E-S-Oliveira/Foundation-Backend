// Documentation:
// https://www.notion.so/ResultOfT-cs-357559c6ace98042a716f4940b941e86

using FoundationBackend.ApiCore.Errors;

using Microsoft.AspNetCore.Http;

namespace FoundationBackend.ApiCore.Results;

public class Result<T> : Result
{
    public T? Data { get; private set; }

    protected Result() {}

    #region HTTP 200 - Ok
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
    #endregion

    #region HTTP 201 - Created
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
    #endregion

    #region HTTP 400 - BadRequest
    public static Result<T> BadRequest(T data, ErrorRegistry codeError)
    {
        return new Result<T>
        {
            Success = false,
            Data = data,
            CodeError = codeError,
            StatusCode = StatusCodes.Status400BadRequest
        };
    }

    public static Result<T> BadRequest(T data, ErrorRegistry codeError, string error)
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

    public static Result<T> BadRequest(T data, ErrorRegistry codeError, List<string> errors)
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
    #endregion
}
