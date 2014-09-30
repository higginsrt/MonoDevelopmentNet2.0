/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

#if NET_2_0

using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Runtime.CompilerServices;
using System.IO;

namespace System.Threading
{
	public partial class Semaphore
	{
		private static IntPtr CreateSemaphore_internal (
		int initialCount, int maximumCount, string name,
		out bool createdNew)
		{
			throw new System.NotImplementedException();
		}
		private static int ReleaseSemaphore_internal (
		IntPtr handle, int releaseCount, out bool fail)
		{
			throw new System.NotImplementedException();
		}
		private static IntPtr OpenSemaphore_internal (string name, SemaphoreRights rights, out MonoIOError error)
		{
			throw new System.NotImplementedException();
		}

	}
}
#endif