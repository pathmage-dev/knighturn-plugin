global using System;
global using Godot;
global using pathmage.ToolKit;
global using pathmage.ToolKit.Collections;
global using static pathmage.ToolKit.Debug.ILogger;
using pathmage.ToolKit.Debug;

namespace KnighturnPlugin;

public sealed partial class KnighturnPlugin : Node
{
	static KnighturnPlugin()
	{
		Logger.Singleton = new LoggerWrapper(GD.Print);
		print("Godot now works with ToolKit's print commands!");
	}
}
