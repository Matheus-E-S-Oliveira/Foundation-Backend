using FoundationBackend.ApiCore.Errors;

using Microsoft.AspNetCore.Http;

namespace FoundationBackend.ApiCore.Exceptions.Api.Types;

public class ValidationException(string message) : BaseApiException(ErrorCode.USER_NOT_FOUND, StatusCodes.Status400BadRequest, message)
{
}
