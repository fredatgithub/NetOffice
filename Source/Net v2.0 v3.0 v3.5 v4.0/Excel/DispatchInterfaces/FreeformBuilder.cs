//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// DispatchInterface FreeformBuilder SupportByLibraryAttribute Excel, 9,10,11,12,14
	///</summary>
	[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class FreeformBuilder : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(FreeformBuilder);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FreeformBuilder(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FreeformBuilder(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FreeformBuilder(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FreeformBuilder() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public FreeformBuilder(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.ExcelApi.Application newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.Application.LateBindingApiWrapperType) as NetOffice.ExcelApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (NetOffice.ExcelApi.Enums.XlCreator)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="SegmentType">NetOffice.OfficeApi.Enums.MsoSegmentType SegmentType</param>
		/// <param name="EditingType">NetOffice.OfficeApi.Enums.MsoEditingType EditingType</param>
		/// <param name="X1">Single X1</param>
		/// <param name="Y1">Single Y1</param>
		/// <param name="X2">optional object X2</param>
		/// <param name="Y2">optional object Y2</param>
		/// <param name="X3">optional object X3</param>
		/// <param name="Y3">optional object Y3</param>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public void AddNodes(NetOffice.OfficeApi.Enums.MsoSegmentType segmentType, NetOffice.OfficeApi.Enums.MsoEditingType editingType, Single x1, Single y1, object x2, object y2, object x3, object y3)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(segmentType, editingType, x1, y1, x2, y2, x3, y3);
			Invoker.Method(this, "AddNodes", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="SegmentType">NetOffice.OfficeApi.Enums.MsoSegmentType SegmentType</param>
		/// <param name="EditingType">NetOffice.OfficeApi.Enums.MsoEditingType EditingType</param>
		/// <param name="X1">Single X1</param>
		/// <param name="Y1">Single Y1</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public void AddNodes(NetOffice.OfficeApi.Enums.MsoSegmentType segmentType, NetOffice.OfficeApi.Enums.MsoEditingType editingType, Single x1, Single y1)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(segmentType, editingType, x1, y1);
			Invoker.Method(this, "AddNodes", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="SegmentType">NetOffice.OfficeApi.Enums.MsoSegmentType SegmentType</param>
		/// <param name="EditingType">NetOffice.OfficeApi.Enums.MsoEditingType EditingType</param>
		/// <param name="X1">Single X1</param>
		/// <param name="Y1">Single Y1</param>
		/// <param name="X2">optional object X2</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public void AddNodes(NetOffice.OfficeApi.Enums.MsoSegmentType segmentType, NetOffice.OfficeApi.Enums.MsoEditingType editingType, Single x1, Single y1, object x2)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(segmentType, editingType, x1, y1, x2);
			Invoker.Method(this, "AddNodes", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="SegmentType">NetOffice.OfficeApi.Enums.MsoSegmentType SegmentType</param>
		/// <param name="EditingType">NetOffice.OfficeApi.Enums.MsoEditingType EditingType</param>
		/// <param name="X1">Single X1</param>
		/// <param name="Y1">Single Y1</param>
		/// <param name="X2">optional object X2</param>
		/// <param name="Y2">optional object Y2</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public void AddNodes(NetOffice.OfficeApi.Enums.MsoSegmentType segmentType, NetOffice.OfficeApi.Enums.MsoEditingType editingType, Single x1, Single y1, object x2, object y2)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(segmentType, editingType, x1, y1, x2, y2);
			Invoker.Method(this, "AddNodes", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="SegmentType">NetOffice.OfficeApi.Enums.MsoSegmentType SegmentType</param>
		/// <param name="EditingType">NetOffice.OfficeApi.Enums.MsoEditingType EditingType</param>
		/// <param name="X1">Single X1</param>
		/// <param name="Y1">Single Y1</param>
		/// <param name="X2">optional object X2</param>
		/// <param name="Y2">optional object Y2</param>
		/// <param name="X3">optional object X3</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public void AddNodes(NetOffice.OfficeApi.Enums.MsoSegmentType segmentType, NetOffice.OfficeApi.Enums.MsoEditingType editingType, Single x1, Single y1, object x2, object y2, object x3)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(segmentType, editingType, x1, y1, x2, y2, x3);
			Invoker.Method(this, "AddNodes", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Excel 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Excel", 9,10,11,12,14)]
		public NetOffice.ExcelApi.Shape ConvertToShape()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "ConvertToShape", paramsArray);
			NetOffice.ExcelApi.Shape newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.ExcelApi.Shape.LateBindingApiWrapperType) as NetOffice.ExcelApi.Shape;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}