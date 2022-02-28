using UnrealBuildTool;

public class 내프로젝트2Target : TargetRules
{
	public 내프로젝트2Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("내프로젝트2");
	}
}
