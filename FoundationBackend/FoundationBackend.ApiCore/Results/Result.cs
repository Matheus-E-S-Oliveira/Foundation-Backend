using FoundationBackend.ApiCore.Errors;

using Microsoft.AspNetCore.Http;

namespace FoundationBackend.ApiCore.Results;

public class Result
{
    public bool Success { get; protected set; }

    public string Message { get; protected set; } = string.Empty;

    public int StatusCode { get; protected set; }

    public ErrorCode? CodeError { get; protected set; }

    public IReadOnlyList<string> Errors { get; protected set; } = [];

    protected Result() { }

    public static Result Ok()
    {
        return new Result
        {
            Success = true,
            StatusCode = StatusCodes.Status200OK
        };
    }

    public static Result Ok(string message)
    {
        return new Result
        {
            Success = true,
            Message = message,
            StatusCode = StatusCodes.Status200OK
        };
    }

    public static Result Created()
    {
        return new Result
        {
            Success = true,
            StatusCode = StatusCodes.Status201Created
        };
    }

    public static Result Created(string message)
    {
        return new Result
        {
            Success = true,
            Message = message,
            StatusCode = StatusCodes.Status201Created
        };
    }

    public static Result NoContent()
    {
        return new Result
        {
            Success = true,
            StatusCode = StatusCodes.Status204NoContent
        };
    }

    public static Result NoContent(string message)
    {
        return new Result
        {
            Success = true,
            Message = message,
            StatusCode = StatusCodes.Status204NoContent
        };
    }

    public static Result BadRequest(ErrorCode codeError)
    {
        return new Result
        {
            Success = false,
            CodeError = codeError,
            StatusCode = StatusCodes.Status400BadRequest
        };
    }

    public static Result BadRequest(ErrorCode codeError, string error)
    {
        return new Result
        {
            Success = false,
            CodeError = codeError,
            Errors = [error],
            StatusCode = StatusCodes.Status400BadRequest
        };
    }

    public static Result BadRequest(ErrorCode codeError, List<string> errors)
    {
        return new Result
        {
            Success = false,
            CodeError = codeError,
            Errors = [.. errors],
            StatusCode = StatusCodes.Status400BadRequest
        };
    }

    public static Result Unauthorized(ErrorCode codeError)
    {
        return new Result
        {
            Success = false,
            CodeError = codeError,
            StatusCode = StatusCodes.Status401Unauthorized
        };
    }

    public static Result Unauthorized(ErrorCode codeError, string error)
    {
        return new Result
        {
            Success = false,
            CodeError = codeError,
            Errors = [error],
            StatusCode = StatusCodes.Status401Unauthorized
        };
    }

    public static Result Unauthorized(ErrorCode codeError, List<string> errors)
    {
        return new Result
        {
            Success = false,
            CodeError = codeError,
            Errors = [.. errors],
            StatusCode = StatusCodes.Status401Unauthorized
        };
    }

    public static Result Forbidden(ErrorCode codeError)
    {
        return new Result
        {
            Success = false,
            CodeError = codeError,
            StatusCode = StatusCodes.Status403Forbidden
        };
    }

    public static Result Forbidden(ErrorCode codeError, string error)
    {
        return new Result
        {
            Success = false,
            CodeError = codeError,
            Errors = [error],
            StatusCode = StatusCodes.Status403Forbidden
        };
    }

    public static Result Forbidden(ErrorCode codeError, List<string> errors)
    {
        return new Result
        {
            Success = false,
            CodeError = codeError,
            Errors = [.. errors],
            StatusCode = StatusCodes.Status403Forbidden
        };
    }

    public static Result NotFound(ErrorCode codeError)
    {
        return new Result
        {
            Success = false,
            CodeError = codeError,
            StatusCode = StatusCodes.Status404NotFound
        };
    }

    public static Result NotFound(ErrorCode codeError, string error)
    {
        return new Result
        {
            Success = false,
            CodeError = codeError,
            Errors = [error],
            StatusCode = StatusCodes.Status404NotFound
        };
    }

    public static Result NotFound(ErrorCode codeError, List<string> errors)
    {
        return new Result
        {
            Success = false,
            CodeError = codeError,
            Errors = [.. errors],
            StatusCode = StatusCodes.Status404NotFound
        };
    }

    public static Result Conflict(ErrorCode codeError)
    {
        return new Result
        {
            Success = false,
            CodeError = codeError,
            StatusCode = StatusCodes.Status409Conflict
        };
    }

    public static Result Conflict(ErrorCode codeError, string error)
    {
        return new Result
        {
            Success = false,
            CodeError = codeError,
            Errors = [error],
            StatusCode = StatusCodes.Status409Conflict
        };
    }

    public static Result Conflict(ErrorCode codeError, List<string> errors)
    {
        return new Result
        {
            Success = false,
            CodeError = codeError,
            Errors = [.. errors],
            StatusCode = StatusCodes.Status409Conflict
        };
    }

    public static Result InternalServerError(ErrorCode codeError, string message)
    {
        return new Result
        {
            Success = false,
            CodeError = codeError,
            Message = message,
            StatusCode = StatusCodes.Status500InternalServerError
        };
    }

    public static Result InternalServerError(ErrorCode codeError, string message, string error)
    {
        return new Result
        {
            Success = false,
            CodeError = codeError,
            Message = message,
            Errors = [error],
            StatusCode = StatusCodes.Status500InternalServerError
        };
    }

    public static Result NotImplemented(ErrorCode codeError, string message)
    {
        return new Result
        {
            Success = false,
            CodeError = codeError,
            Message = message,
            StatusCode = StatusCodes.Status501NotImplemented
        };
    }
}
