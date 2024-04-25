using UnrealBuildTool;

public class Supermarket_ScrambleTarget : TargetRules
{
	public Supermarket_ScrambleTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Supermarket_Scramble");
	}
}
