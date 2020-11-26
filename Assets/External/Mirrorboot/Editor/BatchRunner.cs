using System;
using System.IO;
using System.Diagnostics;
using UnityEngine;

namespace AriaSDK.MirrorBoot.Editor
{

	internal sealed class BatchRunner
	{

		#region Field

		string path = string.Empty;
		string exec = string.Empty;

		#endregion // Field End.

		#region Method

		/// <summary>
		///  constructor.
		/// </summary>
		/// <param name="path"></param>
		/// <param name="exec"></param>
		public BatchRunner(string path, string exec)
		{
			this.path = path;
			this.exec = exec;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="arguments"></param>
		/// <returns></returns>
		public string Run(string arguments = "")
		{
			var cmdParam = new ProcessStartInfo
			{
				UseShellExecute = false,
				RedirectStandardOutput = true,
				RedirectStandardInput = true,
				CreateNoWindow = true,
				Arguments = arguments
			};

			return Run(cmdParam);
		}

		public string Run(ProcessStartInfo param)
		{
			if (!TryGetExecPath(out var execPath))
			{
				return null;
			}

			param.FileName = string.IsNullOrEmpty(param.FileName) ?
				execPath : param.FileName;

			string result = "";
			var process = Process.Start(param);
			{
				result = process.StandardOutput.ReadToEnd();

				process.WaitForExit();
				process.Close();
			}

			return result;
		}

		private bool TryGetExecPath(out string execPath)
		{
			execPath = "";

			if (string.IsNullOrEmpty(exec) || string.IsNullOrEmpty(path))
			{
				UnityEngine.Debug.Log("parameters empty!!");
				return false;
			}

			if (!Directory.Exists(path))
			{
				UnityEngine.Debug.Log("invalid path!! ,maybe reconfirm target path.");
				return false;
			}

			execPath = $"{Path.Combine(path, exec)}";

			if (!File.Exists(execPath))
			{
				UnityEngine.Debug.Log("invalid file!! ,maybe wrong file name.");
				return false;
			}

			return true;
		}

		#endregion // Method End.
	}
}
