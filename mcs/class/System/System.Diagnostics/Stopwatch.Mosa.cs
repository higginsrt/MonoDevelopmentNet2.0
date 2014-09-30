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

using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace System.Diagnostics
{
	public partial class Stopwatch
	{
		public static long GetTimestamp ()
		{
			throw new System.NotImplementedException();
		}

	}
}
#endif