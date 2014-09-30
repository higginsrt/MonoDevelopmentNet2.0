//
// System.IO.Ports.SerialPortStream.cs
//
// Authors:
//	Chris Toshok (toshok@ximian.com)
//	Carlos Alberto Cortez (calberto.cortez@gmail.com)
//
// (c) Copyright 2006 Novell, Inc. (http://www.novell.com)
//

#if NET_2_0

using System;
using System.IO;
using System.Runtime.InteropServices;

namespace System.IO.Ports
{
	 partial class SerialPortStream
	{
		
		[DllImport ("MonoPosixHelper", SetLastError = true)]
		static extern int open_serial (string portName);
		
		[DllImport ("MonoPosixHelper", SetLastError = true)]
		static extern int read_serial (int fd, byte [] buffer, int offset, int count);
		
		[DllImport ("MonoPosixHelper", SetLastError = true)]
		static extern bool poll_serial (int fd, out int error, int timeout);
		
		[DllImport ("MonoPosixHelper", SetLastError = true)]
		static extern int write_serial (int fd, byte [] buffer, int offset, int count, int timeout);
		
		[DllImport ("MonoPosixHelper", SetLastError = true)]
		static extern int close_serial (int fd);
		
		[DllImport ("MonoPosixHelper", SetLastError = true)]
		static extern bool set_attributes (int fd, int baudRate, Parity parity, int dataBits, StopBits stopBits, Handshake handshake);
		
		[DllImport("MonoPosixHelper", SetLastError = true)]
		static extern int get_bytes_in_buffer (int fd, int input);
		
		[DllImport ("MonoPosixHelper", SetLastError = true)]
		static extern int discard_buffer (int fd, bool inputBuffer);
		
		[DllImport ("MonoPosixHelper", SetLastError = true)]
		static extern SerialSignal get_signals (int fd, out int error);
		
		[DllImport ("MonoPosixHelper", SetLastError = true)]
		static extern int set_signal (int fd, SerialSignal signal, bool value);
		
		[DllImport ("MonoPosixHelper", SetLastError = true)]
		static extern int breakprop (int fd);
		
		[DllImport ("libc")]
		static extern IntPtr strerror (int errnum);

	}
}
