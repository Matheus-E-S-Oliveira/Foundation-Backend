using FoundationBackend.ApiCore.Errors;

using Microsoft.AspNetCore.Http;

namespace FoundationBackend.ApiCore.Exceptions.Api.Types;

public class ValidationException(string message) : BaseApiException(ErrorRegistry.Api.API_VALIDATION, StatusCodes.Status400BadRequest, message)
{
}
