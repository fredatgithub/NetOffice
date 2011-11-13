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
	/// DispatchInterface DispCanvasRenderingContext2D SupportByLibraryAttribute MSHTML, 4
	///</summary>
	[SupportByLibraryAttribute("MSHTML", 4)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class DispCanvasRenderingContext2D : COMObject
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
                    _type = typeof(DispCanvasRenderingContext2D);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispCanvasRenderingContext2D(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispCanvasRenderingContext2D(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispCanvasRenderingContext2D(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispCanvasRenderingContext2D() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DispCanvasRenderingContext2D(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLCanvasElement canvas
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "canvas", paramsArray);
				LateBindingApi.MSHTMLApi.IHTMLCanvasElement newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLCanvasElement;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Single globalAlpha
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "globalAlpha", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "globalAlpha", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public string globalCompositeOperation
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "globalCompositeOperation", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "globalCompositeOperation", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object fillStyle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "fillStyle", paramsArray);
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
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "fillStyle", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object strokeStyle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "strokeStyle", paramsArray);
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
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "strokeStyle", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public string lineCap
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "lineCap", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "lineCap", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public string lineJoin
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "lineJoin", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "lineJoin", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Single lineWidth
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "lineWidth", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "lineWidth", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Single miterLimit
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "miterLimit", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "miterLimit", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Single shadowBlur
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "shadowBlur", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "shadowBlur", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public string shadowColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "shadowColor", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "shadowColor", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Single shadowOffsetX
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "shadowOffsetX", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "shadowOffsetX", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Single shadowOffsetY
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "shadowOffsetY", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "shadowOffsetY", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public string font
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "font", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "font", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public string textAlign
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "textAlign", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "textAlign", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public string textBaseline
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "textBaseline", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "textBaseline", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void restore()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "restore", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void save()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "save", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="angle">Single angle</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void rotate(Single angle)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(angle);
			Invoker.Method(this, "rotate", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="x">Single x</param>
		/// <param name="y">Single y</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void scale(Single x, Single y)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(x, y);
			Invoker.Method(this, "scale", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="m11">Single m11</param>
		/// <param name="m12">Single m12</param>
		/// <param name="m21">Single m21</param>
		/// <param name="m22">Single m22</param>
		/// <param name="dx">Single dx</param>
		/// <param name="dy">Single dy</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void setTransform(Single m11, Single m12, Single m21, Single m22, Single dx, Single dy)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(m11, m12, m21, m22, dx, dy);
			Invoker.Method(this, "setTransform", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="m11">Single m11</param>
		/// <param name="m12">Single m12</param>
		/// <param name="m21">Single m21</param>
		/// <param name="m22">Single m22</param>
		/// <param name="dx">Single dx</param>
		/// <param name="dy">Single dy</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void transform(Single m11, Single m12, Single m21, Single m22, Single dx, Single dy)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(m11, m12, m21, m22, dx, dy);
			Invoker.Method(this, "transform", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="x">Single x</param>
		/// <param name="y">Single y</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void translate(Single x, Single y)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(x, y);
			Invoker.Method(this, "translate", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="x0">Single x0</param>
		/// <param name="y0">Single y0</param>
		/// <param name="x1">Single x1</param>
		/// <param name="y1">Single y1</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ICanvasGradient createLinearGradient(Single x0, Single y0, Single x1, Single y1)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(x0, y0, x1, y1);
			object returnItem = Invoker.MethodReturn(this, "createLinearGradient", paramsArray);
			LateBindingApi.MSHTMLApi.ICanvasGradient newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ICanvasGradient;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="x0">Single x0</param>
		/// <param name="y0">Single y0</param>
		/// <param name="r0">Single r0</param>
		/// <param name="x1">Single x1</param>
		/// <param name="y1">Single y1</param>
		/// <param name="r1">Single r1</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ICanvasGradient createRadialGradient(Single x0, Single y0, Single r0, Single x1, Single y1, Single r1)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(x0, y0, r0, x1, y1, r1);
			object returnItem = Invoker.MethodReturn(this, "createRadialGradient", paramsArray);
			LateBindingApi.MSHTMLApi.ICanvasGradient newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ICanvasGradient;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="Image">object Image</param>
		/// <param name="repetition">object repetition</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ICanvasPattern createPattern(object image, object repetition)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(image, repetition);
			object returnItem = Invoker.MethodReturn(this, "createPattern", paramsArray);
			LateBindingApi.MSHTMLApi.ICanvasPattern newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ICanvasPattern;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="x">Single x</param>
		/// <param name="y">Single y</param>
		/// <param name="w">Single w</param>
		/// <param name="h">Single h</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void clearRect(Single x, Single y, Single w, Single h)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(x, y, w, h);
			Invoker.Method(this, "clearRect", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="x">Single x</param>
		/// <param name="y">Single y</param>
		/// <param name="w">Single w</param>
		/// <param name="h">Single h</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void fillRect(Single x, Single y, Single w, Single h)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(x, y, w, h);
			Invoker.Method(this, "fillRect", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="x">Single x</param>
		/// <param name="y">Single y</param>
		/// <param name="w">Single w</param>
		/// <param name="h">Single h</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void strokeRect(Single x, Single y, Single w, Single h)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(x, y, w, h);
			Invoker.Method(this, "strokeRect", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="x">Single x</param>
		/// <param name="y">Single y</param>
		/// <param name="radius">Single radius</param>
		/// <param name="startAngle">Single startAngle</param>
		/// <param name="endAngle">Single endAngle</param>
		/// <param name="anticlockwise">Int32 anticlockwise</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void arc(Single x, Single y, Single radius, Single startAngle, Single endAngle, Int32 anticlockwise)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(x, y, radius, startAngle, endAngle, anticlockwise);
			Invoker.Method(this, "arc", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="x1">Single x1</param>
		/// <param name="y1">Single y1</param>
		/// <param name="x2">Single x2</param>
		/// <param name="y2">Single y2</param>
		/// <param name="radius">Single radius</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void arcTo(Single x1, Single y1, Single x2, Single y2, Single radius)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(x1, y1, x2, y2, radius);
			Invoker.Method(this, "arcTo", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void beginPath()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "beginPath", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="cp1x">Single cp1x</param>
		/// <param name="cp1y">Single cp1y</param>
		/// <param name="cp2x">Single cp2x</param>
		/// <param name="cp2y">Single cp2y</param>
		/// <param name="x">Single x</param>
		/// <param name="y">Single y</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void bezierCurveTo(Single cp1x, Single cp1y, Single cp2x, Single cp2y, Single x, Single y)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(cp1x, cp1y, cp2x, cp2y, x, y);
			Invoker.Method(this, "bezierCurveTo", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void clip()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "clip", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void closePath()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "closePath", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void fill()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "fill", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="x">Single x</param>
		/// <param name="y">Single y</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void lineTo(Single x, Single y)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(x, y);
			Invoker.Method(this, "lineTo", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="x">Single x</param>
		/// <param name="y">Single y</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void moveTo(Single x, Single y)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(x, y);
			Invoker.Method(this, "moveTo", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="cpx">Single cpx</param>
		/// <param name="cpy">Single cpy</param>
		/// <param name="x">Single x</param>
		/// <param name="y">Single y</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void quadraticCurveTo(Single cpx, Single cpy, Single x, Single y)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(cpx, cpy, x, y);
			Invoker.Method(this, "quadraticCurveTo", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="x">Single x</param>
		/// <param name="y">Single y</param>
		/// <param name="w">Single w</param>
		/// <param name="h">Single h</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void rect(Single x, Single y, Single w, Single h)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(x, y, w, h);
			Invoker.Method(this, "rect", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void stroke()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "stroke", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="x">Single x</param>
		/// <param name="y">Single y</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool isPointInPath(Single x, Single y)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(x, y);
			object returnItem = Invoker.MethodReturn(this, "isPointInPath", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="text">string text</param>
		/// <param name="x">Single x</param>
		/// <param name="y">Single y</param>
		/// <param name="maxWidth">object maxWidth</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void fillText(string text, Single x, Single y, object maxWidth)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(text, x, y, maxWidth);
			Invoker.Method(this, "fillText", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="text">string text</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ICanvasTextMetrics measureText(string text)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(text);
			object returnItem = Invoker.MethodReturn(this, "measureText", paramsArray);
			LateBindingApi.MSHTMLApi.ICanvasTextMetrics newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ICanvasTextMetrics;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="text">string text</param>
		/// <param name="x">Single x</param>
		/// <param name="y">Single y</param>
		/// <param name="maxWidth">object maxWidth</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void strokeText(string text, Single x, Single y, object maxWidth)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(text, x, y, maxWidth);
			Invoker.Method(this, "strokeText", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="pSrc">object pSrc</param>
		/// <param name="a1">object a1</param>
		/// <param name="a2">object a2</param>
		/// <param name="a3">object a3</param>
		/// <param name="a4">object a4</param>
		/// <param name="a5">object a5</param>
		/// <param name="a6">object a6</param>
		/// <param name="a7">object a7</param>
		/// <param name="a8">object a8</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void drawImage(object pSrc, object a1, object a2, object a3, object a4, object a5, object a6, object a7, object a8)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pSrc, a1, a2, a3, a4, a5, a6, a7, a8);
			Invoker.Method(this, "drawImage", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="a1">object a1</param>
		/// <param name="a2">object a2</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ICanvasImageData createImageData(object a1, object a2)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(a1, a2);
			object returnItem = Invoker.MethodReturn(this, "createImageData", paramsArray);
			LateBindingApi.MSHTMLApi.ICanvasImageData newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ICanvasImageData;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="sx">Single sx</param>
		/// <param name="sy">Single sy</param>
		/// <param name="sw">Single sw</param>
		/// <param name="sh">Single sh</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.ICanvasImageData getImageData(Single sx, Single sy, Single sw, Single sh)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sx, sy, sw, sh);
			object returnItem = Invoker.MethodReturn(this, "getImageData", paramsArray);
			LateBindingApi.MSHTMLApi.ICanvasImageData newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.ICanvasImageData;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="imagedata">LateBindingApi.MSHTMLApi.ICanvasImageData imagedata</param>
		/// <param name="dx">Single dx</param>
		/// <param name="dy">Single dy</param>
		/// <param name="dirtyX">object dirtyX</param>
		/// <param name="dirtyY">object dirtyY</param>
		/// <param name="dirtyWidth">object dirtyWidth</param>
		/// <param name="dirtyHeight">object dirtyHeight</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void putImageData(LateBindingApi.MSHTMLApi.ICanvasImageData imagedata, Single dx, Single dy, object dirtyX, object dirtyY, object dirtyWidth, object dirtyHeight)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(imagedata, dx, dy, dirtyX, dirtyY, dirtyWidth, dirtyHeight);
			Invoker.Method(this, "putImageData", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}