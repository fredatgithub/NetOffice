//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface PictureEffects SupportByLibraryAttribute Office, 14
	///</summary>
	[SupportByLibraryAttribute("Office", 14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class PictureEffects : _IMsoDispObj ,IEnumerable
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
                    _type = typeof(PictureEffects);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PictureEffects(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PictureEffects(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PictureEffects(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PictureEffects() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PictureEffects(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Office 14
		/// Get
		/// </summary>
		/// <param name="Index">Int32 Index</param>
		[SupportByLibraryAttribute("Office", 14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.OfficeApi.PictureEffect this[Int32 index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.OfficeApi.PictureEffect newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.OfficeApi.PictureEffect.LateBindingApiWrapperType) as NetOffice.OfficeApi.PictureEffect;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Office", 14)]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Office 14
		/// </summary>
		/// <param name="EffectType">NetOffice.OfficeApi.Enums.MsoPictureEffectType EffectType</param>
		/// <param name="Position">Int32 Position</param>
		[SupportByLibraryAttribute("Office", 14)]
		public NetOffice.OfficeApi.PictureEffect Insert(NetOffice.OfficeApi.Enums.MsoPictureEffectType effectType, Int32 position)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(effectType, position);
			object returnItem = Invoker.MethodReturn(this, "Insert", paramsArray);
			NetOffice.OfficeApi.PictureEffect newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.OfficeApi.PictureEffect.LateBindingApiWrapperType) as NetOffice.OfficeApi.PictureEffect;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 14
		/// </summary>
		/// <param name="Index">Int32 Index</param>
		[SupportByLibraryAttribute("Office", 14)]
		public void Delete(Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			Invoker.Method(this, "Delete", paramsArray);
		}

		#endregion
   
        #region IEnumerable Members
        
		/// <summary>
		/// SupportByLibraryAttribute Office, 14
		/// </summary>
		[SupportByLibraryAttribute("Office", 14)]
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