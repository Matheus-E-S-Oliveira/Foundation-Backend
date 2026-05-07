namespace FoundationBackend.ApiCore.Errors.Api;

public sealed class ApiErrorCodes
{
    public static readonly ErrorCode API_CONFLICT = new("API_CONFLICT");

    public static readonly ErrorCode API_FORBIDDEN = new("API_FORBIDDEN");

    public static readonly ErrorCode API_NOT_FOUND = new("API_NOT_FOUND");

    public static readonly ErrorCode API_UNAUTHORIZED = new("API_UNAUTHORIZED");

    public static readonly ErrorCode API_VALIDATION = new("API_VALIDATION");
}
