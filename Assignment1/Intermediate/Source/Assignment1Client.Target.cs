using UnrealBuildTool;

public class Assignment1ClientTarget : TargetRules
{
	public Assignment1ClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Assignment1");
	}
}
