// Generated by gencs from nav_msgs/Path.msg
// DO NOT EDIT THIS FILE BY HAND!

using System;
using System.Collections;
using System.Collections.Generic;
using SIGVerse.RosBridge;
using UnityEngine;

using SIGVerse.RosBridge.std_msgs;
using SIGVerse.RosBridge.geometry_msgs;

namespace SIGVerse.RosBridge 
{
	namespace nav_msgs 
	{
		[System.Serializable]
		public class Path : RosMessage
		{
			public std_msgs.Header header;
			public System.Collections.Generic.List<geometry_msgs.PoseStamped>  poses;


			public Path()
			{
				this.header = new std_msgs.Header();
				this.poses = new System.Collections.Generic.List<geometry_msgs.PoseStamped>();
			}

			public Path(std_msgs.Header header, System.Collections.Generic.List<geometry_msgs.PoseStamped>  poses)
			{
				this.header = header;
				this.poses = poses;
			}

			new public static string GetMessageType()
			{
				return "nav_msgs/Path";
			}

			new public static string GetMD5Hash()
			{
				return "6227e2b7e9cce15051f669a5e197bbf7";
			}
		} // class Path
	} // namespace nav_msgs
} // namespace SIGVerse.ROSBridge

