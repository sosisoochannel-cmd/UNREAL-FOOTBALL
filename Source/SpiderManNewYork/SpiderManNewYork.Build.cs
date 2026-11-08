using UnrealBuildTool;

public class SpiderManNewYork : ModuleRules
{
    public SpiderManNewYork(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
        PublicDependencyModuleNames.AddRange(new string[]
        {
            "Core", "CoreUObject", "Engine", "InputCore"
        });
    }
}
