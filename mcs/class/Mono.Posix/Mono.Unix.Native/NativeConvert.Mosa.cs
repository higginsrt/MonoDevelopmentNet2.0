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
using System.IO;
using System.Runtime.InteropServices;
using Mono.Unix.Native;

namespace Mono.Unix.Native
{
	public partial class NativeConvert
	{
		private static int FromRealTimeSignum (Int32 offset, out Int32 rval)
		{
			throw new System.NotImplementedException();
		}
		private static int FromStatvfs (ref Statvfs source, IntPtr destination)
		{
			throw new System.NotImplementedException();
		}
		private static int ToStatvfs (IntPtr source, out Statvfs destination)
		{
			throw new System.NotImplementedException();
		}

	}
}
