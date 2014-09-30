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
using System.Runtime.InteropServices;
using System.Threading;

using Mono.Unix.Native;

namespace Mono.Unix
{
	public partial class UnixSignal
	{
		private static IntPtr install (int signum)
		{
			throw new System.NotImplementedException();
		}
		private static int uninstall (IntPtr info)
		{
			throw new System.NotImplementedException();
		}
		private static int WaitAny (IntPtr[] infos, int count, int timeout, Mono_Posix_RuntimeIsShuttingDown shutting_down)
		{
			throw new System.NotImplementedException();
		}
		internal static int GetSIGRTMIN ()
		{
			throw new System.NotImplementedException();
		}
		internal static int GetSIGRTMAX ()
		{
			throw new System.NotImplementedException();
		}

	}
}
