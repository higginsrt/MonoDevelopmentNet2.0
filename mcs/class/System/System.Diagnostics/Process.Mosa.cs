/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

using System.IO;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Collections;
using System.Security;
using System.Threading;

namespace System.Diagnostics
{
	public partial class Process
	{
		private static int ExitCode_internal(IntPtr handle)
		{
			throw new System.NotImplementedException();
		}
		private static long ExitTime_internal(IntPtr handle)
		{
			throw new System.NotImplementedException();
		}
		private static bool GetWorkingSet_internal(IntPtr handle, out int min, out int max)
		{
			throw new System.NotImplementedException();
		}
		private static bool SetWorkingSet_internal(IntPtr handle, int min, int max, bool use_min)
		{
			throw new System.NotImplementedException();
		}
		private ProcessModule[] GetModules_internal(IntPtr handle)
		{
			throw new System.NotImplementedException();
		}
		private static long GetProcessData (int pid, int data_type, out int error)
		{
			throw new System.NotImplementedException();
		}
		static int GetPriorityClass (IntPtr handle, out int error)
		{
			throw new System.NotImplementedException();
		}
		static bool SetPriorityClass (IntPtr handle, int priority, out int error)
		{
			throw new System.NotImplementedException();
		}
		private static long Times (IntPtr handle, int type)
		{
			throw new System.NotImplementedException();
		}
		private static string ProcessName_internal(IntPtr handle)
		{
			throw new System.NotImplementedException();
		}
		private static long StartTime_internal(IntPtr handle)
		{
			throw new System.NotImplementedException();
		}
		static bool Kill_internal (IntPtr handle, int signo)
		{
			throw new System.NotImplementedException();
		}
		private static IntPtr GetProcess_internal(int pid)
		{
			throw new System.NotImplementedException();
		}
		private static int GetPid_internal()
		{
			throw new System.NotImplementedException();
		}
		private static int[] GetProcesses_internal()
		{
			throw new System.NotImplementedException();
		}
		private static bool ShellExecuteEx_internal(ProcessStartInfo startInfo,
		ref ProcInfo proc_info)
		{
			throw new System.NotImplementedException();
		}
		private static bool CreateProcess_internal(ProcessStartInfo startInfo,
		IntPtr stdin,
		IntPtr stdout,
		IntPtr stderr,
		ref ProcInfo proc_info)
		{
			throw new System.NotImplementedException();
		}
		private bool WaitForExit_internal(IntPtr handle, int ms)
		{
			throw new System.NotImplementedException();
		}
		private bool WaitForInputIdle_internal(IntPtr handle, int ms)
		{
			throw new System.NotImplementedException();
		}
		private void Process_free_internal(IntPtr handle)
		{
			throw new System.NotImplementedException();
		}

		 partial class ProcessWaitHandle
		{
			private static IntPtr ProcessHandle_duplicate (IntPtr handle)
			{
				throw new System.NotImplementedException();
			}

		}
	}
}
