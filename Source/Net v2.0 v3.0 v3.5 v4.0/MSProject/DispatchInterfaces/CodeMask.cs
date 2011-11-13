//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace LateBindingApi.MSProjectApi
{
	///<summary>
	/// DispatchInterface CodeMask SupportByLibraryAttribute MSProject, 12,14
	///</summary>
	[SupportByLibraryAttribute("MSProject", 12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class CodeMask : COMObject ,IEnumerable
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
                    _type = typeof(CodeMask);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CodeMask(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CodeMask(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CodeMask(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CodeMask() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CodeMask(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSProject", 12,14)]
		public LateBindingApi.MSProjectApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				LateBindingApi.MSProjectApi.Application newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,LateBindingApi.MSProjectApi.Application.LateBindingApiWrapperType) as LateBindingApi.MSProjectApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSProject", 12,14)]
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
		/// SupportByLibrary MSProject 12, 14
		/// Get
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibraryAttribute("MSProject", 12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public LateBindingApi.MSProjectApi.CodeMaskLevel this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			LateBindingApi.MSProjectApi.CodeMaskLevel newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,LateBindingApi.MSProjectApi.CodeMaskLevel.LateBindingApiWrapperType) as LateBindingApi.MSProjectApi.CodeMaskLevel;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSProject", 12,14)]
		public LateBindingApi.MSProjectApi.OutlineCode Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				LateBindingApi.MSProjectApi.OutlineCode newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,LateBindingApi.MSProjectApi.OutlineCode.LateBindingApiWrapperType) as LateBindingApi.MSProjectApi.OutlineCode;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// </summary>
		/// <param name="Sequence">LateBindingApi.MSProjectApi.Enums.PjCustomOutlineCodeSequence Sequence</param>
		/// <param name="Length">optional object Length</param>
		/// <param name="Separator">optional object Separator</param>
		[SupportByLibraryAttribute("MSProject", 12,14)]
		public LateBindingApi.MSProjectApi.CodeMaskLevel Add(LateBindingApi.MSProjectApi.Enums.PjCustomOutlineCodeSequence sequence, object length, object separator)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sequence, length, separator);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			LateBindingApi.MSProjectApi.CodeMaskLevel newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,LateBindingApi.MSProjectApi.CodeMaskLevel.LateBindingApiWrapperType) as LateBindingApi.MSProjectApi.CodeMaskLevel;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// </summary>
		/// <param name="Sequence">LateBindingApi.MSProjectApi.Enums.PjCustomOutlineCodeSequence Sequence</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("MSProject", 12,14)]
		public LateBindingApi.MSProjectApi.CodeMaskLevel Add(LateBindingApi.MSProjectApi.Enums.PjCustomOutlineCodeSequence sequence)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sequence);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			LateBindingApi.MSProjectApi.CodeMaskLevel newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,LateBindingApi.MSProjectApi.CodeMaskLevel.LateBindingApiWrapperType) as LateBindingApi.MSProjectApi.CodeMaskLevel;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSProject 12, 14
		/// </summary>
		/// <param name="Sequence">LateBindingApi.MSProjectApi.Enums.PjCustomOutlineCodeSequence Sequence</param>
		/// <param name="Length">optional object Length</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("MSProject", 12,14)]
		public LateBindingApi.MSProjectApi.CodeMaskLevel Add(LateBindingApi.MSProjectApi.Enums.PjCustomOutlineCodeSequence sequence, object length)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sequence, length);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			LateBindingApi.MSProjectApi.CodeMaskLevel newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,LateBindingApi.MSProjectApi.CodeMaskLevel.LateBindingApiWrapperType) as LateBindingApi.MSProjectApi.CodeMaskLevel;
			return newObject;
		}

		#endregion
   
        #region IEnumerable Members
        
		/// <summary>
		/// SupportByLibraryAttribute MSProject, 12,14
		/// </summary>
		[SupportByLibraryAttribute("MSProject", 12,14)]
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