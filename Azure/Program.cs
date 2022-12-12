
using ArkInit.Azure;


return await Pulumi.Deployment.RunAsync(() =>
{
    ArkInitializer.Start();
});
