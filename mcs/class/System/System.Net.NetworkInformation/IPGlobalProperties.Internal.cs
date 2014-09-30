//
// System.Net.NetworkInformation.IPGlobalProperties
//
// Authors:
//	Gonzalo Paniagua Javier (gonzalo@novell.com)
//	Atsushi Enomoto (atsushi@ximian.com)
//
// Copyright (c) 2006-2007 Novell, Inc. (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

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
		[DllImport ("libc")]
		static extern int gethostname ([MarshalAs (UnmanagedType.LPArray, SizeParamIndex = 1)] byte [] name, int len);
		
		[DllImport ("libc")]
		static extern int getdomainname ([MarshalAs (UnmanagedType.LPArray, SizeParamIndex = 1)] byte [] name, int len);

	}
	 partial class Win32IPGlobalProperties
	{
		
		[DllImport ("Iphlpapi.dll")]
		static extern int GetTcpTable (byte [] pTcpTable, ref int pdwSize, bool bOrder);
		
		[DllImport ("Iphlpapi.dll")]
		static extern int GetTcp6Table (byte [] TcpTable, ref int SizePointer, bool Order);
		
		[DllImport ("Iphlpapi.dll")]
		static extern int GetUdpTable (byte [] pUdpTable, ref int pdwSize, bool bOrder);
		
		[DllImport ("Iphlpapi.dll")]
		static extern int GetUdp6Table (byte [] Udp6Table, ref int SizePointer, bool Order);
		
		[DllImport ("Iphlpapi.dll")]
		static extern int GetTcpStatisticsEx (out Win32_MIB_TCPSTATS pStats, int dwFamily);
		
		[DllImport ("Iphlpapi.dll")]
		static extern int GetUdpStatisticsEx (out Win32_MIB_UDPSTATS pStats, int dwFamily);
		
		[DllImport ("Iphlpapi.dll")]
		static extern int GetIcmpStatistics (out Win32_MIBICMPINFO pStats, int dwFamily);
		
		[DllImport ("Iphlpapi.dll")]
		static extern int GetIcmpStatisticsEx (out Win32_MIB_ICMP_EX pStats, int dwFamily);
		
		[DllImport ("Iphlpapi.dll")]
		static extern int GetIpStatisticsEx (out Win32_MIB_IPSTATS pStats, int dwFamily);

	}
}
