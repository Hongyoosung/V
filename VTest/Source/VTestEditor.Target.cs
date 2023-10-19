// Copyright 2022, Infima Games. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class VTestEditorTarget : TargetRules
{
	public VTestEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V4;

		ExtraModuleNames.AddRange( new string[] { "VTest" } );
	}
}
