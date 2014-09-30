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
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace System.IO
{
	 partial class InotifyWatcher
	{
		internal static int Close (IntPtr fd)
		{
			throw new System.NotImplementedException();
		}
		static int ReadFromFD (IntPtr fd, byte [] buffer, IntPtr length)
		{
			throw new System.NotImplementedException();
		}
		static IntPtr GetInotifyInstance ()
		{
			throw new System.NotImplementedException();
		}
		static int AddWatch (IntPtr fd, string name, InotifyMask mask)
		{
			throw new System.NotImplementedException();
		}
		static IntPtr RemoveWatch (IntPtr fd, int wd)
		{
			throw new System.NotImplementedException();
		}

	}
}
