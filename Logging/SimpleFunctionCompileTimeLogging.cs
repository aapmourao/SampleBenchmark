using System.Text.Json;
using Microsoft.Extensions.Logging;

public class SimpleFunctionCompileTimeLogging(ILogger<SimpleFunctionLogging> logger): ISimpleFunction
{
    public void Handler(SampleFunctionInput input)
    {
        logger.InfoSampleFunctionLoggingHandler();

        logger.CritInputMessage(JsonSerializer.Serialize(input));
        logger.InfoInputMessage(JsonSerializer.Serialize(input));

        logger.LogInformation("Hello {Name}, you are {Age} years old", input.Name, input.Age);
    
        logger.WarnProcessingMessageStart(input.Message);
        // System.Threading.Thread.Sleep(500);
        logger.WarnProcessingMessageEnded(input.Message);

        var ex = new Exception("Sample Exception");
        logger.ErrorSampleFunctionLoggingHandlerEndedWithException(ex);
    }
}

public static partial class LoggingExtensions
{
    // Tip: Messages have prefix with type of log message (Debug, Info, Warn, Error) and the text message with the `Message` suffix
    internal const string SampleFunctionLoggingHandlerMessage = "Sample Function Logging Handler";
    internal const string InputMessageMessage = "Input Message: {Message}";
    internal const string ProcessingMessageStartMessage = "Processing message START: {Message}";
    internal const string ProcessingMessageEndedMessage = "Processing message ENDED: {Message}";
    internal const string SampleFunctionLoggingHandlerEndedWithExceptionMessage = "Sample Function Logging Handler Ended with {Exception}";

    // Tip: Methods have prefix with type of log message (Debug, Info, Warn, Error) and the text message
    [LoggerMessage(EventId = 3201, Level = LogLevel.Information, Message = SampleFunctionLoggingHandlerMessage)]
    public static partial void InfoSampleFunctionLoggingHandler(this ILogger logger);

    [LoggerMessage(EventId = 3202, Level = LogLevel.Critical, Message = InputMessageMessage)]
    public static partial void CritInputMessage(this ILogger logger, string message);

    [LoggerMessage(EventId = 3203, Level = LogLevel.Information, Message = InputMessageMessage)]
    public static partial void InfoInputMessage(this ILogger logger, string message);

    [LoggerMessage(EventId = 3204, Level = LogLevel.Warning, Message = ProcessingMessageStartMessage)]
    public static partial void WarnProcessingMessageStart(this ILogger logger, string message);

    [LoggerMessage(EventId = 3205, Level = LogLevel.Warning, Message = ProcessingMessageEndedMessage)]
    public static partial void WarnProcessingMessageEnded(this ILogger logger, string message);

    [LoggerMessage(EventId = 3206, Level = LogLevel.Error, Message = SampleFunctionLoggingHandlerEndedWithExceptionMessage)]
    public static partial void ErrorSampleFunctionLoggingHandlerEndedWithException(this ILogger logger, Exception exception);
}