// Generated by gencs from nav_msgs/GridCells.msg
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
		public class GridCells : RosMessage
		{
			public std_msgs.Header header;
			public float cell_width;
			public float cell_height;
			public System.Collections.Generic.List<UnityEngine.Vector3>  cells;


			public GridCells()
			{
				this.header = new std_msgs.Header();
				this.cell_width = 0.0f;
				this.cell_height = 0.0f;
				this.cells = new System.Collections.Generic.List<UnityEngine.Vector3>();
			}

			public GridCells(std_msgs.Header header, float cell_width, float cell_height, System.Collections.Generic.List<UnityEngine.Vector3>  cells)
			{
				this.header = header;
				this.cell_width = cell_width;
				this.cell_height = cell_height;
				this.cells = cells;
			}

			new public static string GetMessageType()
			{
				return "nav_msgs/GridCells";
			}

			new public static string GetMD5Hash()
			{
				return "b9e4f5df6d28e272ebde00a3994830f5";
			}
		} // class GridCells
	} // namespace nav_msgs
} // namespace SIGVerse.ROSBridge

