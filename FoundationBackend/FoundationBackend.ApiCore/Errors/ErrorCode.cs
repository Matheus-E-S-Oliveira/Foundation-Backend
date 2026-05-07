// Documentation:
// https://www.notion.so/ErrorCode-cs-359559c6ace9800e850fea4a1611931f

namespace FoundationBackend.ApiCore.Errors;

public sealed class ErrorCode(string code)
{
    public string Code { get; } = code;
}
