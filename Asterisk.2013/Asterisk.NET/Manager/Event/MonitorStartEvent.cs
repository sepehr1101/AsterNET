using System;

namespace AsterNET.Manager.Event
{
	public class MonitorStartEvent : ManagerEvent
	{
		#region Constructor - MonitorStart(ManagerConnection source)
		public MonitorStartEvent(ManagerConnection source)
			: base(source)
		{
		}
		#endregion
	}
}
