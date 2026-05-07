// Documentation:
// https://www.notion.so/ErrorCode-cs-357559c6ace980949af4f18f3773bd35

using FoundationBackend.ApiCore.Errors.Api;

namespace FoundationBackend.ApiCore.Errors;

public static class ErrorCodes
{
    public static ApiErrorCodes Api { get; } = new();
}
