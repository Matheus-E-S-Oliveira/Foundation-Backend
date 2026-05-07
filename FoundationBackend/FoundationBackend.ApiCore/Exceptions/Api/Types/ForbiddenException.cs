using FoundationBackend.ApiCore.Errors;

using Microsoft.AspNetCore.Http;

namespace FoundationBackend.ApiCore.Exceptions.Api.Types;

public class ForbiddenException(string message) : BaseApiException(ErrorRegistry.Api.API_FORBIDDEN, StatusCodes.Status403Forbidden, message)
{
}
