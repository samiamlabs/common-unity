// Generated by gencs from file turtlesim/SetPen.srv
// DO NOT EDIT THIS FILE BY HAND


using SIGVerse.RosBridge.turtlesim;

namespace SIGVerse.RosBridge 
{
	namespace turtlesim 
	{
		public class SetPen : RosBridgeServiceProvider<turtlesim.SetPenRequest>
		{
			public SetPen(string serviceName) : base(serviceName)
			{
				base.type = "turtlesim/SetPen";
			}

			public SetPen(string serviceName, string typeName = "turtlesim/SetPen") : base(serviceName, typeName) 
			{
			}
		}
	} // namespace turtlesim
} // namespace SIGVerse.ROSBridge

