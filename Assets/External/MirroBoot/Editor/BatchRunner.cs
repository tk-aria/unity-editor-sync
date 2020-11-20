using System;
using System.Diagnostics;
using UnityEngine;

namespace AriaSDK.MirrorBoot.Editor
{
	internal sealed class BatchRunner
	{
		const string FILE_NAME = "setupSynchronzableProject.sh";

		public void Run()
		{
			string shell = $"{Application.dataPath}/External/MirroBoot/{FILE_NAME}";
			//string shell = $"./Assets/External/MirroBoot/{FILE_NAME}";
			//string shell = $"ls";


			UnityEngine.Debug.Log(shell);

			System.Diagnostics.Process p = new System.Diagnostics.Process();

			p.StartInfo.FileName = shell;
			p.StartInfo.UseShellExecute = false;
			p.StartInfo.RedirectStandardOutput = true;
			p.StartInfo.RedirectStandardInput = true;
			p.StartInfo.CreateNoWindow = true;
			p.StartInfo.Arguments = "";
			p.Start();

			string results = p.StandardOutput.ReadToEnd();

			p.WaitForExit();
			p.Close();

			UnityEngine.Debug.Log(results);

			//return results;

			/*
			string shell = $"{Application.dataPath}/External/MirrorBoot/{FILE_NAME}";
			UnityEngine.Debug.Log(shell);

			var cmdParam = new ProcessStartInfo
			{
				FileName = $"{Application.dataPath}/External/MirrorBoot/{FILE_NAME}",
			};

			Process.Start(cmdParam);
			*/
		}
	}
}
