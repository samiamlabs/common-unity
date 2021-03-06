// Generated by gencs from geometry_msgs/Vector3Stamped.msg
// DO NOT EDIT THIS FILE BY HAND!

using System;
using System.Collections;
using System.Collections.Generic;
using SIGVerse.ROSBridge;
using UnityEngine;

using SIGVerse.ROSBridge.std_msgs;
using SIGVerse.ROSBridge.geometry_msgs;

namespace SIGVerse.ROSBridge 
{
	namespace geometry_msgs 
	{
		[System.Serializable]
		public class Vector3Stamped : ROSMessage
		{
			public std_msgs.Header header;
			public UnityEngine.Vector3 vector;


			public Vector3Stamped()
			{
				this.header = new std_msgs.Header();
				this.vector = new UnityEngine.Vector3();
			}

			public Vector3Stamped(std_msgs.Header header, UnityEngine.Vector3 vector)
			{
				this.header = header;
				this.vector = vector;
			}

			new public static string GetMessageType()
			{
				return "geometry_msgs/Vector3Stamped";
			}

			new public static string GetMD5Hash()
			{
				return "7b324c7325e683bf02a9b14b01090ec7";
			}
		} // class Vector3Stamped
	} // namespace geometry_msgs
} // namespace SIGVerse.ROSBridge

