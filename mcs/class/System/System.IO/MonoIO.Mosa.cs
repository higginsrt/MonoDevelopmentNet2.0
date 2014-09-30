/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

using System;
using System.Runtime.CompilerServices;

namespace System.IO
{
	 partial class MonoIO
	{
		public static bool Close (IntPtr handle,
		out MonoIOError error)
		{
			throw new System.NotImplementedException();
		}
		public static IntPtr ConsoleOutput {
			get
			{
				throw new System.NotImplementedException();
			}
		}
		public static IntPtr ConsoleInput {
			get
			{
				throw new System.NotImplementedException();
			}
		}
		public static IntPtr ConsoleError {
			get
			{
				throw new System.NotImplementedException();
			}
		}
		public static bool CreatePipe (out IntPtr read_handle, out IntPtr write_handle)
		{
			throw new System.NotImplementedException();
		}
		public static bool DuplicateHandle (IntPtr source_process_handle, IntPtr source_handle,
		IntPtr target_process_handle, out IntPtr target_handle, int access, int inherit, int options)
		{
			throw new System.NotImplementedException();
		}
		public static int GetTempPath(out string path)
		{
			throw new System.NotImplementedException();
		}

	}
}
