using FoundationBackend.ApiCore.Errors;

using Microsoft.AspNetCore.Http;

namespace FoundationBackend.ApiCore.Exceptions.Api.Types;

public class UnauthorizedException(string message) : BaseApiException(ErrorRegistry.Api.API_UNAUTHORIZED, StatusCodes.Status401Unauthorized, message)
{
}
