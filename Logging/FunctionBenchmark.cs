enum Colors { Red, Green, Blue }

public class FunctionBenchmark(ISimpleFunction simpleFunction)
{

    public void Execute(int iterations)
    {
        for (int i = 0; i < iterations; i++)
        {
            simpleFunction.Handler(new SampleFunctionInput("Message Sample with no meaning", "John Doe", 30, DateTime.Today));
        }
    }
}