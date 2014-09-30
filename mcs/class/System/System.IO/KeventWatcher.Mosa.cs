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
	 partial class KeventWatcher
	{
		static int open(string path, int flags, int mode_t)
		{
			throw new System.NotImplementedException();
		}
		static int close(int fd)
		{
			throw new System.NotImplementedException();
		}
		static int kqueue()
		{
			throw new System.NotImplementedException();
		}
		static int kevent(int kqueue, ref kevent ev, int nchanges, ref kevent evtlist,  int nevents, ref timespec ts)
		{
			throw new System.NotImplementedException();
		}

	}
}
