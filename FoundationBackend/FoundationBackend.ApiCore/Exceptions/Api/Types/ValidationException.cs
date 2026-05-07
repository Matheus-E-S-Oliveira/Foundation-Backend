// Documentation:
// https://www.notion.so/ValidationException-cs-359559c6ace980a0ae44dcf477a36e86

using FoundationBackend.ApiCore.Errors;

using Microsoft.AspNetCore.Http;

namespace FoundationBackend.ApiCore.Exceptions.Api.Types;

public class ValidationException(string message) : BaseApiException(ErrorRegistry.Api.API_VALIDATION, StatusCodes.Status400BadRequest, message)
{
}
