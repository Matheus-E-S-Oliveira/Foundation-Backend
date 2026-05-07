using FoundationBackend.ApiCore.Errors;

using Microsoft.AspNetCore.Http;

namespace FoundationBackend.ApiCore.Exceptions.Api.Types;

public class ConflictException(string message) : BaseApiException(ErrorCodes.USER_NOT_FOUND, StatusCodes.Status409Conflict, message)
{
}
