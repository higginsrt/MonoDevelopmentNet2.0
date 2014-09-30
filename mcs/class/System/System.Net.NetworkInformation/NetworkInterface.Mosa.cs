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
using System.Collections.Generic;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.IO;
using System.Globalization;

namespace System.Net.NetworkInformation
{
	public partial class NetworkInterface
	{
		static int uname (IntPtr buf)
		{
			throw new System.NotImplementedException();
		}

	}
	 partial class UnixNetworkInterface
	{
		static int if_nametoindex(string ifname)
		{
			throw new System.NotImplementedException();
		}

	}
	 partial class LinuxNetworkInterface
	{
		static int getifaddrs (out IntPtr ifap)
		{
			throw new System.NotImplementedException();
		}
		static void freeifaddrs (IntPtr ifap)
		{
			throw new System.NotImplementedException();
		}

	}
	 partial class MacOsNetworkInterface
	{
		static int getifaddrs (out IntPtr ifap)
		{
			throw new System.NotImplementedException();
		}
		static void freeifaddrs (IntPtr ifap)
		{
			throw new System.NotImplementedException();
		}

	}
	 partial class Win32NetworkInterface2
	{
		static int GetAdaptersInfo (byte [] info, ref int size)
		{
			throw new System.NotImplementedException();
		}
		static int GetAdaptersAddresses (uint family, uint flags, IntPtr reserved, byte [] info, ref int size)
		{
			throw new System.NotImplementedException();
		}
		static int GetIfEntry (ref Win32_MIB_IFROW row)
		{
			throw new System.NotImplementedException();
		}

	}
}

#endif
