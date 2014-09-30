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
using System.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.ComponentModel;

#if NET_2_0

namespace System.IO.Ports
{
	 partial class WinSerialStream
	{
		static int CreateFile(string port_name, uint desired_access,
		uint share_mode, uint security_attrs, uint creation, uint flags,
		uint template)
		{
			throw new System.NotImplementedException();
		}
		static bool SetupComm(int handle, int read_buffer_size, int write_buffer_size)
		{
			throw new System.NotImplementedException();
		}
		static bool PurgeComm(int handle, uint flags)
		{
			throw new System.NotImplementedException();
		}
		static bool SetCommTimeouts(int handle, Timeouts timeouts)
		{
			throw new System.NotImplementedException();
		}
		static bool CloseHandle (int handle)
		{
			throw new System.NotImplementedException();
		}
		static unsafe bool ReadFile (int handle, byte* buffer, int bytes_to_read,
		out int bytes_read, IntPtr overlapped)
		{
			throw new System.NotImplementedException();
		}
		static unsafe bool GetOverlappedResult (int handle, IntPtr overlapped,
		ref int bytes_transfered, bool wait)
		{
			throw new System.NotImplementedException();
		}
		static unsafe bool WriteFile (int handle, byte* buffer, int bytes_to_write,
		out int bytes_written, IntPtr overlapped)
		{
			throw new System.NotImplementedException();
		}
		static bool GetCommState (int handle, [Out] DCB dcb)
		{
			throw new System.NotImplementedException();
		}
		static bool SetCommState (int handle, DCB dcb)
		{
			throw new System.NotImplementedException();
		}
		static bool ClearCommError (int handle, out uint errors, out CommStat stat)
		{
			throw new System.NotImplementedException();
		}
		static bool GetCommModemStatus (int handle, out uint flags)
		{
			throw new System.NotImplementedException();
		}
		static bool EscapeCommFunction (int handle, uint flags)
		{
			throw new System.NotImplementedException();
		}

	}
}

#endif