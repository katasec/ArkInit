namespace ArkInit.Azure;

public static class ArkInitializer
{
    public static void CheckConfig()
    {
        var config = new Pulumi.Config();

        var location = config.Require("location");
        Console.WriteLine($"The location was:{location}");
    }

    public static Dictionary<string, object?> Start()
    {
        var exports = new Dictionary<string, object?>();

        // Check Config before start
        CheckConfig();

        return exports;
    }

}
