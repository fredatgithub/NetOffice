//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace NetOffice.OutlookApi
{

	#region Delegates

	#pragma warning disable
	public delegate void SyncObject_SyncStartEventHandler();
	public delegate void SyncObject_ProgressEventHandler(NetOffice.OutlookApi.Enums.OlSyncState State, string Description, Int32 Value, Int32 Max);
	public delegate void SyncObject_OnErrorEventHandler(Int32 Code, string Description);
	public delegate void SyncObject_SyncEndEventHandler();
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass SyncObject SupportByLibraryAttribute Outlook, 9,10,11,12,14
	///</summary>
	[SupportByLibraryAttribute("Outlook", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsCoClass)]
	public class SyncObject : _SyncObject, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		SyncObjectEvents_SinkHelper _syncObjectEvents_SinkHelper;
	
		#endregion

		#region Type Information

        private static Type _type;
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(SyncObject);
                    
                return _type;
            }
        }
        
        #endregion
        		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
		public SyncObject(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SyncObject(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SyncObject(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		/// <summary>
        /// creates a new instance of SyncObject 
        /// </summary>		
		public SyncObject():base("Outlook.SyncObject")
		{
		}
		
		/// <summary>
        /// creates a new instance of SyncObject
        /// </summary>
        /// <param name="progId">registered ProgID</param>
		public SyncObject(string progId):base(progId)
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
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, SyncObjectEvents_SinkHelper.Id);


			if(SyncObjectEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_syncObjectEvents_SinkHelper = new SyncObjectEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary Outlook, 9,10,11,12,14
		/// </summary>
		private event SyncObject_SyncStartEventHandler _SyncStartEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event SyncObject_SyncStartEventHandler SyncStartEvent
		{
			add
			{
				CreateEventBridge();
				_SyncStartEvent += value;
			}
			remove
			{
				_SyncStartEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 9,10,11,12,14
		/// </summary>
		private event SyncObject_ProgressEventHandler _ProgressEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event SyncObject_ProgressEventHandler ProgressEvent
		{
			add
			{
				CreateEventBridge();
				_ProgressEvent += value;
			}
			remove
			{
				_ProgressEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 9,10,11,12,14
		/// </summary>
		private event SyncObject_OnErrorEventHandler _OnErrorEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event SyncObject_OnErrorEventHandler OnErrorEvent
		{
			add
			{
				CreateEventBridge();
				_OnErrorEvent += value;
			}
			remove
			{
				_OnErrorEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary Outlook, 9,10,11,12,14
		/// </summary>
		private event SyncObject_SyncEndEventHandler _SyncEndEvent;

		/// <summary>
		/// SupportByLibrary Outlook 9 10 11 12 14
		/// </summary>
		[SupportByLibrary("Outlook", 9,10,11,12,14)]
		public event SyncObject_SyncEndEventHandler SyncEndEvent
		{
			add
			{
				CreateEventBridge();
				_SyncEndEvent += value;
			}
			remove
			{
				_SyncEndEvent -= value;
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
			if( null != _syncObjectEvents_SinkHelper)
			{
				_syncObjectEvents_SinkHelper.Dispose();
				_syncObjectEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}