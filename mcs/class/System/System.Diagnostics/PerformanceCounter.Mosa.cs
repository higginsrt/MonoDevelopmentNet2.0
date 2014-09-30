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
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
#if NET_2_0
using System.Runtime.ConstrainedExecution;
#endif

namespace System.Diagnostics
{
	public partial class PerformanceCounter
	{
		static IntPtr GetImpl (string category, string counter,
		string instance, string machine, out PerformanceCounterType ctype, out bool custom)
		{
			throw new System.NotImplementedException();
		}
		static bool GetSample (IntPtr impl, bool only_value, out CounterSample sample)
		{
			throw new System.NotImplementedException();
		}
		static long UpdateValue (IntPtr impl, bool do_incr, long value)
		{
			throw new System.NotImplementedException();
		}
		static void FreeData (IntPtr impl)
		{
			throw new System.NotImplementedException();
		}

	}
}
