// Documentation:
// https://www.notion.so/ApiErrorCodes-cs-359559c6ace98024abc3eba73dc71670

namespace FoundationBackend.ApiCore.Errors.Api;

public sealed class ApiErrorCodes
{
    public ErrorCode API_CONFLICT { get; } = new("API_CONFLICT");

    public ErrorCode API_FORBIDDEN { get; } = new("API_FORBIDDEN");

    public ErrorCode API_NOT_FOUND { get; } = new("API_NOT_FOUND");

    public ErrorCode API_UNAUTHORIZED { get; } = new("API_UNAUTHORIZED");

    public ErrorCode API_VALIDATION { get; } = new("API_VALIDATION");
}
