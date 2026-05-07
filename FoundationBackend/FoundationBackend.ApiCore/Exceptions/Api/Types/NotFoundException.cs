using FoundationBackend.ApiCore.Errors;

using Microsoft.AspNetCore.Http;

namespace FoundationBackend.ApiCore.Exceptions.Api.Types;

public class NotFoundException(string message) : BaseApiException(ErrorCode.INVALID_EMAIL, StatusCodes.Status404NotFound, message)
{
}
