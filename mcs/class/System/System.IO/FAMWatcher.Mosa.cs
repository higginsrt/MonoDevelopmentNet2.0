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
	 partial class FAMWatcher
	{
		static int fam_Open (out FAMConnection fc)
		{
			throw new System.NotImplementedException();
		}
		static int fam_Close (ref FAMConnection fc)
		{
			throw new System.NotImplementedException();
		}
		static int fam_MonitorDirectory (ref FAMConnection fc, string filename,
		out FAMRequest fr, IntPtr user_data)
		{
			throw new System.NotImplementedException();
		}
		static int fam_CancelMonitor (ref FAMConnection fc, ref FAMRequest fr)
		{
			throw new System.NotImplementedException();
		}
		static int fam_Pending (ref FAMConnection fc)
		{
			throw new System.NotImplementedException();
		}
		static int gamin_Open (out FAMConnection fc)
		{
			throw new System.NotImplementedException();
		}
		static int gamin_Close (ref FAMConnection fc)
		{
			throw new System.NotImplementedException();
		}
		static int gamin_MonitorDirectory (ref FAMConnection fc, string filename,
		out FAMRequest fr, IntPtr user_data)
		{
			throw new System.NotImplementedException();
		}
		static int gamin_CancelMonitor (ref FAMConnection fc, ref FAMRequest fr)
		{
			throw new System.NotImplementedException();
		}
		static int gamin_Pending (ref FAMConnection fc)
		{
			throw new System.NotImplementedException();
		}
		static int InternalFAMNextEvent (ref FAMConnection fc, out string filename,
		out int code, out int reqnum)
		{
			throw new System.NotImplementedException();
		}

	}
}
