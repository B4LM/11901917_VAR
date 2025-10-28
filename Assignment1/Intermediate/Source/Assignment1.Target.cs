using UnrealBuildTool;

public class Assignment1Target : TargetRules
{
	public Assignment1Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Assignment1");
	}
}
