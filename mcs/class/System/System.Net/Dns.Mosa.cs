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
using System.Net.Sockets;
using System.Text;
using System.Collections;
using System.Threading;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;

namespace System.Net
{
	public partial class Dns
	{
		private static bool GetHostByName_internal(string host, out string h_name, out string[] h_aliases, out string[] h_addr_list)
		{
			throw new System.NotImplementedException();
		}
		private static bool GetHostByAddr_internal(string addr, out string h_name, out string[] h_aliases, out string[] h_addr_list)
		{
			throw new System.NotImplementedException();
		}
		private static bool GetHostName_internal(out string h_name)
		{
			throw new System.NotImplementedException();
		}

	}
}
