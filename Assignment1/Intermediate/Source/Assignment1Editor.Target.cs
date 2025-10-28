using UnrealBuildTool;

public class Assignment1EditorTarget : TargetRules
{
	public Assignment1EditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Assignment1");
	}
}
