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
	/// DispatchInterface IHTMLTxtRange SupportByLibraryAttribute MSHTML, 4
	///</summary>
	[SupportByLibraryAttribute("MSHTML", 4)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class IHTMLTxtRange : COMObject
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
                    _type = typeof(IHTMLTxtRange);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLTxtRange(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLTxtRange(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLTxtRange(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLTxtRange() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLTxtRange(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public string htmlText
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "htmlText", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public string text
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "text", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "text", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLElement parentElement()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "parentElement", paramsArray);
			LateBindingApi.MSHTMLApi.IHTMLElement newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLElement;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLTxtRange duplicate()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "duplicate", paramsArray);
			LateBindingApi.MSHTMLApi.IHTMLTxtRange newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,LateBindingApi.MSHTMLApi.IHTMLTxtRange.LateBindingApiWrapperType) as LateBindingApi.MSHTMLApi.IHTMLTxtRange;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="range">LateBindingApi.MSHTMLApi.IHTMLTxtRange range</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool inRange(LateBindingApi.MSHTMLApi.IHTMLTxtRange range)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range);
			object returnItem = Invoker.MethodReturn(this, "inRange", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="range">LateBindingApi.MSHTMLApi.IHTMLTxtRange range</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool isEqual(LateBindingApi.MSHTMLApi.IHTMLTxtRange range)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range);
			object returnItem = Invoker.MethodReturn(this, "isEqual", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="fStart">bool fStart</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void scrollIntoView(bool fStart)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fStart);
			Invoker.Method(this, "scrollIntoView", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="Start">bool Start</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void collapse(bool start)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(start);
			Invoker.Method(this, "collapse", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="Unit">string Unit</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool expand(string unit)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(unit);
			object returnItem = Invoker.MethodReturn(this, "expand", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="Unit">string Unit</param>
		/// <param name="Count">Int32 Count</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 move(string unit, Int32 count)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(unit, count);
			object returnItem = Invoker.MethodReturn(this, "move", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="Unit">string Unit</param>
		/// <param name="Count">Int32 Count</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 moveStart(string unit, Int32 count)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(unit, count);
			object returnItem = Invoker.MethodReturn(this, "moveStart", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="Unit">string Unit</param>
		/// <param name="Count">Int32 Count</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 moveEnd(string unit, Int32 count)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(unit, count);
			object returnItem = Invoker.MethodReturn(this, "moveEnd", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void select()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "select", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="html">string html</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void pasteHTML(string html)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(html);
			Invoker.Method(this, "pasteHTML", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="element">LateBindingApi.MSHTMLApi.IHTMLElement element</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void moveToElementText(LateBindingApi.MSHTMLApi.IHTMLElement element)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(element);
			Invoker.Method(this, "moveToElementText", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="how">string how</param>
		/// <param name="SourceRange">LateBindingApi.MSHTMLApi.IHTMLTxtRange SourceRange</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void setEndPoint(string how, LateBindingApi.MSHTMLApi.IHTMLTxtRange sourceRange)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(how, sourceRange);
			Invoker.Method(this, "setEndPoint", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="how">string how</param>
		/// <param name="SourceRange">LateBindingApi.MSHTMLApi.IHTMLTxtRange SourceRange</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 compareEndPoints(string how, LateBindingApi.MSHTMLApi.IHTMLTxtRange sourceRange)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(how, sourceRange);
			object returnItem = Invoker.MethodReturn(this, "compareEndPoints", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="String">string String</param>
		/// <param name="Count">Int32 Count</param>
		/// <param name="Flags">Int32 Flags</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool findText(string _string, Int32 count, Int32 flags)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(_string, count, flags);
			object returnItem = Invoker.MethodReturn(this, "findText", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void moveToPoint(Int32 x, Int32 y)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(x, y);
			Invoker.Method(this, "moveToPoint", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public string getBookmark()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "getBookmark", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="Bookmark">string Bookmark</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool moveToBookmark(string bookmark)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(bookmark);
			object returnItem = Invoker.MethodReturn(this, "moveToBookmark", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="cmdID">string cmdID</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool queryCommandSupported(string cmdID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(cmdID);
			object returnItem = Invoker.MethodReturn(this, "queryCommandSupported", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="cmdID">string cmdID</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool queryCommandEnabled(string cmdID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(cmdID);
			object returnItem = Invoker.MethodReturn(this, "queryCommandEnabled", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="cmdID">string cmdID</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool queryCommandState(string cmdID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(cmdID);
			object returnItem = Invoker.MethodReturn(this, "queryCommandState", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="cmdID">string cmdID</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool queryCommandIndeterm(string cmdID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(cmdID);
			object returnItem = Invoker.MethodReturn(this, "queryCommandIndeterm", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="cmdID">string cmdID</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public string queryCommandText(string cmdID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(cmdID);
			object returnItem = Invoker.MethodReturn(this, "queryCommandText", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="cmdID">string cmdID</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object queryCommandValue(string cmdID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(cmdID);
			object returnItem = Invoker.MethodReturn(this, "queryCommandValue", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="cmdID">string cmdID</param>
		/// <param name="showUI">bool showUI</param>
		/// <param name="value">optional object value</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool execCommand(string cmdID, bool showUI, object value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(cmdID, showUI, value);
			object returnItem = Invoker.MethodReturn(this, "execCommand", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="cmdID">string cmdID</param>
		/// <param name="showUI">bool showUI</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool execCommand(string cmdID, bool showUI)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(cmdID, showUI);
			object returnItem = Invoker.MethodReturn(this, "execCommand", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="cmdID">string cmdID</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool execCommandShowHelp(string cmdID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(cmdID);
			object returnItem = Invoker.MethodReturn(this, "execCommandShowHelp", paramsArray);
			return (bool)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}