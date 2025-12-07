using UnrealBuildTool;

public class ProjectWhiteWoodClientTarget : TargetRules
{
	public ProjectWhiteWoodClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("ProjectWhiteWood");
	}
}
