// Documentation:
// https://www.notion.so/UnauthorizedException-cs-359559c6ace980bba535e447b429a920
using FoundationBackend.ApiCore.Errors;

using Microsoft.AspNetCore.Http;

namespace FoundationBackend.ApiCore.Exceptions.Api.Types;

public class UnauthorizedException(string message) : BaseApiException(ErrorRegistry.Api.API_UNAUTHORIZED, StatusCodes.Status401Unauthorized, message)
{
}
