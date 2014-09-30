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
using System.Runtime.InteropServices;

namespace System.IO.Ports
{
	 partial class SerialPortStream
	{
		static int open_serial (string portName)
		{
			throw new System.NotImplementedException();
		}
		static int read_serial (int fd, byte [] buffer, int offset, int count)
		{
			throw new System.NotImplementedException();
		}
		static bool poll_serial (int fd, out int error, int timeout)
		{
			throw new System.NotImplementedException();
		}
		static int write_serial (int fd, byte [] buffer, int offset, int count, int timeout)
		{
			throw new System.NotImplementedException();
		}
		static int close_serial (int fd)
		{
			throw new System.NotImplementedException();
		}
		static bool set_attributes (int fd, int baudRate, Parity parity, int dataBits, StopBits stopBits, Handshake handshake)
		{
			throw new System.NotImplementedException();
		}
		static int get_bytes_in_buffer (int fd, int input)
		{
			throw new System.NotImplementedException();
		}
		static int discard_buffer (int fd, bool inputBuffer)
		{
			throw new System.NotImplementedException();
		}
		static SerialSignal get_signals (int fd, out int error)
		{
			throw new System.NotImplementedException();
		}
		static int set_signal (int fd, SerialSignal signal, bool value)
		{
			throw new System.NotImplementedException();
		}
		static int breakprop (int fd)
		{
			throw new System.NotImplementedException();
		}
		static IntPtr strerror (int errnum)
		{
			throw new System.NotImplementedException();
		}

	}
}
#endif
