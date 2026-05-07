using FoundationBackend.ApiCore.Errors;

using Microsoft.AspNetCore.Http;

namespace FoundationBackend.ApiCore.Exceptions.Api.Types;

public class ConflictException(string message) : BaseApiException(ErrorRegistry.Api.API_CONFLICT, StatusCodes.Status409Conflict, message)
{
}
