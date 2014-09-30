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
using System.Net;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Net.NetworkInformation
{
	 partial class Win32_FIXED_INFO
	{
		static int GetNetworkParams (byte [] bytes, ref int size)
		{
			throw new System.NotImplementedException();
		}

	}
}

#endif
