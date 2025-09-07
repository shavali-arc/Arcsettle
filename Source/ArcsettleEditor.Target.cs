// Copyright Arcsettle Contributors
using UnrealBuildTool;
using System.Collections.Generic;

public class ArcsettleEditorTarget : TargetRules
{
    public ArcsettleEditorTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Editor;
        DefaultBuildSettings = BuildSettingsVersion.V5;
        IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_4;
        ExtraModuleNames.AddRange(new string[] { "Arcsettle" });
    }
}
