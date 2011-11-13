//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.MSComctlLibApi
{
	///<summary>
	/// DispatchInterface IComboItems SupportByLibraryAttribute MSComctlLib, 6
	///</summary>
	[SupportByLibraryAttribute("MSComctlLib", 6)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class IComboItems : COMObject ,IEnumerable
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
                    _type = typeof(IComboItems);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IComboItems(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IComboItems(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IComboItems(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IComboItems() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IComboItems(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// Get/Set
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibraryAttribute("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.IComboItem get__CollectionDefault(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "_CollectionDefault", paramsArray);
			NetOffice.MSComctlLibApi.IComboItem newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSComctlLibApi.IComboItem;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// Get/Set
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibraryAttribute("MSComctlLib", 6)]
		public void set__CollectionDefault(object index, NetOffice.MSComctlLibApi.IComboItem value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			Invoker.PropertySet(this, "_CollectionDefault", paramsArray, value);
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSComctlLib", 6)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Count", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// Get/Set
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibraryAttribute("MSComctlLib", 6)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.MSComctlLibApi.IComboItem this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.MSComctlLibApi.IComboItem newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSComctlLibApi.IComboItem;
			return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		/// <param name="Index">optional object Index</param>
		/// <param name="Key">optional object Key</param>
		/// <param name="Text">optional object Text</param>
		/// <param name="Image">optional object Image</param>
		/// <param name="SelImage">optional object SelImage</param>
		/// <param name="Indentation">optional object Indentation</param>
		[SupportByLibraryAttribute("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.IComboItem Add(object index, object key, object text, object image, object selImage, object indentation)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index, key, text, image, selImage, indentation);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.MSComctlLibApi.IComboItem newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSComctlLibApi.IComboItem;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.IComboItem Add()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.MSComctlLibApi.IComboItem newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSComctlLibApi.IComboItem;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		/// <param name="Index">optional object Index</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.IComboItem Add(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.MSComctlLibApi.IComboItem newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSComctlLibApi.IComboItem;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		/// <param name="Index">optional object Index</param>
		/// <param name="Key">optional object Key</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.IComboItem Add(object index, object key)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index, key);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.MSComctlLibApi.IComboItem newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSComctlLibApi.IComboItem;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		/// <param name="Index">optional object Index</param>
		/// <param name="Key">optional object Key</param>
		/// <param name="Text">optional object Text</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.IComboItem Add(object index, object key, object text)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index, key, text);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.MSComctlLibApi.IComboItem newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSComctlLibApi.IComboItem;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		/// <param name="Index">optional object Index</param>
		/// <param name="Key">optional object Key</param>
		/// <param name="Text">optional object Text</param>
		/// <param name="Image">optional object Image</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.IComboItem Add(object index, object key, object text, object image)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index, key, text, image);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.MSComctlLibApi.IComboItem newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSComctlLibApi.IComboItem;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		/// <param name="Index">optional object Index</param>
		/// <param name="Key">optional object Key</param>
		/// <param name="Text">optional object Text</param>
		/// <param name="Image">optional object Image</param>
		/// <param name="SelImage">optional object SelImage</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("MSComctlLib", 6)]
		public NetOffice.MSComctlLibApi.IComboItem Add(object index, object key, object text, object image, object selImage)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index, key, text, image, selImage);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.MSComctlLibApi.IComboItem newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSComctlLibApi.IComboItem;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		[SupportByLibraryAttribute("MSComctlLib", 6)]
		public void Clear()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Clear", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSComctlLib 6
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibraryAttribute("MSComctlLib", 6)]
		public void Remove(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			Invoker.Method(this, "Remove", paramsArray);
		}

		#endregion
   
        #region IEnumerable Members
        
		/// <summary>
		/// SupportByLibraryAttribute MSComctlLib, 6
		/// </summary>
		[SupportByLibraryAttribute("MSComctlLib", 6)]
		public IEnumerator GetEnumerator()
		{
			object enumProxy = Invoker.MethodReturn(this, "_NewEnum");
			COMObject enumerator = new COMObject(this, enumProxy, true);
			Invoker.Method(enumerator, "Reset", null);
			bool isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
            while (true == isMoveNextTrue)
            {
                object itemProxy = Invoker.PropertyGet(enumerator, "Current", null);
                COMObject returnClass = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, itemProxy);
                isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
				yield return returnClass;
            }
        }

        #endregion
		#pragma warning restore
	}
}