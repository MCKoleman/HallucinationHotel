// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class HallucinationHotel : ModuleRules
{
	public HallucinationHotel(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
	}
}
