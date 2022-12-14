using Resources = Pulumi.AzureNative.Resources;
using Storage = Pulumi.AzureNative.Storage;

using Pulumi.AzureNative.Storage.Inputs;

namespace ArkInit.Azure;

public static class ArkInitializer
{
    public static void CheckConfig()
    {
        var config = new Pulumi.Config();

        //var location = config.Require("azure-native:location");
        //Console.WriteLine($"The location was:{location}");
    }

    public static Tuple<Resources.ResourceGroup, Storage.StorageAccount> CreateStorage(string groupName, string  stAccountName)
    {
        var resourceGroup = new Resources.ResourceGroup(groupName);
        var storageAccount = new Storage.StorageAccount(stAccountName, new()
        {
            ResourceGroupName = resourceGroup.Name,
            Sku = new SkuArgs
            {
                Name = Storage.SkuName.Standard_LRS
            },
            Kind = Storage.Kind.StorageV2
        });

        return Tuple.Create(resourceGroup, storageAccount);
    }
    public static Dictionary<string, object?> Start()
    {
        // Check Config before start
        CheckConfig();

        // Init exports variable
        var exports = new Dictionary<string, object?>();

        // Create RG & Storage Account for Pulumi State
        var (rg, st) = CreateStorage(groupName: "rg-pulumi-", stAccountName: "stpulumistate");
        exports.Add("pulumi-resourcegroup",rg);
        exports.Add("pulumi-storage", st);

        // Create RG & Storage Account for Pulumi State
        var (rg1, st1) = CreateStorage(groupName: "rg-ark-", stAccountName: "starklogs");

        exports.Add("ark-resourcegroup", rg);
        exports.Add("ark-storage", st);


        return exports;
    }

}
