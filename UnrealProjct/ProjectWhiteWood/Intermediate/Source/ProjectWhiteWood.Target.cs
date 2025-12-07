using UnrealBuildTool;

public class ProjectWhiteWoodTarget : TargetRules
{
	public ProjectWhiteWoodTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("ProjectWhiteWood");
	}
}
