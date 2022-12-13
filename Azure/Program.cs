
using ArkInit.Azure;


return await Pulumi.Deployment.RunAsync(() =>
{
    return ArkInitializer.Start();
});
