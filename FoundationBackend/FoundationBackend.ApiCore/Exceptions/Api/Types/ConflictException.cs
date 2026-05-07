// Documentation:
// https://www.notion.so/ConflictException-cs-359559c6ace98000bc1dcd8fba1ec742

using FoundationBackend.ApiCore.Errors;

using Microsoft.AspNetCore.Http;

namespace FoundationBackend.ApiCore.Exceptions.Api.Types;

public class ConflictException(string message) : BaseApiException(ErrorRegistry.Api.API_CONFLICT, StatusCodes.Status409Conflict, message)
{
}
