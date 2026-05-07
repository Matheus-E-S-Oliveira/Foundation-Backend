using FoundationBackend.ApiCore.Errors;

using Microsoft.AspNetCore.Http;

namespace FoundationBackend.ApiCore.Exceptions.Api.Types;

public class UnauthorizedException(string message) : BaseApiException(ErrorCode.PERMISSION_DENIED, StatusCodes.Status401Unauthorized, message)
{
}
