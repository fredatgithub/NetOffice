//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.MSHTMLApi
{
	///<summary>
	/// Interface IHTMLEditServices SupportByLibraryAttribute MSHTML, 4
	///</summary>
	[SupportByLibraryAttribute("MSHTML", 4)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class IHTMLEditServices : COMObject
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
                    _type = typeof(IHTMLEditServices);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLEditServices(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLEditServices(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLEditServices(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLEditServices() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLEditServices(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pIDesigner">LateBindingApi.MSHTMLApi.IHTMLEditDesigner pIDesigner</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 AddDesigner(LateBindingApi.MSHTMLApi.IHTMLEditDesigner pIDesigner)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pIDesigner);
			object returnItem = Invoker.MethodReturn(this, "AddDesigner", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pIDesigner">LateBindingApi.MSHTMLApi.IHTMLEditDesigner pIDesigner</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 RemoveDesigner(LateBindingApi.MSHTMLApi.IHTMLEditDesigner pIDesigner)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pIDesigner);
			object returnItem = Invoker.MethodReturn(this, "RemoveDesigner", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pIContainer">LateBindingApi.MSHTMLApi.IMarkupContainer pIContainer</param>
		/// <param name="ppSelSvc">LateBindingApi.MSHTMLApi.ISelectionServices ppSelSvc</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 GetSelectionServices(LateBindingApi.MSHTMLApi.IMarkupContainer pIContainer, LateBindingApi.MSHTMLApi.ISelectionServices ppSelSvc)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pIContainer, ppSelSvc);
			object returnItem = Invoker.MethodReturn(this, "GetSelectionServices", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pIStartAnchor">LateBindingApi.MSHTMLApi.IMarkupPointer pIStartAnchor</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 MoveToSelectionAnchor(LateBindingApi.MSHTMLApi.IMarkupPointer pIStartAnchor)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pIStartAnchor);
			object returnItem = Invoker.MethodReturn(this, "MoveToSelectionAnchor", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pIEndAnchor">LateBindingApi.MSHTMLApi.IMarkupPointer pIEndAnchor</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 MoveToSelectionEnd(LateBindingApi.MSHTMLApi.IMarkupPointer pIEndAnchor)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pIEndAnchor);
			object returnItem = Invoker.MethodReturn(this, "MoveToSelectionEnd", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pStart">LateBindingApi.MSHTMLApi.IMarkupPointer pStart</param>
		/// <param name="pEnd">LateBindingApi.MSHTMLApi.IMarkupPointer pEnd</param>
		/// <param name="eType">LateBindingApi.MSHTMLApi.Enums._SELECTION_TYPE eType</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 SelectRange(LateBindingApi.MSHTMLApi.IMarkupPointer pStart, LateBindingApi.MSHTMLApi.IMarkupPointer pEnd, LateBindingApi.MSHTMLApi.Enums._SELECTION_TYPE eType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pStart, pEnd, eType);
			object returnItem = Invoker.MethodReturn(this, "SelectRange", paramsArray);
			return (Int32)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}