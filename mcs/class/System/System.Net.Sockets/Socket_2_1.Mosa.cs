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
using System.IO;
using System.Security;
using System.Text;

#if !NET_2_1
using System.Net.Configuration;
using System.Net.NetworkInformation;
#endif

namespace System.Net.Sockets
{
	public partial class Socket
	{
		private IntPtr Socket_internal(AddressFamily family,
		SocketType type,
		ProtocolType proto,
		out int error)
		{
			throw new System.NotImplementedException();
		}
		private static void Blocking_internal(IntPtr socket,
		bool block,
		out int error)
		{
			throw new System.NotImplementedException();
		}
		private static SocketAddress RemoteEndPoint_internal(IntPtr socket, out int error)
		{
			throw new System.NotImplementedException();
		}
		private static void Close_internal(IntPtr socket, out int error)
		{
			throw new System.NotImplementedException();
		}
		private static void Connect_internal(IntPtr sock,
		SocketAddress sa,
		out int error)
		{
			throw new System.NotImplementedException();
		}
		static bool Poll_internal (IntPtr socket, SelectMode mode, int timeout, out int error)
		{
			throw new System.NotImplementedException();
		}
		private static int Receive_internal(IntPtr sock,
		byte[] buffer,
		int offset,
		int count,
		SocketFlags flags,
		out int error)
		{
			throw new System.NotImplementedException();
		}
		private static void GetSocketOption_obj_internal(IntPtr socket,
		SocketOptionLevel level, SocketOptionName name, out object obj_val,
		out int error)
		{
			throw new System.NotImplementedException();
		}
		private static int Send_internal(IntPtr sock,
		byte[] buf, int offset,
		int count,
		SocketFlags flags,
		out int error)
		{
			throw new System.NotImplementedException();
		}
		private static void Shutdown_internal (IntPtr socket, SocketShutdown how, out int error)
		{
			throw new System.NotImplementedException();
		}
		private static void SetSocketOption_internal (IntPtr socket, SocketOptionLevel level,
		SocketOptionName name, object obj_val,
		byte [] byte_val, int int_val,
		out int error)
		{
			throw new System.NotImplementedException();
		}
		private static int Receive_internal (IntPtr sock, WSABUF[] bufarray, SocketFlags flags, out int error)
		{
			throw new System.NotImplementedException();
		}
		private static int Send_internal (IntPtr sock, WSABUF[] bufarray, SocketFlags flags, out int error)
		{
			throw new System.NotImplementedException();
		}
		static void socket_pool_queue (SocketAsyncCall d, SocketAsyncResult r)
		{
			throw new System.NotImplementedException();
		}

	}
}
