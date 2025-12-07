using UnrealBuildTool;

public class ProjectWhiteWoodEditorTarget : TargetRules
{
	public ProjectWhiteWoodEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("ProjectWhiteWood");
	}
}
