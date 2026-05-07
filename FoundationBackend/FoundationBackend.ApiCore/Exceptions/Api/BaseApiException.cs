// Documentation:
// https://www.notion.so/BaseApiException-358559c6ace98054ba71edca585a9dd6

using FoundationBackend.ApiCore.Errors;

namespace FoundationBackend.ApiCore.Exceptions.Api;

public class BaseApiException : Exception
{
    public ErrorCode ErrorCode { get; private set; }

    public int StatusCode { get; private set; }

    protected BaseApiException(ErrorCode errorCode, int statusCode, string message) : base(message)
    {
        ErrorCode = errorCode;
        StatusCode = statusCode;
    }
}
