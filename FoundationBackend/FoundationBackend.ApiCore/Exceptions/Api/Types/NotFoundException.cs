// Documentation:
// https://www.notion.so/NotFoundException-cs-359559c6ace98036b023cda38f6bed7e

using FoundationBackend.ApiCore.Errors;

using Microsoft.AspNetCore.Http;

namespace FoundationBackend.ApiCore.Exceptions.Api.Types;

public class NotFoundException(string message) : BaseApiException(ErrorRegistry.Api.API_NOT_FOUND, StatusCodes.Status404NotFound, message)
{
}
