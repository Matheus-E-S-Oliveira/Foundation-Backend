namespace FoundationBackend.ApiCore.Errors;

public sealed class ErrorCode(string code)
{
    public string Code { get; } = code;
}
