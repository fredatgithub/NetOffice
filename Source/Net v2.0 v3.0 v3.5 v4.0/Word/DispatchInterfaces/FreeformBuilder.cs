//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.WordApi
{
	///<summary>
	/// DispatchInterface FreeformBuilder SupportByLibraryAttribute Word, 9,10,11,12,14
	///</summary>
	[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
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
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.WordApi.Application newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Application.LateBindingApiWrapperType) as NetOffice.WordApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public Int32 Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
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
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="SegmentType">NetOffice.OfficeApi.Enums.MsoSegmentType SegmentType</param>
		/// <param name="EditingType">NetOffice.OfficeApi.Enums.MsoEditingType EditingType</param>
		/// <param name="X1">Single X1</param>
		/// <param name="Y1">Single Y1</param>
		/// <param name="X2">Single X2</param>
		/// <param name="Y2">Single Y2</param>
		/// <param name="X3">Single X3</param>
		/// <param name="Y3">Single Y3</param>
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public void AddNodes(NetOffice.OfficeApi.Enums.MsoSegmentType segmentType, NetOffice.OfficeApi.Enums.MsoEditingType editingType, Single x1, Single y1, Single x2, Single y2, Single x3, Single y3)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(segmentType, editingType, x1, y1, x2, y2, x3, y3);
			Invoker.Method(this, "AddNodes", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Anchor">optional object Anchor</param>
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Shape ConvertToShape(object anchor)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(anchor);
			object returnItem = Invoker.MethodReturn(this, "ConvertToShape", paramsArray);
			NetOffice.WordApi.Shape newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.Shape.LateBindingApiWrapperType) as NetOffice.WordApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Shape ConvertToShape()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "ConvertToShape", paramsArray);
			NetOffice.WordApi.Shape newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.Shape.LateBindingApiWrapperType) as NetOffice.WordApi.Shape;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}