namespace ArkInit.Azure;

public static class AzureInitializer
{
    public static Dictionary<string, object?> DoStuff()
    {
        var exports = new Dictionary<string, object?>();


        return exports;
    }

    public static bool CheckConfig()
    {
        var configOK = false;

        var config = new Pulumi.Config();
        var location = config.Require("location");
        Console.WriteLine($"The location was:{location}");
        return configOK;
    }
}
