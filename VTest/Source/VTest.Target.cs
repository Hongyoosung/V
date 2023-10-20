// Copyright 2022, Infima Games. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class VTestTarget : TargetRules
{
	public VTestTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V4;

		ExtraModuleNames.AddRange( new string[] { "VTest" } );
	}
}
