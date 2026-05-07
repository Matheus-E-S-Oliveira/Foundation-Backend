using FoundationBackend.ApiCore.Errors;

using Microsoft.AspNetCore.Http;

namespace FoundationBackend.ApiCore.Exceptions.Api.Types;

public class NotFoundException(string message) : BaseApiException(ErrorRegistry.Api.API_NOT_FOUND, StatusCodes.Status404NotFound, message)
{
}
