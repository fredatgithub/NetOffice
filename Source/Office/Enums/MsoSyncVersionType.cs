﻿using System;
using NetOffice;
using NetOffice.Attributes;
namespace NetOffice.OfficeApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Office 11, 12, 14, 15, 16
	 /// </summary>
	 ///<remarks> MSDN Online Documentation: <see href="https://docs.microsoft.com/en-us/office/vba/api/Office.MsoSyncVersionType"/> </remarks>
	[SupportByVersion("Office", 11,12,14,15,16)]
	[EntityType(EntityType.IsEnum)]
	public enum MsoSyncVersionType
	{
		 /// <summary>
		 /// SupportByVersion Office 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersion("Office", 11,12,14,15,16)]
		 msoSyncVersionLastViewed = 0,

		 /// <summary>
		 /// SupportByVersion Office 11, 12, 14, 15, 16
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersion("Office", 11,12,14,15,16)]
		 msoSyncVersionServer = 1
	}
}