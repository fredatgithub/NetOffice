//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.OWC10Api
{
	///<summary>
	/// DispatchInterface GroupingDefs SupportByLibraryAttribute OWC10, 1
	///</summary>
	[SupportByLibraryAttribute("OWC10", 1)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class GroupingDefs : COMObject ,IEnumerable
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
                    _type = typeof(GroupingDefs);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public GroupingDefs(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public GroupingDefs(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public GroupingDefs(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public GroupingDefs() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public GroupingDefs(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// Get
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibraryAttribute("OWC10", 1)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.OWC10Api.GroupingDef this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.OWC10Api.GroupingDef newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OWC10Api.GroupingDef.LateBindingApiWrapperType) as NetOffice.OWC10Api.GroupingDef;
			return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="GroupingDefName">string GroupingDefName</param>
		/// <param name="GroupingFieldName">string GroupingFieldName</param>
		/// <param name="PageFieldName">string PageFieldName</param>
		/// <param name="Index">optional object Index</param>
		[SupportByLibraryAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.GroupingDef Add(string groupingDefName, string groupingFieldName, string pageFieldName, object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(groupingDefName, groupingFieldName, pageFieldName, index);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OWC10Api.GroupingDef newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OWC10Api.GroupingDef.LateBindingApiWrapperType) as NetOffice.OWC10Api.GroupingDef;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="GroupingDefName">string GroupingDefName</param>
		/// <param name="GroupingFieldName">string GroupingFieldName</param>
		/// <param name="PageFieldName">string PageFieldName</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.GroupingDef Add(string groupingDefName, string groupingFieldName, string pageFieldName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(groupingDefName, groupingFieldName, pageFieldName);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OWC10Api.GroupingDef newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OWC10Api.GroupingDef.LateBindingApiWrapperType) as NetOffice.OWC10Api.GroupingDef;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="GroupingDefName">string GroupingDefName</param>
		/// <param name="GroupingFieldName">string GroupingFieldName</param>
		/// <param name="PageFieldName">string PageFieldName</param>
		/// <param name="TotalType">NetOffice.OWC10Api.Enums.DscTotalTypeEnum TotalType</param>
		/// <param name="Index">optional object Index</param>
		[SupportByLibraryAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.GroupingDef AddTotal(string groupingDefName, string groupingFieldName, string pageFieldName, NetOffice.OWC10Api.Enums.DscTotalTypeEnum totalType, object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(groupingDefName, groupingFieldName, pageFieldName, totalType, index);
			object returnItem = Invoker.MethodReturn(this, "AddTotal", paramsArray);
			NetOffice.OWC10Api.GroupingDef newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OWC10Api.GroupingDef.LateBindingApiWrapperType) as NetOffice.OWC10Api.GroupingDef;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="GroupingDefName">string GroupingDefName</param>
		/// <param name="GroupingFieldName">string GroupingFieldName</param>
		/// <param name="PageFieldName">string PageFieldName</param>
		/// <param name="TotalType">NetOffice.OWC10Api.Enums.DscTotalTypeEnum TotalType</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("OWC10", 1)]
		public NetOffice.OWC10Api.GroupingDef AddTotal(string groupingDefName, string groupingFieldName, string pageFieldName, NetOffice.OWC10Api.Enums.DscTotalTypeEnum totalType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(groupingDefName, groupingFieldName, pageFieldName, totalType);
			object returnItem = Invoker.MethodReturn(this, "AddTotal", paramsArray);
			NetOffice.OWC10Api.GroupingDef newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OWC10Api.GroupingDef.LateBindingApiWrapperType) as NetOffice.OWC10Api.GroupingDef;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OWC10 1
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibraryAttribute("OWC10", 1)]
		public void Delete(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			Invoker.Method(this, "Delete", paramsArray);
		}

		#endregion
   
        #region IEnumerable Members
        
		/// <summary>
		/// SupportByLibraryAttribute OWC10, 1
		/// </summary>
		[SupportByLibraryAttribute("OWC10", 1)]
		public IEnumerator GetEnumerator()
		{
			object enumProxy = Invoker.PropertyGet(this, "_NewEnum");
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