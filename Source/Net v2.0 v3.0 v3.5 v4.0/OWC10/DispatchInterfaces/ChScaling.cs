//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OWC10Api
{
	///<summary>
	/// DispatchInterface ChScaling SupportByLibraryAttribute OWC10, 1
	///</summary>
	[SupportByLibraryAttribute("OWC10", 1)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class ChScaling : COMObject
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
                    _type = typeof(ChScaling);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChScaling(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChScaling(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChScaling(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChScaling() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChScaling(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public bool HasAutoMaximum
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HasAutoMaximum", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HasAutoMaximum", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public bool HasAutoMinimum
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HasAutoMinimum", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HasAutoMinimum", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public bool HasSplit
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HasSplit", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HasSplit", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public Double LogBase
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LogBase", paramsArray);
				return (Double)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LogBase", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public Double Maximum
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Maximum", paramsArray);
				return (Double)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Maximum", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public Double Minimum
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Minimum", paramsArray);
				return (Double)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Minimum", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.Enums.ChartScaleOrientationEnum Orientation
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Orientation", paramsArray);
				return (NetOffice.OWC10Api.Enums.ChartScaleOrientationEnum)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Orientation", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.Enums.ChartScaleTypeEnum Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				return (NetOffice.OWC10Api.Enums.ChartScaleTypeEnum)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Type", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public Double SplitMaximum
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SplitMaximum", paramsArray);
				return (Double)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SplitMaximum", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public Double SplitMinimum
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SplitMinimum", paramsArray);
				return (Double)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SplitMinimum", paramsArray);
			}
		}

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}