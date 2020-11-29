﻿using System;
using NetOffice;
using NetOffice.Attributes;
namespace NetOffice.PowerPointApi.Enums
{
	 /// <summary>
	 /// SupportByVersion PowerPoint 15,16
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: <see href="https://docs.microsoft.com/en-us/office/vba/api/PowerPoint.xlcategorylabellevel"/> </remarks>
	[SupportByVersion("PowerPoint", 15, 16)]
	[EntityType(EntityType.IsEnum)]
	public enum XlCategoryLabelLevel
	{
		 /// <summary>
		 /// SupportByVersion PowerPoint 15,16
		 /// </summary>
		 /// <remarks>-3</remarks>
		 [SupportByVersion("PowerPoint", 15, 16)]
		 xlCategoryLabelLevelNone = -3,

		 /// <summary>
		 /// SupportByVersion PowerPoint 15,16
		 /// </summary>
		 /// <remarks>-2</remarks>
		 [SupportByVersion("PowerPoint", 15, 16)]
		 xlCategoryLabelLevelCustom = -2,

		 /// <summary>
		 /// SupportByVersion PowerPoint 15,16
		 /// </summary>
		 /// <remarks>-1</remarks>
		 [SupportByVersion("PowerPoint", 15, 16)]
		 xlCategoryLabelLevelAll = -1
	}
}