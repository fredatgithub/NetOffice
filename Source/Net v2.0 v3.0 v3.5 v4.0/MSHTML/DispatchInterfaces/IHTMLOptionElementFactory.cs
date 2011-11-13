//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.MSHTMLApi
{
	///<summary>
	/// DispatchInterface IHTMLOptionElementFactory SupportByLibraryAttribute MSHTML, 4
	///</summary>
	[SupportByLibraryAttribute("MSHTML", 4)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class IHTMLOptionElementFactory : COMObject
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
                    _type = typeof(IHTMLOptionElementFactory);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLOptionElementFactory(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLOptionElementFactory(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLOptionElementFactory(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLOptionElementFactory() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLOptionElementFactory(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="text">optional object text</param>
		/// <param name="value">optional object value</param>
		/// <param name="defaultSelected">optional object defaultSelected</param>
		/// <param name="selected">optional object selected</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLOptionElement create(object text, object value, object defaultSelected, object selected)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(text, value, defaultSelected, selected);
			object returnItem = Invoker.MethodReturn(this, "create", paramsArray);
			LateBindingApi.MSHTMLApi.IHTMLOptionElement newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLOptionElement;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLOptionElement create()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "create", paramsArray);
			LateBindingApi.MSHTMLApi.IHTMLOptionElement newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLOptionElement;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="text">optional object text</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLOptionElement create(object text)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(text);
			object returnItem = Invoker.MethodReturn(this, "create", paramsArray);
			LateBindingApi.MSHTMLApi.IHTMLOptionElement newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLOptionElement;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="text">optional object text</param>
		/// <param name="value">optional object value</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLOptionElement create(object text, object value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(text, value);
			object returnItem = Invoker.MethodReturn(this, "create", paramsArray);
			LateBindingApi.MSHTMLApi.IHTMLOptionElement newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLOptionElement;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="text">optional object text</param>
		/// <param name="value">optional object value</param>
		/// <param name="defaultSelected">optional object defaultSelected</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLOptionElement create(object text, object value, object defaultSelected)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(text, value, defaultSelected);
			object returnItem = Invoker.MethodReturn(this, "create", paramsArray);
			LateBindingApi.MSHTMLApi.IHTMLOptionElement newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLOptionElement;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}