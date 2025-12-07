using UnrealBuildTool;

public class ProjectWhiteWoodServerTarget : TargetRules
{
	public ProjectWhiteWoodServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("ProjectWhiteWood");
	}
}
