// Copyright Arcsettle Contributors
using UnrealBuildTool;
using System.Collections.Generic;

public class ArcsettleTarget : TargetRules
{
    public ArcsettleTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Game;
        DefaultBuildSettings = BuildSettingsVersion.V5;
        IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_4;
        ExtraModuleNames.AddRange(new string[] { "Arcsettle" });
    }
}
