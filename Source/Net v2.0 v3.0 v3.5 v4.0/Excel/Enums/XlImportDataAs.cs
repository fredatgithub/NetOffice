//Generated by LateBindingApi.CodeGenerator
using System;
using LateBindingApi.Core;
namespace NetOffice.ExcelApi.Enums
{
	 /// <summary>
	 /// SupportByLibrary Excel 10, 11, 12, 14
	 /// </summary>
	[SupportByLibraryAttribute("Excel", 10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum XlImportDataAs
	{
		 /// <summary>
		 /// SupportByLibrary Excel 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByLibraryAttribute("Excel", 10,11,12,14)]
		 xlQueryTable = 0,

		 /// <summary>
		 /// SupportByLibrary Excel 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByLibraryAttribute("Excel", 10,11,12,14)]
		 xlPivotTableReport = 1,

		 /// <summary>
		 /// SupportByLibrary Excel 12, 14
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByLibraryAttribute("Excel", 12,14)]
		 xlTable = 2
	}
}