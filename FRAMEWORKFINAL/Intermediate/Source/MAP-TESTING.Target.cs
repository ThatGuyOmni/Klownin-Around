using UnrealBuildTool;

public class MAP-TESTINGTarget : TargetRules
{
	public MAP-TESTINGTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("MAP-TESTING");
	}
}
