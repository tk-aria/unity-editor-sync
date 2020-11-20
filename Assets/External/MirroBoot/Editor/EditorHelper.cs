using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace AriaSDK.MirrorBoot.Editor
{

	/// <summary>
	/// 
	/// </summary>
	internal static class EditorHelper
	{
		[UnityEditor.MenuItem("AriaSDK/Tools/GenerateSynchronizableProject")]
		private static void GenerateSynchronizableProject()
		{
			var runner = new BatchRunner();
			runner.Run();
		}
	}
}
