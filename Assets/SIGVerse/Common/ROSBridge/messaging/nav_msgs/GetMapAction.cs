// Generated by gencs from nav_msgs/GetMapAction.msg
// DO NOT EDIT THIS FILE BY HAND!

using System;
using System.Collections;
using System.Collections.Generic;
using SIGVerse.ROSBridge;
using UnityEngine;

using SIGVerse.ROSBridge.nav_msgs;

namespace SIGVerse.ROSBridge 
{
	namespace nav_msgs 
	{
		[System.Serializable]
		public class GetMapAction : ROSMessage
		{
			public nav_msgs.GetMapActionGoal action_goal;
			public nav_msgs.GetMapActionResult action_result;
			public nav_msgs.GetMapActionFeedback action_feedback;


			public GetMapAction()
			{
				this.action_goal = new nav_msgs.GetMapActionGoal();
				this.action_result = new nav_msgs.GetMapActionResult();
				this.action_feedback = new nav_msgs.GetMapActionFeedback();
			}

			public GetMapAction(nav_msgs.GetMapActionGoal action_goal, nav_msgs.GetMapActionResult action_result, nav_msgs.GetMapActionFeedback action_feedback)
			{
				this.action_goal = action_goal;
				this.action_result = action_result;
				this.action_feedback = action_feedback;
			}

			new public static string GetMessageType()
			{
				return "nav_msgs/GetMapAction";
			}

			new public static string GetMD5Hash()
			{
				return "e611ad23fbf237c031b7536416dc7cd7";
			}
		} // class GetMapAction
	} // namespace nav_msgs
} // namespace SIGVerse.ROSBridge

