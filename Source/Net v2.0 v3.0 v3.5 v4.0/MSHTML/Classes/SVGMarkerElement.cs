//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace LateBindingApi.MSHTMLApi
{

	#region Delegates

	#pragma warning disable
	public delegate void SVGMarkerElement_onhelpEventHandler();
	public delegate void SVGMarkerElement_onclickEventHandler();
	public delegate void SVGMarkerElement_ondblclickEventHandler();
	public delegate void SVGMarkerElement_onkeypressEventHandler();
	public delegate void SVGMarkerElement_onkeydownEventHandler();
	public delegate void SVGMarkerElement_onkeyupEventHandler();
	public delegate void SVGMarkerElement_onmouseoutEventHandler();
	public delegate void SVGMarkerElement_onmouseoverEventHandler();
	public delegate void SVGMarkerElement_onmousemoveEventHandler();
	public delegate void SVGMarkerElement_onmousedownEventHandler();
	public delegate void SVGMarkerElement_onmouseupEventHandler();
	public delegate void SVGMarkerElement_onselectstartEventHandler();
	public delegate void SVGMarkerElement_onfilterchangeEventHandler();
	public delegate void SVGMarkerElement_ondragstartEventHandler();
	public delegate void SVGMarkerElement_onbeforeupdateEventHandler();
	public delegate void SVGMarkerElement_onafterupdateEventHandler();
	public delegate void SVGMarkerElement_onerrorupdateEventHandler();
	public delegate void SVGMarkerElement_onrowexitEventHandler();
	public delegate void SVGMarkerElement_onrowenterEventHandler();
	public delegate void SVGMarkerElement_ondatasetchangedEventHandler();
	public delegate void SVGMarkerElement_ondataavailableEventHandler();
	public delegate void SVGMarkerElement_ondatasetcompleteEventHandler();
	public delegate void SVGMarkerElement_onlosecaptureEventHandler();
	public delegate void SVGMarkerElement_onpropertychangeEventHandler();
	public delegate void SVGMarkerElement_onscrollEventHandler();
	public delegate void SVGMarkerElement_onfocusEventHandler();
	public delegate void SVGMarkerElement_onblurEventHandler();
	public delegate void SVGMarkerElement_onresizeEventHandler();
	public delegate void SVGMarkerElement_ondragEventHandler();
	public delegate void SVGMarkerElement_ondragendEventHandler();
	public delegate void SVGMarkerElement_ondragenterEventHandler();
	public delegate void SVGMarkerElement_ondragoverEventHandler();
	public delegate void SVGMarkerElement_ondragleaveEventHandler();
	public delegate void SVGMarkerElement_ondropEventHandler();
	public delegate void SVGMarkerElement_onbeforecutEventHandler();
	public delegate void SVGMarkerElement_oncutEventHandler();
	public delegate void SVGMarkerElement_onbeforecopyEventHandler();
	public delegate void SVGMarkerElement_oncopyEventHandler();
	public delegate void SVGMarkerElement_onbeforepasteEventHandler();
	public delegate void SVGMarkerElement_onpasteEventHandler();
	public delegate void SVGMarkerElement_oncontextmenuEventHandler();
	public delegate void SVGMarkerElement_onrowsdeleteEventHandler();
	public delegate void SVGMarkerElement_onrowsinsertedEventHandler();
	public delegate void SVGMarkerElement_oncellchangeEventHandler();
	public delegate void SVGMarkerElement_onreadystatechangeEventHandler();
	public delegate void SVGMarkerElement_onbeforeeditfocusEventHandler();
	public delegate void SVGMarkerElement_onlayoutcompleteEventHandler();
	public delegate void SVGMarkerElement_onpageEventHandler();
	public delegate void SVGMarkerElement_onbeforedeactivateEventHandler();
	public delegate void SVGMarkerElement_onbeforeactivateEventHandler();
	public delegate void SVGMarkerElement_onmoveEventHandler();
	public delegate void SVGMarkerElement_oncontrolselectEventHandler();
	public delegate void SVGMarkerElement_onmovestartEventHandler();
	public delegate void SVGMarkerElement_onmoveendEventHandler();
	public delegate void SVGMarkerElement_onresizestartEventHandler();
	public delegate void SVGMarkerElement_onresizeendEventHandler();
	public delegate void SVGMarkerElement_onmouseenterEventHandler();
	public delegate void SVGMarkerElement_onmouseleaveEventHandler();
	public delegate void SVGMarkerElement_onmousewheelEventHandler();
	public delegate void SVGMarkerElement_onactivateEventHandler();
	public delegate void SVGMarkerElement_ondeactivateEventHandler();
	public delegate void SVGMarkerElement_onfocusinEventHandler();
	public delegate void SVGMarkerElement_onfocusoutEventHandler();
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass SVGMarkerElement SupportByLibraryAttribute MSHTML, 4
	///</summary>
	[SupportByLibraryAttribute("MSHTML", 4)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class SVGMarkerElement : DispSVGMarkerElement, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		HTMLElementEvents_SinkHelper _hTMLElementEvents_SinkHelper;
	
		#endregion

		#region Type Information

        private static Type _type;
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(SVGMarkerElement);
                    
                return _type;
            }
        }
        
        #endregion
        		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
		public SVGMarkerElement(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SVGMarkerElement(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SVGMarkerElement(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		/// <summary>
        /// creates a new instance of SVGMarkerElement 
        /// </summary>		
		public SVGMarkerElement():base("MSHTML.SVGMarkerElement")
		{
		}
		
		/// <summary>
        /// creates a new instance of SVGMarkerElement
        /// </summary>
        /// <param name="progId">registered ProgID</param>
		public SVGMarkerElement(string progId):base(progId)
		{
		}

		#endregion
		
		#region Private Methods
		
		/// <summary>
        /// creates active sink helper
        /// </summary>
		private void CreateEventBridge()
        {
			if(false == LateBindingApi.Core.Settings.EnableEvents)
				return;
	
			if (null != _connectPoint)
				return;
	
            if (null == _activeSinkId)
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, HTMLElementEvents_SinkHelper.Id);


			if(HTMLElementEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_hTMLElementEvents_SinkHelper = new HTMLElementEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onhelpEventHandler _onhelpEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onhelpEventHandler onhelpEvent
		{
			add
			{
				CreateEventBridge();
				_onhelpEvent += value;
			}
			remove
			{
				_onhelpEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onclickEventHandler _onclickEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onclickEventHandler onclickEvent
		{
			add
			{
				CreateEventBridge();
				_onclickEvent += value;
			}
			remove
			{
				_onclickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_ondblclickEventHandler _ondblclickEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_ondblclickEventHandler ondblclickEvent
		{
			add
			{
				CreateEventBridge();
				_ondblclickEvent += value;
			}
			remove
			{
				_ondblclickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onkeypressEventHandler _onkeypressEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onkeypressEventHandler onkeypressEvent
		{
			add
			{
				CreateEventBridge();
				_onkeypressEvent += value;
			}
			remove
			{
				_onkeypressEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onkeydownEventHandler _onkeydownEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onkeydownEventHandler onkeydownEvent
		{
			add
			{
				CreateEventBridge();
				_onkeydownEvent += value;
			}
			remove
			{
				_onkeydownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onkeyupEventHandler _onkeyupEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onkeyupEventHandler onkeyupEvent
		{
			add
			{
				CreateEventBridge();
				_onkeyupEvent += value;
			}
			remove
			{
				_onkeyupEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onmouseoutEventHandler _onmouseoutEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onmouseoutEventHandler onmouseoutEvent
		{
			add
			{
				CreateEventBridge();
				_onmouseoutEvent += value;
			}
			remove
			{
				_onmouseoutEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onmouseoverEventHandler _onmouseoverEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onmouseoverEventHandler onmouseoverEvent
		{
			add
			{
				CreateEventBridge();
				_onmouseoverEvent += value;
			}
			remove
			{
				_onmouseoverEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onmousemoveEventHandler _onmousemoveEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onmousemoveEventHandler onmousemoveEvent
		{
			add
			{
				CreateEventBridge();
				_onmousemoveEvent += value;
			}
			remove
			{
				_onmousemoveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onmousedownEventHandler _onmousedownEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onmousedownEventHandler onmousedownEvent
		{
			add
			{
				CreateEventBridge();
				_onmousedownEvent += value;
			}
			remove
			{
				_onmousedownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onmouseupEventHandler _onmouseupEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onmouseupEventHandler onmouseupEvent
		{
			add
			{
				CreateEventBridge();
				_onmouseupEvent += value;
			}
			remove
			{
				_onmouseupEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onselectstartEventHandler _onselectstartEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onselectstartEventHandler onselectstartEvent
		{
			add
			{
				CreateEventBridge();
				_onselectstartEvent += value;
			}
			remove
			{
				_onselectstartEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onfilterchangeEventHandler _onfilterchangeEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onfilterchangeEventHandler onfilterchangeEvent
		{
			add
			{
				CreateEventBridge();
				_onfilterchangeEvent += value;
			}
			remove
			{
				_onfilterchangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_ondragstartEventHandler _ondragstartEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_ondragstartEventHandler ondragstartEvent
		{
			add
			{
				CreateEventBridge();
				_ondragstartEvent += value;
			}
			remove
			{
				_ondragstartEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onbeforeupdateEventHandler _onbeforeupdateEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onbeforeupdateEventHandler onbeforeupdateEvent
		{
			add
			{
				CreateEventBridge();
				_onbeforeupdateEvent += value;
			}
			remove
			{
				_onbeforeupdateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onafterupdateEventHandler _onafterupdateEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onafterupdateEventHandler onafterupdateEvent
		{
			add
			{
				CreateEventBridge();
				_onafterupdateEvent += value;
			}
			remove
			{
				_onafterupdateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onerrorupdateEventHandler _onerrorupdateEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onerrorupdateEventHandler onerrorupdateEvent
		{
			add
			{
				CreateEventBridge();
				_onerrorupdateEvent += value;
			}
			remove
			{
				_onerrorupdateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onrowexitEventHandler _onrowexitEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onrowexitEventHandler onrowexitEvent
		{
			add
			{
				CreateEventBridge();
				_onrowexitEvent += value;
			}
			remove
			{
				_onrowexitEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onrowenterEventHandler _onrowenterEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onrowenterEventHandler onrowenterEvent
		{
			add
			{
				CreateEventBridge();
				_onrowenterEvent += value;
			}
			remove
			{
				_onrowenterEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_ondatasetchangedEventHandler _ondatasetchangedEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_ondatasetchangedEventHandler ondatasetchangedEvent
		{
			add
			{
				CreateEventBridge();
				_ondatasetchangedEvent += value;
			}
			remove
			{
				_ondatasetchangedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_ondataavailableEventHandler _ondataavailableEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_ondataavailableEventHandler ondataavailableEvent
		{
			add
			{
				CreateEventBridge();
				_ondataavailableEvent += value;
			}
			remove
			{
				_ondataavailableEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_ondatasetcompleteEventHandler _ondatasetcompleteEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_ondatasetcompleteEventHandler ondatasetcompleteEvent
		{
			add
			{
				CreateEventBridge();
				_ondatasetcompleteEvent += value;
			}
			remove
			{
				_ondatasetcompleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onlosecaptureEventHandler _onlosecaptureEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onlosecaptureEventHandler onlosecaptureEvent
		{
			add
			{
				CreateEventBridge();
				_onlosecaptureEvent += value;
			}
			remove
			{
				_onlosecaptureEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onpropertychangeEventHandler _onpropertychangeEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onpropertychangeEventHandler onpropertychangeEvent
		{
			add
			{
				CreateEventBridge();
				_onpropertychangeEvent += value;
			}
			remove
			{
				_onpropertychangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onscrollEventHandler _onscrollEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onscrollEventHandler onscrollEvent
		{
			add
			{
				CreateEventBridge();
				_onscrollEvent += value;
			}
			remove
			{
				_onscrollEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onfocusEventHandler _onfocusEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onfocusEventHandler onfocusEvent
		{
			add
			{
				CreateEventBridge();
				_onfocusEvent += value;
			}
			remove
			{
				_onfocusEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onblurEventHandler _onblurEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onblurEventHandler onblurEvent
		{
			add
			{
				CreateEventBridge();
				_onblurEvent += value;
			}
			remove
			{
				_onblurEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onresizeEventHandler _onresizeEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onresizeEventHandler onresizeEvent
		{
			add
			{
				CreateEventBridge();
				_onresizeEvent += value;
			}
			remove
			{
				_onresizeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_ondragEventHandler _ondragEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_ondragEventHandler ondragEvent
		{
			add
			{
				CreateEventBridge();
				_ondragEvent += value;
			}
			remove
			{
				_ondragEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_ondragendEventHandler _ondragendEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_ondragendEventHandler ondragendEvent
		{
			add
			{
				CreateEventBridge();
				_ondragendEvent += value;
			}
			remove
			{
				_ondragendEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_ondragenterEventHandler _ondragenterEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_ondragenterEventHandler ondragenterEvent
		{
			add
			{
				CreateEventBridge();
				_ondragenterEvent += value;
			}
			remove
			{
				_ondragenterEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_ondragoverEventHandler _ondragoverEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_ondragoverEventHandler ondragoverEvent
		{
			add
			{
				CreateEventBridge();
				_ondragoverEvent += value;
			}
			remove
			{
				_ondragoverEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_ondragleaveEventHandler _ondragleaveEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_ondragleaveEventHandler ondragleaveEvent
		{
			add
			{
				CreateEventBridge();
				_ondragleaveEvent += value;
			}
			remove
			{
				_ondragleaveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_ondropEventHandler _ondropEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_ondropEventHandler ondropEvent
		{
			add
			{
				CreateEventBridge();
				_ondropEvent += value;
			}
			remove
			{
				_ondropEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onbeforecutEventHandler _onbeforecutEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onbeforecutEventHandler onbeforecutEvent
		{
			add
			{
				CreateEventBridge();
				_onbeforecutEvent += value;
			}
			remove
			{
				_onbeforecutEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_oncutEventHandler _oncutEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_oncutEventHandler oncutEvent
		{
			add
			{
				CreateEventBridge();
				_oncutEvent += value;
			}
			remove
			{
				_oncutEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onbeforecopyEventHandler _onbeforecopyEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onbeforecopyEventHandler onbeforecopyEvent
		{
			add
			{
				CreateEventBridge();
				_onbeforecopyEvent += value;
			}
			remove
			{
				_onbeforecopyEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_oncopyEventHandler _oncopyEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_oncopyEventHandler oncopyEvent
		{
			add
			{
				CreateEventBridge();
				_oncopyEvent += value;
			}
			remove
			{
				_oncopyEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onbeforepasteEventHandler _onbeforepasteEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onbeforepasteEventHandler onbeforepasteEvent
		{
			add
			{
				CreateEventBridge();
				_onbeforepasteEvent += value;
			}
			remove
			{
				_onbeforepasteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onpasteEventHandler _onpasteEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onpasteEventHandler onpasteEvent
		{
			add
			{
				CreateEventBridge();
				_onpasteEvent += value;
			}
			remove
			{
				_onpasteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_oncontextmenuEventHandler _oncontextmenuEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_oncontextmenuEventHandler oncontextmenuEvent
		{
			add
			{
				CreateEventBridge();
				_oncontextmenuEvent += value;
			}
			remove
			{
				_oncontextmenuEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onrowsdeleteEventHandler _onrowsdeleteEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onrowsdeleteEventHandler onrowsdeleteEvent
		{
			add
			{
				CreateEventBridge();
				_onrowsdeleteEvent += value;
			}
			remove
			{
				_onrowsdeleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onrowsinsertedEventHandler _onrowsinsertedEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onrowsinsertedEventHandler onrowsinsertedEvent
		{
			add
			{
				CreateEventBridge();
				_onrowsinsertedEvent += value;
			}
			remove
			{
				_onrowsinsertedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_oncellchangeEventHandler _oncellchangeEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_oncellchangeEventHandler oncellchangeEvent
		{
			add
			{
				CreateEventBridge();
				_oncellchangeEvent += value;
			}
			remove
			{
				_oncellchangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onreadystatechangeEventHandler _onreadystatechangeEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onreadystatechangeEventHandler onreadystatechangeEvent
		{
			add
			{
				CreateEventBridge();
				_onreadystatechangeEvent += value;
			}
			remove
			{
				_onreadystatechangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onbeforeeditfocusEventHandler _onbeforeeditfocusEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onbeforeeditfocusEventHandler onbeforeeditfocusEvent
		{
			add
			{
				CreateEventBridge();
				_onbeforeeditfocusEvent += value;
			}
			remove
			{
				_onbeforeeditfocusEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onlayoutcompleteEventHandler _onlayoutcompleteEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onlayoutcompleteEventHandler onlayoutcompleteEvent
		{
			add
			{
				CreateEventBridge();
				_onlayoutcompleteEvent += value;
			}
			remove
			{
				_onlayoutcompleteEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onpageEventHandler _onpageEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onpageEventHandler onpageEvent
		{
			add
			{
				CreateEventBridge();
				_onpageEvent += value;
			}
			remove
			{
				_onpageEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onbeforedeactivateEventHandler _onbeforedeactivateEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onbeforedeactivateEventHandler onbeforedeactivateEvent
		{
			add
			{
				CreateEventBridge();
				_onbeforedeactivateEvent += value;
			}
			remove
			{
				_onbeforedeactivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onbeforeactivateEventHandler _onbeforeactivateEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onbeforeactivateEventHandler onbeforeactivateEvent
		{
			add
			{
				CreateEventBridge();
				_onbeforeactivateEvent += value;
			}
			remove
			{
				_onbeforeactivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onmoveEventHandler _onmoveEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onmoveEventHandler onmoveEvent
		{
			add
			{
				CreateEventBridge();
				_onmoveEvent += value;
			}
			remove
			{
				_onmoveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_oncontrolselectEventHandler _oncontrolselectEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_oncontrolselectEventHandler oncontrolselectEvent
		{
			add
			{
				CreateEventBridge();
				_oncontrolselectEvent += value;
			}
			remove
			{
				_oncontrolselectEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onmovestartEventHandler _onmovestartEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onmovestartEventHandler onmovestartEvent
		{
			add
			{
				CreateEventBridge();
				_onmovestartEvent += value;
			}
			remove
			{
				_onmovestartEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onmoveendEventHandler _onmoveendEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onmoveendEventHandler onmoveendEvent
		{
			add
			{
				CreateEventBridge();
				_onmoveendEvent += value;
			}
			remove
			{
				_onmoveendEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onresizestartEventHandler _onresizestartEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onresizestartEventHandler onresizestartEvent
		{
			add
			{
				CreateEventBridge();
				_onresizestartEvent += value;
			}
			remove
			{
				_onresizestartEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onresizeendEventHandler _onresizeendEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onresizeendEventHandler onresizeendEvent
		{
			add
			{
				CreateEventBridge();
				_onresizeendEvent += value;
			}
			remove
			{
				_onresizeendEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onmouseenterEventHandler _onmouseenterEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onmouseenterEventHandler onmouseenterEvent
		{
			add
			{
				CreateEventBridge();
				_onmouseenterEvent += value;
			}
			remove
			{
				_onmouseenterEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onmouseleaveEventHandler _onmouseleaveEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onmouseleaveEventHandler onmouseleaveEvent
		{
			add
			{
				CreateEventBridge();
				_onmouseleaveEvent += value;
			}
			remove
			{
				_onmouseleaveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onmousewheelEventHandler _onmousewheelEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onmousewheelEventHandler onmousewheelEvent
		{
			add
			{
				CreateEventBridge();
				_onmousewheelEvent += value;
			}
			remove
			{
				_onmousewheelEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onactivateEventHandler _onactivateEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onactivateEventHandler onactivateEvent
		{
			add
			{
				CreateEventBridge();
				_onactivateEvent += value;
			}
			remove
			{
				_onactivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_ondeactivateEventHandler _ondeactivateEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_ondeactivateEventHandler ondeactivateEvent
		{
			add
			{
				CreateEventBridge();
				_ondeactivateEvent += value;
			}
			remove
			{
				_ondeactivateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onfocusinEventHandler _onfocusinEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onfocusinEventHandler onfocusinEvent
		{
			add
			{
				CreateEventBridge();
				_onfocusinEvent += value;
			}
			remove
			{
				_onfocusinEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML, 4
		/// </summary>
		private event SVGMarkerElement_onfocusoutEventHandler _onfocusoutEvent;

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibrary("MSHTML", 4)]
		public event SVGMarkerElement_onfocusoutEventHandler onfocusoutEvent
		{
			add
			{
				CreateEventBridge();
				_onfocusoutEvent += value;
			}
			remove
			{
				_onfocusoutEvent -= value;
			}
		}

		#endregion

        #region IEventBinding Member
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool EventBridgeInitialized
        {
            get 
            {
                return (null != _connectPoint);
            }
        }
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients       
        {
			get
			{
				if(null == _thisType)
					_thisType = this.GetType();
					
				foreach (NetRuntimeSystem.Reflection.EventInfo item in _thisType.GetEvents())
				{
					MulticastDelegate eventDelegate = (MulticastDelegate) _thisType.GetType().GetField(item.Name, 
																			NetRuntimeSystem.Reflection.BindingFlags.NonPublic |
																			NetRuntimeSystem.Reflection.BindingFlags.Instance).GetValue(this);
					
					if( (null != eventDelegate) && (eventDelegate.GetInvocationList().Length > 0) )
						return false;
				}
				
				return false;
			}
        }
        
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public Delegate[] GetEventRecipients(string eventName)
        {
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                return delegates;
            }
            else
                return new Delegate[0];
        }

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public void DisposeSinkHelper()
        {
			if( null != _hTMLElementEvents_SinkHelper)
			{
				_hTMLElementEvents_SinkHelper.Dispose();
				_hTMLElementEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}