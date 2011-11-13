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
	/// DispatchInterface XMLNode SupportByLibraryAttribute Word, 11,12,14
	///</summary>
	[SupportByLibraryAttribute("Word", 11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class XMLNode : COMObject
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
                    _type = typeof(XMLNode);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XMLNode(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XMLNode(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XMLNode(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XMLNode() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XMLNode(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 11,12,14)]
		public string BaseName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BaseName", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 11,12,14)]
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
		/// SupportByLibrary Word 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 11,12,14)]
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
		/// SupportByLibrary Word 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 11,12,14)]
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

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 11,12,14)]
		public NetOffice.WordApi.Range Range
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Range", paramsArray);
				NetOffice.WordApi.Range newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Range.LateBindingApiWrapperType) as NetOffice.WordApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Word", 11,12,14)]
		public string Text
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Text", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Text", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 11,12,14)]
		public string NamespaceURI
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NamespaceURI", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// Get
		/// </summary>
		/// <param name="DataOnly">bool DataOnly</param>
		[SupportByLibraryAttribute("Word", 11,12,14)]
		public string get_XML(bool dataOnly)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dataOnly);
			object returnItem = Invoker.PropertyGet(this, "XML", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 11,12,14)]
		public NetOffice.WordApi.XMLNode NextSibling
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NextSibling", paramsArray);
				NetOffice.WordApi.XMLNode newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.XMLNode.LateBindingApiWrapperType) as NetOffice.WordApi.XMLNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 11,12,14)]
		public NetOffice.WordApi.XMLNode PreviousSibling
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PreviousSibling", paramsArray);
				NetOffice.WordApi.XMLNode newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.XMLNode.LateBindingApiWrapperType) as NetOffice.WordApi.XMLNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 11,12,14)]
		public NetOffice.WordApi.XMLNode ParentNode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ParentNode", paramsArray);
				NetOffice.WordApi.XMLNode newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.XMLNode.LateBindingApiWrapperType) as NetOffice.WordApi.XMLNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 11,12,14)]
		public NetOffice.WordApi.XMLNode FirstChild
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FirstChild", paramsArray);
				NetOffice.WordApi.XMLNode newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.XMLNode.LateBindingApiWrapperType) as NetOffice.WordApi.XMLNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 11,12,14)]
		public NetOffice.WordApi.XMLNode LastChild
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LastChild", paramsArray);
				NetOffice.WordApi.XMLNode newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.XMLNode.LateBindingApiWrapperType) as NetOffice.WordApi.XMLNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 11,12,14)]
		public NetOffice.WordApi.Document OwnerDocument
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OwnerDocument", paramsArray);
				NetOffice.WordApi.Document newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.Document.LateBindingApiWrapperType) as NetOffice.WordApi.Document;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 11,12,14)]
		public NetOffice.WordApi.Enums.WdXMLNodeType NodeType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NodeType", paramsArray);
				return (NetOffice.WordApi.Enums.WdXMLNodeType)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 11,12,14)]
		public NetOffice.WordApi.XMLNodes ChildNodes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ChildNodes", paramsArray);
				NetOffice.WordApi.XMLNodes newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.XMLNodes.LateBindingApiWrapperType) as NetOffice.WordApi.XMLNodes;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 11,12,14)]
		public NetOffice.WordApi.XMLNodes Attributes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Attributes", paramsArray);
				NetOffice.WordApi.XMLNodes newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.XMLNodes.LateBindingApiWrapperType) as NetOffice.WordApi.XMLNodes;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Word", 11,12,14)]
		public string NodeValue
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NodeValue", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NodeValue", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 11,12,14)]
		public bool HasChildNodes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HasChildNodes", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 11,12,14)]
		public NetOffice.WordApi.XMLChildNodeSuggestions ChildNodeSuggestions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ChildNodeSuggestions", paramsArray);
				NetOffice.WordApi.XMLChildNodeSuggestions newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.XMLChildNodeSuggestions.LateBindingApiWrapperType) as NetOffice.WordApi.XMLChildNodeSuggestions;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 11,12,14)]
		public NetOffice.WordApi.Enums.WdXMLNodeLevel Level
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Level", paramsArray);
				return (NetOffice.WordApi.Enums.WdXMLNodeLevel)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 11,12,14)]
		public NetOffice.WordApi.Enums.WdXMLValidationStatus ValidationStatus
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ValidationStatus", paramsArray);
				return (NetOffice.WordApi.Enums.WdXMLValidationStatus)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 11,12,14)]
		public NetOffice.WordApi.SmartTag SmartTag
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SmartTag", paramsArray);
				NetOffice.WordApi.SmartTag newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.WordApi.SmartTag.LateBindingApiWrapperType) as NetOffice.WordApi.SmartTag;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// Get
		/// </summary>
		/// <param name="Advanced">bool Advanced</param>
		[SupportByLibraryAttribute("Word", 11,12,14)]
		public string get_ValidationErrorText(bool advanced)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(advanced);
			object returnItem = Invoker.PropertyGet(this, "ValidationErrorText", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Word", 11,12,14)]
		public string PlaceholderText
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PlaceholderText", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PlaceholderText", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Word 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 12,14)]
		public string WordOpenXML
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "WordOpenXML", paramsArray);
				return (string)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// </summary>
		/// <param name="XPath">string XPath</param>
		/// <param name="PrefixMapping">string PrefixMapping</param>
		/// <param name="FastSearchSkippingTextNodes">bool FastSearchSkippingTextNodes</param>
		[SupportByLibraryAttribute("Word", 11,12,14)]
		public NetOffice.WordApi.XMLNode SelectSingleNode(string xPath, string prefixMapping, bool fastSearchSkippingTextNodes)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(xPath, prefixMapping, fastSearchSkippingTextNodes);
			object returnItem = Invoker.MethodReturn(this, "SelectSingleNode", paramsArray);
			NetOffice.WordApi.XMLNode newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.XMLNode.LateBindingApiWrapperType) as NetOffice.WordApi.XMLNode;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// </summary>
		/// <param name="XPath">string XPath</param>
		/// <param name="PrefixMapping">string PrefixMapping</param>
		/// <param name="FastSearchSkippingTextNodes">bool FastSearchSkippingTextNodes</param>
		[SupportByLibraryAttribute("Word", 11,12,14)]
		public NetOffice.WordApi.XMLNodes SelectNodes(string xPath, string prefixMapping, bool fastSearchSkippingTextNodes)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(xPath, prefixMapping, fastSearchSkippingTextNodes);
			object returnItem = Invoker.MethodReturn(this, "SelectNodes", paramsArray);
			NetOffice.WordApi.XMLNodes newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.XMLNodes.LateBindingApiWrapperType) as NetOffice.WordApi.XMLNodes;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Word", 11,12,14)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Word", 11,12,14)]
		public void Copy()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Copy", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// </summary>
		/// <param name="ChildElement">NetOffice.WordApi.XMLNode ChildElement</param>
		[SupportByLibraryAttribute("Word", 11,12,14)]
		public void RemoveChild(NetOffice.WordApi.XMLNode childElement)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(childElement);
			Invoker.Method(this, "RemoveChild", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Word", 11,12,14)]
		public void Cut()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Cut", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// </summary>
		[SupportByLibraryAttribute("Word", 11,12,14)]
		public void Validate()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Validate", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 11, 12, 14
		/// </summary>
		/// <param name="Status">NetOffice.WordApi.Enums.WdXMLValidationStatus Status</param>
		/// <param name="ErrorText">object ErrorText</param>
		/// <param name="ClearedAutomatically">bool ClearedAutomatically</param>
		[SupportByLibraryAttribute("Word", 11,12,14)]
		public void SetValidationError(NetOffice.WordApi.Enums.WdXMLValidationStatus status, object errorText, bool clearedAutomatically)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(status, errorText, clearedAutomatically);
			Invoker.Method(this, "SetValidationError", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}