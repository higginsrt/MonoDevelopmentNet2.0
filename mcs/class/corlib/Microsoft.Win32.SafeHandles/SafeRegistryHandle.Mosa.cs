/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

#if NET_4_0

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.ConstrainedExecution;

namespace Microsoft.Win32.SafeHandles
{
	public partial class SafeRegistryHandle
	{
		static int RegCloseKey (IntPtr keyHandle)
		{
			throw new System.NotImplementedException();
		}

	}
}

#endif