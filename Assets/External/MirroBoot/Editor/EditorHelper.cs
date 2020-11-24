using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEditor;

namespace AriaSDK.MirrorBoot.Editor
{

	/// <summary>
	/// 
	/// </summary>
	internal static class EditorHelper
	{
#if UNITY_EDITOR_WIN
		const string FILE_NAME = "setupSynchronzableProject.bat";
#else // UNITY_EDITOR_OSX
		const string FILE_NAME = "setupSynchronzableProject.sh";
#endif 

		private static string GetScriptPath()
		{
			var results = AssetDatabase.FindAssets($"")
				.Select(x => AssetDatabase.GUIDToAssetPath(x))
				.Where(x => x.Contains($"{FILE_NAME}"))
				.ToList();

			return (results.Count > 0) ? results[0].Replace($"{FILE_NAME}", ""): null;
		}

		[UnityEditor.MenuItem("AriaSDK/Tools/GenerateSynchronizableProject")]
		private static void GenerateSynchronizableProject()
		{
			var path = GetScriptPath();
			if (string.IsNullOrEmpty(path))
			{
				return;
			}

			Debug.Log(path);

			var runner = new BatchRunner($"{Application.dataPath}/External/MirroBoot/", $"{FILE_NAME}");
			string log = runner.Run();
			Debug.Log(log);
		}
	}
}
