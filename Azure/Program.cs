
using ArkInit.Azure;


return await Pulumi.Deployment.RunAsync(() =>
{
    AzureInitializer.CheckConfig();
});
