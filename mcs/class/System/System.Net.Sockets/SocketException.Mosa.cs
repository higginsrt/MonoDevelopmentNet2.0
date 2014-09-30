/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

using System.Runtime.Serialization;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Net.Sockets
{
	public partial class SocketException
	{
		private static int WSAGetLastError_internal ()
		{
			throw new System.NotImplementedException();
		}

	}
}
