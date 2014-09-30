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
using System.Net;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Reflection;
using System.IO;
using System.Net.Configuration;
using System.Text;
using System.Timers;
#if !MOONLIGHT
using System.Net.NetworkInformation;
#endif

namespace System.Net.Sockets
{
	public partial class Socket
	{
		private static void Select_internal (ref Socket [] sockets,
		int microSeconds,
		out int error)
		{
			throw new System.NotImplementedException();
		}
		private static int Available_internal(IntPtr socket, out int error)
		{
			throw new System.NotImplementedException();
		}
		private static SocketAddress LocalEndPoint_internal(IntPtr socket, out int error)
		{
			throw new System.NotImplementedException();
		}
		private static IntPtr Accept_internal(IntPtr sock, out int error, bool blocking)
		{
			throw new System.NotImplementedException();
		}
		private static void Bind_internal(IntPtr sock,
		SocketAddress sa,
		out int error)
		{
			throw new System.NotImplementedException();
		}
		static void Disconnect_internal(IntPtr sock, bool reuse, out int error)
		{
			throw new System.NotImplementedException();
		}
		private static void GetSocketOption_arr_internal(IntPtr socket,
		SocketOptionLevel level, SocketOptionName name, ref byte[] byte_val,
		out int error)
		{
			throw new System.NotImplementedException();
		}
		static int WSAIoctl (IntPtr sock, int ioctl_code, byte [] input,
		byte [] output, out int error)
		{
			throw new System.NotImplementedException();
		}
		private static void Listen_internal(IntPtr sock, int backlog, out int error)
		{
			throw new System.NotImplementedException();
		}
		private static int RecvFrom_internal(IntPtr sock,
		byte[] buffer,
		int offset,
		int count,
		SocketFlags flags,
		ref SocketAddress sockaddr,
		out int error)
		{
			throw new System.NotImplementedException();
		}
		private static bool SendFile (IntPtr sock, string filename, byte [] pre_buffer, byte [] post_buffer, TransmitFileOptions flags)
		{
			throw new System.NotImplementedException();
		}
		private static int SendTo_internal(IntPtr sock,
		byte[] buffer,
		int offset,
		int count,
		SocketFlags flags,
		SocketAddress sa,
		out int error)
		{
			throw new System.NotImplementedException();
		}

	}
}
