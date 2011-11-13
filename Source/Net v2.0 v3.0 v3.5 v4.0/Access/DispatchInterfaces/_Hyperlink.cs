//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.AccessApi
{
	///<summary>
	/// DispatchInterface _Hyperlink SupportByLibraryAttribute Access, 9,10,11,12,14
	///</summary>
	[SupportByLibraryAttribute("Access", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _Hyperlink : COMObject
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
                    _type = typeof(_Hyperlink);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Hyperlink(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Hyperlink(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Hyperlink(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Hyperlink() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Hyperlink(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Access", 9,10,11,12,14)]
		public string SubAddress
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SubAddress", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SubAddress", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Access", 9,10,11,12,14)]
		public string Address
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Address", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Address", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Access", 9,10,11,12,14)]
		public string EmailSubject
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EmailSubject", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "EmailSubject", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Access", 9,10,11,12,14)]
		public string ScreenTip
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ScreenTip", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ScreenTip", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Access", 9,10,11,12,14)]
		public string TextToDisplay
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TextToDisplay", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TextToDisplay", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Access", 9,10,11,12,14)]
		public void AddToFavorites()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "AddToFavorites", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="NewWindow">bool NewWindow</param>
		/// <param name="AddHistory">bool AddHistory</param>
		/// <param name="ExtraInfo">object ExtraInfo</param>
		/// <param name="Method">NetOffice.OfficeApi.Enums.MsoExtraInfoMethod Method</param>
		/// <param name="HeaderInfo">string HeaderInfo</param>
		[SupportByLibraryAttribute("Access", 9,10,11,12,14)]
		public void Follow(bool newWindow, bool addHistory, object extraInfo, NetOffice.OfficeApi.Enums.MsoExtraInfoMethod method, string headerInfo)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(newWindow, addHistory, extraInfo, method, headerInfo);
			Invoker.Method(this, "Follow", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Access 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="FileName">string FileName</param>
		/// <param name="EditNow">bool EditNow</param>
		/// <param name="Overwrite">bool Overwrite</param>
		[SupportByLibraryAttribute("Access", 9,10,11,12,14)]
		public void CreateNewDocument(string fileName, bool editNow, bool overwrite)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, editNow, overwrite);
			Invoker.Method(this, "CreateNewDocument", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Access 11, 12, 14
		/// </summary>
		/// <param name="dispid">Int32 dispid</param>
		[SupportByLibraryAttribute("Access", 11,12,14)]
		public bool IsMemberSafe(Int32 dispid)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dispid);
			object returnItem = Invoker.MethodReturn(this, "IsMemberSafe", paramsArray);
			return (bool)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}