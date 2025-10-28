using UnrealBuildTool;

public class Assignment1ServerTarget : TargetRules
{
	public Assignment1ServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Assignment1");
	}
}
