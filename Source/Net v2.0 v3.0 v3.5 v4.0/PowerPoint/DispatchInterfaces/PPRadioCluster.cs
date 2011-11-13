//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.PowerPointApi
{
	///<summary>
	/// DispatchInterface PPRadioCluster SupportByLibraryAttribute PowerPoint, 9
	///</summary>
	[SupportByLibraryAttribute("PowerPoint", 9)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class PPRadioCluster : PPControl ,IEnumerable
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
                    _type = typeof(PPRadioCluster);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PPRadioCluster(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PPRadioCluster(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PPRadioCluster(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PPRadioCluster() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PPRadioCluster(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 9)]
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
		/// SupportByLibrary PowerPoint 9
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 9)]
		public NetOffice.PowerPointApi.PPRadioButton Selected
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Selected", paramsArray);
				NetOffice.PowerPointApi.PPRadioButton newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.PPRadioButton.LateBindingApiWrapperType) as NetOffice.PowerPointApi.PPRadioButton;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 9)]
		public string OnClick
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OnClick", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OnClick", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// </summary>
		/// <param name="index">object index</param>
		[SupportByLibraryAttribute("PowerPoint", 9)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.PowerPointApi.PPRadioButton this[object index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.PowerPointApi.PPRadioButton newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.PPRadioButton.LateBindingApiWrapperType) as NetOffice.PowerPointApi.PPRadioButton;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9
		/// </summary>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		[SupportByLibraryAttribute("PowerPoint", 9)]
		public NetOffice.PowerPointApi.PPRadioButton Add(Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.PowerPointApi.PPRadioButton newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.PowerPointApi.PPRadioButton.LateBindingApiWrapperType) as NetOffice.PowerPointApi.PPRadioButton;
			return newObject;
		}

		#endregion
   
        #region IEnumerable Members
		
        /// <summary>
		/// SupportByLibraryAttribute PowerPoint, 9
		/// This is a custom enumerator from NetOffice
		/// </summary>
		[SupportByLibraryAttribute("PowerPoint", 9)]
		[CustomEnumerator]
		public IEnumerator GetEnumerator()
        {
			int count = Count;
			COMObject[] enumeratorObjects = new COMObject[count];
			for (int i = 1; i <= count; i++)
				enumeratorObjects[i] = this[i];

			foreach (COMObject item in enumeratorObjects)
				yield return item;
        }

        #endregion
        
		#pragma warning restore
	}
}