using System;

namespace AsterNET.Manager.Action
{
	/// <summary>
	/// The AgentsAction requests the state of all agents.<br/>
	/// For each agent an AgentsEvent is generated.
	/// After the state of all agents has been reported an AgentsCompleteEvent is generated.<br/>
	/// Available since Asterisk 1.2
	/// </summary>
	/// <seealso cref="AsterNET.Manager.Event.AgentsEvent" />
	/// <seealso cref="AsterNET.Manager.Event.AgentsCompleteEvent" />
	public class AgentsAction : ManagerActionEvent
	{
		#region Action 
		/// <summary>
		/// Get the name of this action, i.e. "Agents".
		/// </summary>
		override public string Action
		{
			get { return "Agents"; }
		}
		#endregion

		#region ActionCompleteEventClass 
		public override Type ActionCompleteEventClass()
		{
			return typeof(Event.AgentsCompleteEvent);
		}
		#endregion

		#region AgentsAction() 
		/// <summary>
		/// Creates a new AgentsAction.
		/// </summary>
		public AgentsAction()
		{
		}
		#endregion
	}
}