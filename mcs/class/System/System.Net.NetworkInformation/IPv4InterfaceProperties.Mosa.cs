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
using System.IO;
using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation
{
	 partial class Win32IPv4InterfaceProperties
	{
		static int GetPerAdapterInfo (int IfIndex, Win32_IP_PER_ADAPTER_INFO pPerAdapterInfo, ref int pOutBufLen)
		{
			throw new System.NotImplementedException();
		}

	}
}
#endif