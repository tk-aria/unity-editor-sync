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
		const string FILE_NAME = "setupSynchronzableProject.sh";


		[UnityEditor.MenuItem("AriaSDK/Tools/GenerateSynchronizableProject")]
		private static void GenerateSynchronizableProject()
		{
			var runner = new BatchRunner($"{Application.dataPath}/External/MirroBoot/", $"{FILE_NAME}");
			string log = runner.Run();
			Debug.Log(log);
		}
	}
}
