/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

#if !NET_2_1
using System.IO;
using System.Runtime.CompilerServices;

namespace System
{
	 partial class ConsoleDriver
	{
		static bool Isatty (IntPtr handle)
		{
			throw new System.NotImplementedException();
		}
		internal static int InternalKeyAvailable (int ms_timeout)
		{
			throw new System.NotImplementedException();
		}
		unsafe internal static bool TtySetup (string keypadXmit, string teardown, out byte [] control_characters, out int *address)
		{
			throw new System.NotImplementedException();
		}
		internal static bool SetEcho (bool wantEcho)
		{
			throw new System.NotImplementedException();
		}
		internal static bool SetBreak (bool wantBreak)
		{
			throw new System.NotImplementedException();
		}

	}
}
#endif
