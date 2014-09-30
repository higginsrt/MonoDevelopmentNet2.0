//
// System.Diagnostics.Process.cs
//
// Authors:
// 	Dick Porter (dick@ximian.com)
// 	Andreas Nahr (ClassDevelopment@A-SoftTech.com)
//	Gonzalo Paniagua Javier (gonzalo@ximian.com)
//
// (C) 2002 Ximian, Inc.
// (C) 2003 Andreas Nahr
// (c) 2004,2005,2006 Novell, Inc. (http://www.novell.com)
//

//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

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
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static int ExitCode_internal(IntPtr handle);
		
		/* Returns the process start time in Windows file
		* times (ticks from DateTime(1/1/1601 00:00 GMT))
		*/
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static long ExitTime_internal(IntPtr handle);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static bool GetWorkingSet_internal(IntPtr handle, out int min, out int max);
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static bool SetWorkingSet_internal(IntPtr handle, int min, int max, bool use_min);
		
		/* Returns the list of process modules.  The main module is
		* element 0.
		*/
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern ProcessModule[] GetModules_internal(IntPtr handle);
		
		/* data type is from the MonoProcessData enum in mono-proclib.h in the runtime */
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static long GetProcessData (int pid, int data_type, out int error);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		static extern int GetPriorityClass (IntPtr handle, out int error);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		static extern bool SetPriorityClass (IntPtr handle, int priority, out int error);
#endif
		
		/* the meaning of type is as follows: 0: user, 1: system, 2: total */
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static long Times (IntPtr handle, int type);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static string ProcessName_internal(IntPtr handle);
		
		/* Returns the process start time in Windows file
		* times (ticks from DateTime(1/1/1601 00:00 GMT))
		*/
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static long StartTime_internal(IntPtr handle);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static bool Kill_internal (IntPtr handle, int signo);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static IntPtr GetProcess_internal(int pid);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static int GetPid_internal();
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static int[] GetProcesses_internal();
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static bool ShellExecuteEx_internal(ProcessStartInfo startInfo,
		ref ProcInfo proc_info);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static bool CreateProcess_internal(ProcessStartInfo startInfo,
		IntPtr stdin,
		IntPtr stdout,
		IntPtr stderr,
		ref ProcInfo proc_info);
		
		/* Waits up to ms milliseconds for process 'handle' to
		* exit.  ms can be <0 to mean wait forever.
		*/
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern bool WaitForExit_internal(IntPtr handle, int ms);
		
		/* Waits up to ms milliseconds for process 'handle' to 
		* wait for input.  ms can be <0 to mean wait forever.
		*/
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern bool WaitForInputIdle_internal(IntPtr handle, int ms);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern void Process_free_internal(IntPtr handle);

		 partial class ProcessWaitHandle
		{
			[MethodImplAttribute (MethodImplOptions.InternalCall)]
			private extern static IntPtr ProcessHandle_duplicate (IntPtr handle);

		}
	}
}
