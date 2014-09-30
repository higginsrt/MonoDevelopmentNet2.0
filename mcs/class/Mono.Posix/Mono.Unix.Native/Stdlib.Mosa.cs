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
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Mono.Unix.Native;

namespace Mono.Unix.Native
{
	public partial class Stdlib
	{
		private static void SetLastError (int error)
		{
			throw new System.NotImplementedException();
		}
		internal static void InvokeSignalHandler (int signum, IntPtr handler)
		{
			throw new System.NotImplementedException();
		}
		private static IntPtr GetDefaultSignal ()
		{
			throw new System.NotImplementedException();
		}
		private static IntPtr GetErrorSignal ()
		{
			throw new System.NotImplementedException();
		}
		private static IntPtr GetIgnoreSignal ()
		{
			throw new System.NotImplementedException();
		}
		private static IntPtr sys_signal (int signum, SignalHandler handler)
		{
			throw new System.NotImplementedException();
		}
		private static IntPtr sys_signal (int signum, IntPtr handler)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_raise (int sig)
		{
			throw new System.NotImplementedException();
		}
		private static int GetFullyBuffered ()
		{
			throw new System.NotImplementedException();
		}
		private static int GetLineBuffered ()
		{
			throw new System.NotImplementedException();
		}
		private static int GetNonBuffered ()
		{
			throw new System.NotImplementedException();
		}
		private static int GetBufferSize ()
		{
			throw new System.NotImplementedException();
		}
		internal static IntPtr CreateFilePosition ()
		{
			throw new System.NotImplementedException();
		}
		internal static int DumpFilePosition (StringBuilder buf, HandleRef handle, int len)
		{
			throw new System.NotImplementedException();
		}
		private static int GetEOF ()
		{
			throw new System.NotImplementedException();
		}
		private static int GetFilenameMax ()
		{
			throw new System.NotImplementedException();
		}
		private static int GetFopenMax ()
		{
			throw new System.NotImplementedException();
		}
		private static int GetTmpnamLength ()
		{
			throw new System.NotImplementedException();
		}
		private static IntPtr GetStandardInput ()
		{
			throw new System.NotImplementedException();
		}
		private static IntPtr GetStandardOutput ()
		{
			throw new System.NotImplementedException();
		}
		private static IntPtr GetStandardError ()
		{
			throw new System.NotImplementedException();
		}
		private static int GetTmpMax ()
		{
			throw new System.NotImplementedException();
		}
		public static int remove (
		string filename)
		{
			throw new System.NotImplementedException();
		}
		public static int rename (
		string oldpath,
		string newpath)
		{
			throw new System.NotImplementedException();
		}
		public static IntPtr tmpfile ()
		{
			throw new System.NotImplementedException();
		}
		private static IntPtr sys_tmpnam (StringBuilder s)
		{
			throw new System.NotImplementedException();
		}
		public static int fclose (IntPtr stream)
		{
			throw new System.NotImplementedException();
		}
		public static int fflush (IntPtr stream)
		{
			throw new System.NotImplementedException();
		}
		public static IntPtr fopen (
		string path, string mode)
		{
			throw new System.NotImplementedException();
		}
		public static IntPtr freopen (
		string path, string mode, IntPtr stream)
		{
			throw new System.NotImplementedException();
		}
		public static int setbuf (IntPtr stream, IntPtr buf)
		{
			throw new System.NotImplementedException();
		}
		public static int setvbuf (IntPtr stream, IntPtr buf, int mode, ulong size)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_fprintf (IntPtr stream, string format, string message)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_printf (string format, string message)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_snprintf (StringBuilder s, ulong n,
		string format, string message)
		{
			throw new System.NotImplementedException();
		}
		public static int fgetc (IntPtr stream)
		{
			throw new System.NotImplementedException();
		}
		private static IntPtr sys_fgets (StringBuilder sb, int size, IntPtr stream)
		{
			throw new System.NotImplementedException();
		}
		public static int fputc (int c, IntPtr stream)
		{
			throw new System.NotImplementedException();
		}
		public static int fputs (string s, IntPtr stream)
		{
			throw new System.NotImplementedException();
		}
		public static int getc (IntPtr stream)
		{
			throw new System.NotImplementedException();
		}
		public static int getchar ()
		{
			throw new System.NotImplementedException();
		}
		public static int putc (int c, IntPtr stream)
		{
			throw new System.NotImplementedException();
		}
		public static int putchar (int c)
		{
			throw new System.NotImplementedException();
		}
		public static int puts (string s)
		{
			throw new System.NotImplementedException();
		}
		public static int ungetc (int c, IntPtr stream)
		{
			throw new System.NotImplementedException();
		}
		public static ulong fread (IntPtr ptr, ulong size, ulong nmemb, IntPtr stream)
		{
			throw new System.NotImplementedException();
		}
		private static ulong sys_fread ([Out] byte[] ptr,
		ulong size, ulong nmemb, IntPtr stream)
		{
			throw new System.NotImplementedException();
		}
		public static ulong fwrite (IntPtr ptr, ulong size, ulong nmemb, IntPtr stream)
		{
			throw new System.NotImplementedException();
		}
		private static ulong sys_fwrite (byte[] ptr,
		ulong size, ulong nmemb, IntPtr stream)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_fgetpos (IntPtr stream, HandleRef pos)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_fseek (IntPtr stream, long offset, int origin)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_fsetpos (IntPtr stream, HandleRef pos)
		{
			throw new System.NotImplementedException();
		}
		public static long ftell (IntPtr stream)
		{
			throw new System.NotImplementedException();
		}
		public static int rewind (IntPtr stream)
		{
			throw new System.NotImplementedException();
		}
		public static int clearerr (IntPtr stream)
		{
			throw new System.NotImplementedException();
		}
		public static int feof (IntPtr stream)
		{
			throw new System.NotImplementedException();
		}
		public static int ferror (IntPtr stream)
		{
			throw new System.NotImplementedException();
		}
		private static int perror (string s, int err)
		{
			throw new System.NotImplementedException();
		}
		private static int GetExitFailure()
		{
			throw new System.NotImplementedException();
		}
		private static int GetExitSuccess ()
		{
			throw new System.NotImplementedException();
		}
		private static int GetMbCurMax ()
		{
			throw new System.NotImplementedException();
		}
		private static int GetRandMax ()
		{
			throw new System.NotImplementedException();
		}
		public static int rand ()
		{
			throw new System.NotImplementedException();
		}
		public static void srand (uint seed)
		{
			throw new System.NotImplementedException();
		}
		public static IntPtr calloc (ulong nmemb, ulong size)
		{
			throw new System.NotImplementedException();
		}
		public static void free (IntPtr ptr)
		{
			throw new System.NotImplementedException();
		}
		public static IntPtr malloc (ulong size)
		{
			throw new System.NotImplementedException();
		}
		public static IntPtr realloc (IntPtr ptr, ulong size)
		{
			throw new System.NotImplementedException();
		}
		public static void abort ()
		{
			throw new System.NotImplementedException();
		}
		public static void exit (int status)
		{
			throw new System.NotImplementedException();
		}
		public static void _Exit (int status)
		{
			throw new System.NotImplementedException();
		}
		private static IntPtr sys_getenv (string name)
		{
			throw new System.NotImplementedException();
		}
		public static int system (string @string)
		{
			throw new System.NotImplementedException();
		}
		private static IntPtr sys_strerror (int errnum)
		{
			throw new System.NotImplementedException();
		}
		public static ulong strlen (IntPtr s)
		{
			throw new System.NotImplementedException();
		}

	}
}
