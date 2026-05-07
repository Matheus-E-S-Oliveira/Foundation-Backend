using FoundationBackend.ApiCore.Errors;

using Microsoft.AspNetCore.Http;

namespace FoundationBackend.ApiCore.Exceptions.Api.Types;

public class ForbiddenException(string message) : BaseApiException(ErrorCode.PERMISSION_DENIED, StatusCodes.Status403Forbidden, message)
{
}
