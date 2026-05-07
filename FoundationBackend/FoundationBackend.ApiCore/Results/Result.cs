// Documentation:
// https://www.notion.so/Result-cs-357559c6ace9807b914ff3b22bc9dab1

using FoundationBackend.ApiCore.Errors;

using Microsoft.AspNetCore.Http;

namespace FoundationBackend.ApiCore.Results;

public class Result
{
    public bool Success { get; protected set; }

    public string Message { get; protected set; } = string.Empty;

    public int StatusCode { get; protected set; }

    public ErrorCodes? CodeError { get; protected set; }

    public IReadOnlyList<string> Errors { get; protected set; } = [];

    protected Result() { }

    #region HTTP 200 - Ok
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
    #endregion

    #region HTTP 201 - Created
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
    #endregion

    #region HTTP 204 - NoContent
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
    #endregion

    #region HTTP 400 - BadRequest
    public static Result BadRequest(ErrorCodes codeError)
    {
        return new Result
        {
            Success = false,
            CodeError = codeError,
            StatusCode = StatusCodes.Status400BadRequest
        };
    }

    public static Result BadRequest(ErrorCodes codeError, string error)
    {
        return new Result
        {
            Success = false,
            CodeError = codeError,
            Errors = [error],
            StatusCode = StatusCodes.Status400BadRequest
        };
    }

    public static Result BadRequest(ErrorCodes codeError, List<string> errors)
    {
        return new Result
        {
            Success = false,
            CodeError = codeError,
            Errors = [.. errors],
            StatusCode = StatusCodes.Status400BadRequest
        };
    }
    #endregion

    #region HTTP 401 - Unauthorized
    public static Result Unauthorized(ErrorCodes codeError)
    {
        return new Result
        {
            Success = false,
            CodeError = codeError,
            StatusCode = StatusCodes.Status401Unauthorized
        };
    }

    public static Result Unauthorized(ErrorCodes codeError, string error)
    {
        return new Result
        {
            Success = false,
            CodeError = codeError,
            Errors = [error],
            StatusCode = StatusCodes.Status401Unauthorized
        };
    }

    public static Result Unauthorized(ErrorCodes codeError, List<string> errors)
    {
        return new Result
        {
            Success = false,
            CodeError = codeError,
            Errors = [.. errors],
            StatusCode = StatusCodes.Status401Unauthorized
        };
    }
    #endregion

    #region HTTP 403 - Forbidden
    public static Result Forbidden(ErrorCodes codeError)
    {
        return new Result
        {
            Success = false,
            CodeError = codeError,
            StatusCode = StatusCodes.Status403Forbidden
        };
    }

    public static Result Forbidden(ErrorCodes codeError, string error)
    {
        return new Result
        {
            Success = false,
            CodeError = codeError,
            Errors = [error],
            StatusCode = StatusCodes.Status403Forbidden
        };
    }

    public static Result Forbidden(ErrorCodes codeError, List<string> errors)
    {
        return new Result
        {
            Success = false,
            CodeError = codeError,
            Errors = [.. errors],
            StatusCode = StatusCodes.Status403Forbidden
        };
    }
    #endregion

    #region HTTP 404 - NotFound
    public static Result NotFound(ErrorCodes codeError)
    {
        return new Result
        {
            Success = false,
            CodeError = codeError,
            StatusCode = StatusCodes.Status404NotFound
        };
    }

    public static Result NotFound(ErrorCodes codeError, string error)
    {
        return new Result
        {
            Success = false,
            CodeError = codeError,
            Errors = [error],
            StatusCode = StatusCodes.Status404NotFound
        };
    }

    public static Result NotFound(ErrorCodes codeError, List<string> errors)
    {
        return new Result
        {
            Success = false,
            CodeError = codeError,
            Errors = [.. errors],
            StatusCode = StatusCodes.Status404NotFound
        };
    }
    #endregion

    #region HTTP 409 - Conflit
    public static Result Conflict(ErrorCodes codeError)
    {
        return new Result
        {
            Success = false,
            CodeError = codeError,
            StatusCode = StatusCodes.Status409Conflict
        };
    }

    public static Result Conflict(ErrorCodes codeError, string error)
    {
        return new Result
        {
            Success = false,
            CodeError = codeError,
            Errors = [error],
            StatusCode = StatusCodes.Status409Conflict
        };
    }

    public static Result Conflict(ErrorCodes codeError, List<string> errors)
    {
        return new Result
        {
            Success = false,
            CodeError = codeError,
            Errors = [.. errors],
            StatusCode = StatusCodes.Status409Conflict
        };
    }
    #endregion

    #region HTTP 500 - InternalServerError
    public static Result InternalServerError(ErrorCodes codeError, string message)
    {
        return new Result
        {
            Success = false,
            CodeError = codeError,
            Message = message,
            StatusCode = StatusCodes.Status500InternalServerError
        };
    }

    public static Result InternalServerError(ErrorCodes codeError, string message, string error)
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
    #endregion

    #region HTTP 501 - NotImplemented
    public static Result NotImplemented(ErrorCodes codeError, string message)
    {
        return new Result
        {
            Success = false,
            CodeError = codeError,
            Message = message,
            StatusCode = StatusCodes.Status501NotImplemented
        };
    }
    #endregion
}
