//Generated by LateBindingApi.CodeGenerator
using System;
using LateBindingApi.Core;
namespace LateBindingApi.MSProjectApi.Enums
{
	 /// <summary>
	 /// SupportByLibrary MSProject 14
	 /// </summary>
	[SupportByLibraryAttribute("MSProject", 14)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum PjTaskWarnings
	{
		 /// <summary>
		 /// SupportByLibrary MSProject 14
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByLibraryAttribute("MSProject", 14)]
		 pjTaskWarningShadowFinishesLaterDueToLink = 1,

		 /// <summary>
		 /// SupportByLibrary MSProject 14
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByLibraryAttribute("MSProject", 14)]
		 pjTaskWarningShadowFinishesEarlierDueToLink = 2,

		 /// <summary>
		 /// SupportByLibrary MSProject 14
		 /// </summary>
		 /// <remarks>4</remarks>
		 [SupportByLibraryAttribute("MSProject", 14)]
		 pjTaskWarningSubTaskStartingBeforeParentStart = 4,

		 /// <summary>
		 /// SupportByLibrary MSProject 14
		 /// </summary>
		 /// <remarks>8</remarks>
		 [SupportByLibraryAttribute("MSProject", 14)]
		 pjTaskWarningSubTaskStartingAfterParentStart = 8,

		 /// <summary>
		 /// SupportByLibrary MSProject 14
		 /// </summary>
		 /// <remarks>16</remarks>
		 [SupportByLibraryAttribute("MSProject", 14)]
		 pjTaskWarningSubTaskFinishingAfterParentFinish = 16,

		 /// <summary>
		 /// SupportByLibrary MSProject 14
		 /// </summary>
		 /// <remarks>32</remarks>
		 [SupportByLibraryAttribute("MSProject", 14)]
		 pjTaskWarningSummaryInconsistentStart = 32,

		 /// <summary>
		 /// SupportByLibrary MSProject 14
		 /// </summary>
		 /// <remarks>64</remarks>
		 [SupportByLibraryAttribute("MSProject", 14)]
		 pjTaskWarningResourceBeyondMaxUnit = 64,

		 /// <summary>
		 /// SupportByLibrary MSProject 14
		 /// </summary>
		 /// <remarks>128</remarks>
		 [SupportByLibraryAttribute("MSProject", 14)]
		 pjTaskWarningResourceOverallocated = 128,

		 /// <summary>
		 /// SupportByLibrary MSProject 14
		 /// </summary>
		 /// <remarks>256</remarks>
		 [SupportByLibraryAttribute("MSProject", 14)]
		 pjTaskWarningShadowIncorrectByConstraintOnly = 256,

		 /// <summary>
		 /// SupportByLibrary MSProject 14
		 /// </summary>
		 /// <remarks>512</remarks>
		 [SupportByLibraryAttribute("MSProject", 14)]
		 pjTaskWarningShadowIncorrectByLevelingDelayOnly = 512,

		 /// <summary>
		 /// SupportByLibrary MSProject 14
		 /// </summary>
		 /// <remarks>1024</remarks>
		 [SupportByLibraryAttribute("MSProject", 14)]
		 pjTaskWarningShadowDateDifferent = 1024,

		 /// <summary>
		 /// SupportByLibrary MSProject 14
		 /// </summary>
		 /// <remarks>2048</remarks>
		 [SupportByLibraryAttribute("MSProject", 14)]
		 pjTaskWarningSummaryInconsistentFinish = 2048,

		 /// <summary>
		 /// SupportByLibrary MSProject 14
		 /// </summary>
		 /// <remarks>4096</remarks>
		 [SupportByLibraryAttribute("MSProject", 14)]
		 pjTaskWarningTaskStartingInNonWorkingTime = 4096,

		 /// <summary>
		 /// SupportByLibrary MSProject 14
		 /// </summary>
		 /// <remarks>8192</remarks>
		 [SupportByLibraryAttribute("MSProject", 14)]
		 pjTaskWarningTaskFinishingInNonWorkingTime = 8192,

		 /// <summary>
		 /// SupportByLibrary MSProject 14
		 /// </summary>
		 /// <remarks>16384</remarks>
		 [SupportByLibraryAttribute("MSProject", 14)]
		 pjTaskWarningAssnOverallocatedInNonWorkingTime = 16384
	}
}