//
// System.IO.Ports.WinSerialStream.cs
//
// Authors:
//	Carlos Alberto Cortez (calberto.cortez@gmail.com)
//
// (c) Copyright 2006 Novell, Inc. (http://www.novell.com)
//

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
		
		[DllImport("kernel32", SetLastError = true)]
		static extern int CreateFile(string port_name, uint desired_access,
		uint share_mode, uint security_attrs, uint creation, uint flags,
		uint template);
		
		[DllImport("kernel32", SetLastError = true)]
		static extern bool SetupComm(int handle, int read_buffer_size, int write_buffer_size);
		
		[DllImport("kernel32", SetLastError = true)]
		static extern bool PurgeComm(int handle, uint flags);
		
		[DllImport("kernel32", SetLastError = true)]
		static extern bool SetCommTimeouts(int handle, Timeouts timeouts);
		
		[DllImport("kernel32", SetLastError = true)]
		static extern bool CloseHandle (int handle);
		
#if !TARGET_JVM
		[DllImport("kernel32", SetLastError = true)]
		static extern unsafe bool ReadFile (int handle, byte* buffer, int bytes_to_read,
		out int bytes_read, IntPtr overlapped);
		
		[DllImport("kernel32", SetLastError = true)]
		static extern unsafe bool GetOverlappedResult (int handle, IntPtr overlapped,
		ref int bytes_transfered, bool wait);
		
#if !TARGET_JVM
		[DllImport("kernel32", SetLastError = true)]
		static extern unsafe bool WriteFile (int handle, byte* buffer, int bytes_to_write,
		out int bytes_written, IntPtr overlapped);
		
		[DllImport("kernel32", SetLastError = true)]
		static extern bool GetCommState (int handle, [Out] DCB dcb);
		
		[DllImport ("kernel32", SetLastError=true)]
		static extern bool SetCommState (int handle, DCB dcb);
		
		[DllImport ("kernel32", SetLastError=true)]
		static extern bool ClearCommError (int handle, out uint errors, out CommStat stat);
		
		[DllImport ("kernel32", SetLastError=true)]
		static extern bool GetCommModemStatus (int handle, out uint flags);
		
		[DllImport ("kernel32", SetLastError=true)]
		static extern bool EscapeCommFunction (int handle, uint flags);

	}
}
