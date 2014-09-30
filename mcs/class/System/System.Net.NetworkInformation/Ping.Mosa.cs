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
using System.Text;
using System.Diagnostics;
using System.Globalization;
using System.ComponentModel;
using System.Net.Sockets;
using System.Security.Principal;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation
{
	public partial class Ping
	{
		static int capget (ref cap_user_header_t header, ref cap_user_data_t data)
		{
			throw new System.NotImplementedException();
		}

	}
}

#endif
