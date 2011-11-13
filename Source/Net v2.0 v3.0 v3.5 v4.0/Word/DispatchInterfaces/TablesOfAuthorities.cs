//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.WordApi
{
	///<summary>
	/// DispatchInterface TablesOfAuthorities SupportByLibraryAttribute Word, 9,10,11,12,14
	///</summary>
	[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class TablesOfAuthorities : COMObject ,IEnumerable
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
                    _type = typeof(TablesOfAuthorities);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TablesOfAuthorities(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TablesOfAuthorities(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TablesOfAuthorities(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TablesOfAuthorities() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public TablesOfAuthorities(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
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
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
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
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
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
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
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
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Enums.WdToaFormat Format
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Format", paramsArray);
				return (NetOffice.WordApi.Enums.WdToaFormat)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Format", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Index">Int32 Index</param>
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.WordApi.TableOfAuthorities this[Int32 index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.WordApi.TableOfAuthorities newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.TableOfAuthorities.LateBindingApiWrapperType) as NetOffice.WordApi.TableOfAuthorities;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		/// <param name="Category">optional object Category</param>
		/// <param name="Bookmark">optional object Bookmark</param>
		/// <param name="Passim">optional object Passim</param>
		/// <param name="KeepEntryFormatting">optional object KeepEntryFormatting</param>
		/// <param name="Separator">optional object Separator</param>
		/// <param name="IncludeSequenceName">optional object IncludeSequenceName</param>
		/// <param name="EntrySeparator">optional object EntrySeparator</param>
		/// <param name="PageRangeSeparator">optional object PageRangeSeparator</param>
		/// <param name="IncludeCategoryHeader">optional object IncludeCategoryHeader</param>
		/// <param name="PageNumberSeparator">optional object PageNumberSeparator</param>
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.TableOfAuthorities Add(NetOffice.WordApi.Range range, object category, object bookmark, object passim, object keepEntryFormatting, object separator, object includeSequenceName, object entrySeparator, object pageRangeSeparator, object includeCategoryHeader, object pageNumberSeparator)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, category, bookmark, passim, keepEntryFormatting, separator, includeSequenceName, entrySeparator, pageRangeSeparator, includeCategoryHeader, pageNumberSeparator);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.TableOfAuthorities newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.TableOfAuthorities.LateBindingApiWrapperType) as NetOffice.WordApi.TableOfAuthorities;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.TableOfAuthorities Add(NetOffice.WordApi.Range range)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.TableOfAuthorities newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.TableOfAuthorities.LateBindingApiWrapperType) as NetOffice.WordApi.TableOfAuthorities;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		/// <param name="Category">optional object Category</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.TableOfAuthorities Add(NetOffice.WordApi.Range range, object category)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, category);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.TableOfAuthorities newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.TableOfAuthorities.LateBindingApiWrapperType) as NetOffice.WordApi.TableOfAuthorities;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		/// <param name="Category">optional object Category</param>
		/// <param name="Bookmark">optional object Bookmark</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.TableOfAuthorities Add(NetOffice.WordApi.Range range, object category, object bookmark)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, category, bookmark);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.TableOfAuthorities newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.TableOfAuthorities.LateBindingApiWrapperType) as NetOffice.WordApi.TableOfAuthorities;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		/// <param name="Category">optional object Category</param>
		/// <param name="Bookmark">optional object Bookmark</param>
		/// <param name="Passim">optional object Passim</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.TableOfAuthorities Add(NetOffice.WordApi.Range range, object category, object bookmark, object passim)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, category, bookmark, passim);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.TableOfAuthorities newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.TableOfAuthorities.LateBindingApiWrapperType) as NetOffice.WordApi.TableOfAuthorities;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		/// <param name="Category">optional object Category</param>
		/// <param name="Bookmark">optional object Bookmark</param>
		/// <param name="Passim">optional object Passim</param>
		/// <param name="KeepEntryFormatting">optional object KeepEntryFormatting</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.TableOfAuthorities Add(NetOffice.WordApi.Range range, object category, object bookmark, object passim, object keepEntryFormatting)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, category, bookmark, passim, keepEntryFormatting);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.TableOfAuthorities newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.TableOfAuthorities.LateBindingApiWrapperType) as NetOffice.WordApi.TableOfAuthorities;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		/// <param name="Category">optional object Category</param>
		/// <param name="Bookmark">optional object Bookmark</param>
		/// <param name="Passim">optional object Passim</param>
		/// <param name="KeepEntryFormatting">optional object KeepEntryFormatting</param>
		/// <param name="Separator">optional object Separator</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.TableOfAuthorities Add(NetOffice.WordApi.Range range, object category, object bookmark, object passim, object keepEntryFormatting, object separator)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, category, bookmark, passim, keepEntryFormatting, separator);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.TableOfAuthorities newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.TableOfAuthorities.LateBindingApiWrapperType) as NetOffice.WordApi.TableOfAuthorities;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		/// <param name="Category">optional object Category</param>
		/// <param name="Bookmark">optional object Bookmark</param>
		/// <param name="Passim">optional object Passim</param>
		/// <param name="KeepEntryFormatting">optional object KeepEntryFormatting</param>
		/// <param name="Separator">optional object Separator</param>
		/// <param name="IncludeSequenceName">optional object IncludeSequenceName</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.TableOfAuthorities Add(NetOffice.WordApi.Range range, object category, object bookmark, object passim, object keepEntryFormatting, object separator, object includeSequenceName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, category, bookmark, passim, keepEntryFormatting, separator, includeSequenceName);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.TableOfAuthorities newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.TableOfAuthorities.LateBindingApiWrapperType) as NetOffice.WordApi.TableOfAuthorities;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		/// <param name="Category">optional object Category</param>
		/// <param name="Bookmark">optional object Bookmark</param>
		/// <param name="Passim">optional object Passim</param>
		/// <param name="KeepEntryFormatting">optional object KeepEntryFormatting</param>
		/// <param name="Separator">optional object Separator</param>
		/// <param name="IncludeSequenceName">optional object IncludeSequenceName</param>
		/// <param name="EntrySeparator">optional object EntrySeparator</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.TableOfAuthorities Add(NetOffice.WordApi.Range range, object category, object bookmark, object passim, object keepEntryFormatting, object separator, object includeSequenceName, object entrySeparator)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, category, bookmark, passim, keepEntryFormatting, separator, includeSequenceName, entrySeparator);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.TableOfAuthorities newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.TableOfAuthorities.LateBindingApiWrapperType) as NetOffice.WordApi.TableOfAuthorities;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		/// <param name="Category">optional object Category</param>
		/// <param name="Bookmark">optional object Bookmark</param>
		/// <param name="Passim">optional object Passim</param>
		/// <param name="KeepEntryFormatting">optional object KeepEntryFormatting</param>
		/// <param name="Separator">optional object Separator</param>
		/// <param name="IncludeSequenceName">optional object IncludeSequenceName</param>
		/// <param name="EntrySeparator">optional object EntrySeparator</param>
		/// <param name="PageRangeSeparator">optional object PageRangeSeparator</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.TableOfAuthorities Add(NetOffice.WordApi.Range range, object category, object bookmark, object passim, object keepEntryFormatting, object separator, object includeSequenceName, object entrySeparator, object pageRangeSeparator)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, category, bookmark, passim, keepEntryFormatting, separator, includeSequenceName, entrySeparator, pageRangeSeparator);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.TableOfAuthorities newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.TableOfAuthorities.LateBindingApiWrapperType) as NetOffice.WordApi.TableOfAuthorities;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		/// <param name="Category">optional object Category</param>
		/// <param name="Bookmark">optional object Bookmark</param>
		/// <param name="Passim">optional object Passim</param>
		/// <param name="KeepEntryFormatting">optional object KeepEntryFormatting</param>
		/// <param name="Separator">optional object Separator</param>
		/// <param name="IncludeSequenceName">optional object IncludeSequenceName</param>
		/// <param name="EntrySeparator">optional object EntrySeparator</param>
		/// <param name="PageRangeSeparator">optional object PageRangeSeparator</param>
		/// <param name="IncludeCategoryHeader">optional object IncludeCategoryHeader</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.TableOfAuthorities Add(NetOffice.WordApi.Range range, object category, object bookmark, object passim, object keepEntryFormatting, object separator, object includeSequenceName, object entrySeparator, object pageRangeSeparator, object includeCategoryHeader)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, category, bookmark, passim, keepEntryFormatting, separator, includeSequenceName, entrySeparator, pageRangeSeparator, includeCategoryHeader);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.WordApi.TableOfAuthorities newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.TableOfAuthorities.LateBindingApiWrapperType) as NetOffice.WordApi.TableOfAuthorities;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="ShortCitation">string ShortCitation</param>
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public void NextCitation(string shortCitation)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(shortCitation);
			Invoker.Method(this, "NextCitation", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		/// <param name="ShortCitation">string ShortCitation</param>
		/// <param name="LongCitation">optional object LongCitation</param>
		/// <param name="LongCitationAutoText">optional object LongCitationAutoText</param>
		/// <param name="Category">optional object Category</param>
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Field MarkCitation(NetOffice.WordApi.Range range, string shortCitation, object longCitation, object longCitationAutoText, object category)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, shortCitation, longCitation, longCitationAutoText, category);
			object returnItem = Invoker.MethodReturn(this, "MarkCitation", paramsArray);
			NetOffice.WordApi.Field newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.Field.LateBindingApiWrapperType) as NetOffice.WordApi.Field;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		/// <param name="ShortCitation">string ShortCitation</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Field MarkCitation(NetOffice.WordApi.Range range, string shortCitation)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, shortCitation);
			object returnItem = Invoker.MethodReturn(this, "MarkCitation", paramsArray);
			NetOffice.WordApi.Field newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.Field.LateBindingApiWrapperType) as NetOffice.WordApi.Field;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		/// <param name="ShortCitation">string ShortCitation</param>
		/// <param name="LongCitation">optional object LongCitation</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Field MarkCitation(NetOffice.WordApi.Range range, string shortCitation, object longCitation)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, shortCitation, longCitation);
			object returnItem = Invoker.MethodReturn(this, "MarkCitation", paramsArray);
			NetOffice.WordApi.Field newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.Field.LateBindingApiWrapperType) as NetOffice.WordApi.Field;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Range">NetOffice.WordApi.Range Range</param>
		/// <param name="ShortCitation">string ShortCitation</param>
		/// <param name="LongCitation">optional object LongCitation</param>
		/// <param name="LongCitationAutoText">optional object LongCitationAutoText</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public NetOffice.WordApi.Field MarkCitation(NetOffice.WordApi.Range range, string shortCitation, object longCitation, object longCitationAutoText)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range, shortCitation, longCitation, longCitationAutoText);
			object returnItem = Invoker.MethodReturn(this, "MarkCitation", paramsArray);
			NetOffice.WordApi.Field newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this, returnItem,NetOffice.WordApi.Field.LateBindingApiWrapperType) as NetOffice.WordApi.Field;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="ShortCitation">string ShortCitation</param>
		/// <param name="LongCitation">optional object LongCitation</param>
		/// <param name="LongCitationAutoText">optional object LongCitationAutoText</param>
		/// <param name="Category">optional object Category</param>
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public void MarkAllCitations(string shortCitation, object longCitation, object longCitationAutoText, object category)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(shortCitation, longCitation, longCitationAutoText, category);
			Invoker.Method(this, "MarkAllCitations", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="ShortCitation">string ShortCitation</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public void MarkAllCitations(string shortCitation)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(shortCitation);
			Invoker.Method(this, "MarkAllCitations", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="ShortCitation">string ShortCitation</param>
		/// <param name="LongCitation">optional object LongCitation</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public void MarkAllCitations(string shortCitation, object longCitation)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(shortCitation, longCitation);
			Invoker.Method(this, "MarkAllCitations", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Word 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="ShortCitation">string ShortCitation</param>
		/// <param name="LongCitation">optional object LongCitation</param>
		/// <param name="LongCitationAutoText">optional object LongCitationAutoText</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
		public void MarkAllCitations(string shortCitation, object longCitation, object longCitationAutoText)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(shortCitation, longCitation, longCitationAutoText);
			Invoker.Method(this, "MarkAllCitations", paramsArray);
		}

		#endregion
   
        #region IEnumerable Members
        
		/// <summary>
		/// SupportByLibraryAttribute Word, 9,10,11,12,14
		/// </summary>
		[SupportByLibraryAttribute("Word", 9,10,11,12,14)]
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