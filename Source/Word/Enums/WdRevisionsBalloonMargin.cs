﻿using System;
using NetOffice;
using NetOffice.Attributes;
namespace NetOffice.WordApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Word 10, 11, 12, 14, 15, 16
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: <see href="https://docs.microsoft.com/en-us/office/vba/api/Word.WdRevisionsBalloonMargin"/> </remarks>
	[SupportByVersion("Word", 10,11,12,14,15,16)]
	[EntityType(EntityType.IsEnum)]
	public enum WdRevisionsBalloonMargin
	{
		 /// <summary>
		 /// SupportByVersion Word 10, 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersion("Word", 10,11,12,14,15,16)]
		 wdLeftMargin = 0,

		 /// <summary>
		 /// SupportByVersion Word 10, 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersion("Word", 10,11,12,14,15,16)]
		 wdRightMargin = 1
	}
}