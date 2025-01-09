using System.Text.Json;
using Microsoft.Extensions.Logging;

public class SimpleFunctionLogging(ILogger<SimpleFunctionLogging> logger): ISimpleFunction
{
    public void Handler(SampleFunctionInput input)
    {
        logger.LogInformation("Sample Function Logging Handler");

        logger.LogCritical("Input Message: {Message}", JsonSerializer.Serialize(input));
        logger.LogInformation("Input Message: {Message}", JsonSerializer.Serialize(input));

        logger.LogInformation("Hello {Name}, you are {Age} years old", input.Name, input.Age);
    
        logger.LogWarning("Processing message START: {Message}", input.Message);
        // System.Threading.Thread.Sleep(500);
        logger.LogWarning("Processing message ENDED: {Message}", input.Message);

        var ex = new Exception("Sample Exception");
        logger.LogError("Sample Function Logging Handler Ended with {Exception}", ex);
    }
}


public record SampleFunctionInput(string Message, string Name, int Age, DateTime DateOfBirth);

public interface ISimpleFunction
{
    void Handler(SampleFunctionInput input);
}