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
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

#if MONOTOUCH
using MonoTouch;
#endif

namespace System.IO.Compression
{
	public partial class DeflateStream
	{
		static IntPtr CreateZStream (CompressionMode compress, bool gzip, UnmanagedReadOrWrite feeder, IntPtr data)
		{
			throw new System.NotImplementedException();
		}
		static int CloseZStream (IntPtr stream)
		{
			throw new System.NotImplementedException();
		}
		static int Flush (IntPtr stream)
		{
			throw new System.NotImplementedException();
		}
		static int ReadZStream (IntPtr stream, IntPtr buffer, int length)
		{
			throw new System.NotImplementedException();
		}
		static int WriteZStream (IntPtr stream, IntPtr buffer, int length)
		{
			throw new System.NotImplementedException();
		}

	}
}
#endif