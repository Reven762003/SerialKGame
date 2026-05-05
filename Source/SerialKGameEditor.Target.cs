using UnrealBuildTool;
using System.Collections.Generic;

public class SerialKGameEditorTarget : TargetRules
{
	public SerialKGameEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V4;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_4;
		ExtraModuleNames.Add("SerialKGame");
	}
}
