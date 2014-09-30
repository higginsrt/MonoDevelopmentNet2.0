/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Net.NetworkInformation
{
	 partial class MibIPGlobalProperties
	{
		static int gethostname ([MarshalAs (UnmanagedType.LPArray, SizeParamIndex = 1)] byte [] name, int len)
		{
			throw new System.NotImplementedException();
		}
		static int getdomainname ([MarshalAs (UnmanagedType.LPArray, SizeParamIndex = 1)] byte [] name, int len)
		{
			throw new System.NotImplementedException();
		}

	}
	 partial class Win32IPGlobalProperties
	{
		static int GetTcpTable (byte [] pTcpTable, ref int pdwSize, bool bOrder)
		{
			throw new System.NotImplementedException();
		}
		static int GetTcp6Table (byte [] TcpTable, ref int SizePointer, bool Order)
		{
			throw new System.NotImplementedException();
		}
		static int GetUdpTable (byte [] pUdpTable, ref int pdwSize, bool bOrder)
		{
			throw new System.NotImplementedException();
		}
		static int GetUdp6Table (byte [] Udp6Table, ref int SizePointer, bool Order)
		{
			throw new System.NotImplementedException();
		}
		static int GetTcpStatisticsEx (out Win32_MIB_TCPSTATS pStats, int dwFamily)
		{
			throw new System.NotImplementedException();
		}
		static int GetUdpStatisticsEx (out Win32_MIB_UDPSTATS pStats, int dwFamily)
		{
			throw new System.NotImplementedException();
		}
		static int GetIcmpStatistics (out Win32_MIBICMPINFO pStats, int dwFamily)
		{
			throw new System.NotImplementedException();
		}
		static int GetIcmpStatisticsEx (out Win32_MIB_ICMP_EX pStats, int dwFamily)
		{
			throw new System.NotImplementedException();
		}
		static int GetIpStatisticsEx (out Win32_MIB_IPSTATS pStats, int dwFamily)
		{
			throw new System.NotImplementedException();
		}

	}
}
