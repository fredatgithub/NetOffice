﻿using System;
using NetOffice;
using NetOffice.Attributes;
namespace NetOffice.ExcelApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Excel 15,16
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: <see href="https://docs.microsoft.com/en-us/office/vba/api/Excel.xlslicercachetype"/> </remarks>
	[SupportByVersion("Excel", 15, 16)]
	[EntityType(EntityType.IsEnum)]
	public enum XlSlicerCacheType
	{
		 /// <summary>
		 /// SupportByVersion Excel 15,16
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersion("Excel", 15, 16)]
		 xlSlicer = 1,

		 /// <summary>
		 /// SupportByVersion Excel 15,16
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersion("Excel", 15, 16)]
		 xlTimeline = 2
	}
}