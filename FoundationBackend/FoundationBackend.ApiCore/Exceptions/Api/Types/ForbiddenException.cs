// Documentation:
// https://www.notion.so/ForbiddenException-cs-359559c6ace9803c9c88f5adc5b01e5b

using FoundationBackend.ApiCore.Errors;

using Microsoft.AspNetCore.Http;

namespace FoundationBackend.ApiCore.Exceptions.Api.Types;

public class ForbiddenException(string message) : BaseApiException(ErrorRegistry.Api.API_FORBIDDEN, StatusCodes.Status403Forbidden, message)
{
}
