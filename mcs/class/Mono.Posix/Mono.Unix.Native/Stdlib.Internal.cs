//
// Mono.Unix/Stdlib.cs
//
// Authors:
//   Jonathan Pryor (jonpryor@vt.edu)
//
// (C) 2004-2006 Jonathan Pryor
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

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
		
		[DllImport (MPH, CallingConvention=CallingConvention.Cdecl,
		EntryPoint="Mono_Posix_Stdlib_SetLastError")]
		private static extern void SetLastError (int error);
		
		[DllImport (MPH, CallingConvention=CallingConvention.Cdecl,
		EntryPoint="Mono_Posix_Stdlib_InvokeSignalHandler")]
		internal static extern void InvokeSignalHandler (int signum, IntPtr handler);
		
		[DllImport (MPH, CallingConvention=CallingConvention.Cdecl,
		EntryPoint="Mono_Posix_Stdlib_SIG_DFL")]
		private static extern IntPtr GetDefaultSignal ();
		
		[DllImport (MPH, CallingConvention=CallingConvention.Cdecl,
		EntryPoint="Mono_Posix_Stdlib_SIG_ERR")]
		private static extern IntPtr GetErrorSignal ();
		
		[DllImport (MPH, CallingConvention=CallingConvention.Cdecl,
		EntryPoint="Mono_Posix_Stdlib_SIG_IGN")]
		private static extern IntPtr GetIgnoreSignal ();
		
		[DllImport (LIBC, CallingConvention=CallingConvention.Cdecl,
		SetLastError=true, EntryPoint="signal")]
		private static extern IntPtr sys_signal (int signum, SignalHandler handler);
		
		[DllImport (LIBC, CallingConvention=CallingConvention.Cdecl,
		SetLastError=true, EntryPoint="signal")]
		private static extern IntPtr sys_signal (int signum, IntPtr handler);
		
		[DllImport (LIBC, CallingConvention=CallingConvention.Cdecl, EntryPoint="raise")]
		private static extern int sys_raise (int sig);
		
		[DllImport (MPH, CallingConvention=CallingConvention.Cdecl,
		EntryPoint="Mono_Posix_Stdlib__IOFBF")]
		private static extern int GetFullyBuffered ();
		
		[DllImport (MPH, CallingConvention=CallingConvention.Cdecl,
		EntryPoint="Mono_Posix_Stdlib__IOLBF")]
		private static extern int GetLineBuffered ();
		
		[DllImport (MPH, CallingConvention=CallingConvention.Cdecl,
		EntryPoint="Mono_Posix_Stdlib__IONBF")]
		private static extern int GetNonBuffered ();
		
		[DllImport (MPH, CallingConvention=CallingConvention.Cdecl,
		EntryPoint="Mono_Posix_Stdlib_BUFSIZ")]
		private static extern int GetBufferSize ();
		
		[DllImport (MPH, CallingConvention=CallingConvention.Cdecl,
		EntryPoint="Mono_Posix_Stdlib_CreateFilePosition")]
		internal static extern IntPtr CreateFilePosition ();
		
		[DllImport (MPH, CallingConvention=CallingConvention.Cdecl,
		EntryPoint="Mono_Posix_Stdlib_DumpFilePosition")]
		internal static extern int DumpFilePosition (StringBuilder buf, HandleRef handle, int len);
		
		[DllImport (MPH, CallingConvention=CallingConvention.Cdecl,
		EntryPoint="Mono_Posix_Stdlib_EOF")]
		private static extern int GetEOF ();
		
		[DllImport (MPH, CallingConvention=CallingConvention.Cdecl,
		EntryPoint="Mono_Posix_Stdlib_FILENAME_MAX")]
		private static extern int GetFilenameMax ();
		
		[DllImport (MPH, CallingConvention=CallingConvention.Cdecl,
		EntryPoint="Mono_Posix_Stdlib_FOPEN_MAX")]
		private static extern int GetFopenMax ();
		
		[DllImport (MPH, CallingConvention=CallingConvention.Cdecl,
		EntryPoint="Mono_Posix_Stdlib_L_tmpnam")]
		private static extern int GetTmpnamLength ();
		
		[DllImport (MPH, CallingConvention=CallingConvention.Cdecl,
		EntryPoint="Mono_Posix_Stdlib_stdin")]
		private static extern IntPtr GetStandardInput ();
		
		[DllImport (MPH, CallingConvention=CallingConvention.Cdecl,
		EntryPoint="Mono_Posix_Stdlib_stdout")]
		private static extern IntPtr GetStandardOutput ();
		
		[DllImport (MPH, CallingConvention=CallingConvention.Cdecl,
		EntryPoint="Mono_Posix_Stdlib_stderr")]
		private static extern IntPtr GetStandardError ();
		
		[DllImport (MPH, CallingConvention=CallingConvention.Cdecl,
		EntryPoint="Mono_Posix_Stdlib_TMP_MAX")]
		private static extern int GetTmpMax ();
		
		[DllImport (LIBC, CallingConvention=CallingConvention.Cdecl, SetLastError=true)]
		public static extern int remove (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string filename);
		
		[DllImport (LIBC, CallingConvention=CallingConvention.Cdecl, SetLastError=true)]
		public static extern int rename (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string oldpath, 
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string newpath);
		
		[DllImport (LIBC, CallingConvention=CallingConvention.Cdecl, SetLastError=true)]
		public static extern IntPtr tmpfile ();
		
		[DllImport (LIBC, CallingConvention=CallingConvention.Cdecl,
		SetLastError=true, EntryPoint="tmpnam")]
		private static extern IntPtr sys_tmpnam (StringBuilder s);
		
		[DllImport (LIBC, CallingConvention=CallingConvention.Cdecl, SetLastError=true)]
		public static extern int fclose (IntPtr stream);
		
		[DllImport (LIBC, CallingConvention=CallingConvention.Cdecl, SetLastError=true)]
		public static extern int fflush (IntPtr stream);
		
		[DllImport (LIBC, CallingConvention=CallingConvention.Cdecl, SetLastError=true)]
		public static extern IntPtr fopen (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string path, string mode);
		
		[DllImport (LIBC, CallingConvention=CallingConvention.Cdecl, SetLastError=true)]
		public static extern IntPtr freopen (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string path, string mode, IntPtr stream);
		
		[DllImport (MPH, CallingConvention=CallingConvention.Cdecl, 
		SetLastError=true, EntryPoint="Mono_Posix_Stdlib_setbuf")]
		public static extern int setbuf (IntPtr stream, IntPtr buf);
		
		[CLSCompliant (false)]
		[DllImport (MPH, CallingConvention=CallingConvention.Cdecl,
		SetLastError=true, EntryPoint="Mono_Posix_Stdlib_setvbuf")]
		public static extern int setvbuf (IntPtr stream, IntPtr buf, int mode, ulong size);
		
		[DllImport (LIBC, CallingConvention=CallingConvention.Cdecl,
		EntryPoint="fprintf")]
		private static extern int sys_fprintf (IntPtr stream, string format, string message);
		
		/* SKIP: fscanf(3) */
		
		[DllImport (LIBC, CallingConvention=CallingConvention.Cdecl,
		EntryPoint="printf")]
		private static extern int sys_printf (string format, string message);
		
		/* SKIP: scanf(3) */
		
		[DllImport (MPH, CallingConvention=CallingConvention.Cdecl,
		EntryPoint="Mono_Posix_Stdlib_snprintf")]
		private static extern int sys_snprintf (StringBuilder s, ulong n, 
		string format, string message);
		
		/*
		* SKIP:
		*    sprintf(3)
		*    sscanf(3)
		*    vfprintf(3)
		*    vfscanf(3)
		*    vprintf(3)
		*    vscanf(3)
		*    vsnprintf(3)
		*    vsprint(3)
		*    vsscanf(3)
		*/
		
		[DllImport (LIBC, CallingConvention=CallingConvention.Cdecl, SetLastError=true)]
		public static extern int fgetc (IntPtr stream);
		
		[DllImport (LIBC, CallingConvention=CallingConvention.Cdecl,
		SetLastError=true, EntryPoint="fgets")]
		private static extern IntPtr sys_fgets (StringBuilder sb, int size, IntPtr stream);
		
		[DllImport (LIBC, CallingConvention=CallingConvention.Cdecl, SetLastError=true)]
		public static extern int fputc (int c, IntPtr stream);
		
		[DllImport (LIBC, CallingConvention=CallingConvention.Cdecl, SetLastError=true)]
		public static extern int fputs (string s, IntPtr stream);
		
		[DllImport (LIBC, CallingConvention=CallingConvention.Cdecl, SetLastError=true)]
		public static extern int getc (IntPtr stream);
		
		[DllImport (LIBC, CallingConvention=CallingConvention.Cdecl, SetLastError=true)]
		public static extern int getchar ();
		
		/* SKIP: gets(3) */
		
		[DllImport (LIBC, CallingConvention=CallingConvention.Cdecl, SetLastError=true)]
		public static extern int putc (int c, IntPtr stream);
		
		[DllImport (LIBC, CallingConvention=CallingConvention.Cdecl, SetLastError=true)]
		public static extern int putchar (int c);
		
		[DllImport (LIBC, CallingConvention=CallingConvention.Cdecl, SetLastError=true)]
		public static extern int puts (string s);
		
		[DllImport (LIBC, CallingConvention=CallingConvention.Cdecl, SetLastError=true)]
		public static extern int ungetc (int c, IntPtr stream);
		
		[CLSCompliant (false)]
		[DllImport (MPH, CallingConvention=CallingConvention.Cdecl,
		SetLastError=true, EntryPoint="Mono_Posix_Stdlib_fread")]
		public static extern ulong fread (IntPtr ptr, ulong size, ulong nmemb, IntPtr stream);
		
		[DllImport (MPH, CallingConvention=CallingConvention.Cdecl,
		SetLastError=true, EntryPoint="Mono_Posix_Stdlib_fread")]
		private static extern ulong sys_fread ([Out] byte[] ptr, 
		ulong size, ulong nmemb, IntPtr stream);
		
		[CLSCompliant (false)]
		[DllImport (MPH, CallingConvention=CallingConvention.Cdecl,
		SetLastError=true, EntryPoint="Mono_Posix_Stdlib_fwrite")]
		public static extern ulong fwrite (IntPtr ptr, ulong size, ulong nmemb, IntPtr stream);
		
		[DllImport (MPH, CallingConvention=CallingConvention.Cdecl,
		SetLastError=true, EntryPoint="Mono_Posix_Stdlib_fwrite")]
		private static extern ulong sys_fwrite (byte[] ptr, 
		ulong size, ulong nmemb, IntPtr stream);
		
		[DllImport (MPH, CallingConvention=CallingConvention.Cdecl,
		SetLastError=true, EntryPoint="Mono_Posix_Stdlib_fgetpos")]
		private static extern int sys_fgetpos (IntPtr stream, HandleRef pos);
		
		[DllImport (MPH, CallingConvention=CallingConvention.Cdecl,
		SetLastError=true, EntryPoint="Mono_Posix_Stdlib_fseek")]
		private static extern int sys_fseek (IntPtr stream, long offset, int origin);
		
		[DllImport (MPH, CallingConvention=CallingConvention.Cdecl,
		SetLastError=true, EntryPoint="Mono_Posix_Stdlib_fsetpos")]
		private static extern int sys_fsetpos (IntPtr stream, HandleRef pos);
		
		[DllImport (MPH, CallingConvention=CallingConvention.Cdecl,
		SetLastError=true, EntryPoint="Mono_Posix_Stdlib_ftell")]
		public static extern long ftell (IntPtr stream);
		
		[DllImport (MPH, CallingConvention=CallingConvention.Cdecl,
		SetLastError=true, EntryPoint="Mono_Posix_Stdlib_rewind")]
		public static extern int rewind (IntPtr stream);
		
		[DllImport (MPH, CallingConvention=CallingConvention.Cdecl,
		SetLastError=true, EntryPoint="Mono_Posix_Stdlib_clearerr")]
		public static extern int clearerr (IntPtr stream);
		
		[DllImport (LIBC, CallingConvention=CallingConvention.Cdecl)]
		public static extern int feof (IntPtr stream);
		
		[DllImport (LIBC, CallingConvention=CallingConvention.Cdecl)]
		public static extern int ferror (IntPtr stream);
		
		[DllImport (MPH, CallingConvention=CallingConvention.Cdecl, 
		SetLastError=true, EntryPoint="Mono_Posix_Stdlib_perror")]
		private static extern int perror (string s, int err);
		
		[DllImport (MPH, CallingConvention=CallingConvention.Cdecl,
		EntryPoint="Mono_Posix_Stdlib_EXIT_FAILURE")]
		private static extern int GetExitFailure();
		
		[DllImport (MPH, CallingConvention=CallingConvention.Cdecl,
		EntryPoint="Mono_Posix_Stdlib_EXIT_SUCCESS")]
		private static extern int GetExitSuccess ();
		
		[DllImport (MPH, CallingConvention=CallingConvention.Cdecl,
		EntryPoint="Mono_Posix_Stdlib_MB_CUR_MAX")]
		private static extern int GetMbCurMax ();
		
		[DllImport (MPH, CallingConvention=CallingConvention.Cdecl,
		EntryPoint="Mono_Posix_Stdlib_RAND_MAX")]
		private static extern int GetRandMax ();
		
		[DllImport (LIBC, CallingConvention=CallingConvention.Cdecl)]
		public static extern int rand ();
		
		[CLSCompliant (false)]
		[DllImport (LIBC, CallingConvention=CallingConvention.Cdecl)]
		public static extern void srand (uint seed);
		[CLSCompliant (false)]
		[DllImport (MPH, CallingConvention=CallingConvention.Cdecl,
		SetLastError=true, EntryPoint="Mono_Posix_Stdlib_calloc")]
		public static extern IntPtr calloc (ulong nmemb, ulong size);
		
		[DllImport (LIBC, CallingConvention=CallingConvention.Cdecl)]
		public static extern void free (IntPtr ptr);
		[CLSCompliant (false)]
		[DllImport (MPH, CallingConvention=CallingConvention.Cdecl,
		SetLastError=true, EntryPoint="Mono_Posix_Stdlib_malloc")]
		public static extern IntPtr malloc (ulong size);
		[CLSCompliant (false)]
		[DllImport (MPH, CallingConvention=CallingConvention.Cdecl,
		SetLastError=true, EntryPoint="Mono_Posix_Stdlib_realloc")]
		public static extern IntPtr realloc (IntPtr ptr, ulong size);
		
		[DllImport (LIBC, CallingConvention=CallingConvention.Cdecl)]
		public static extern void abort ();
		
		/* SKIP: atexit(3) -- the GC should have collected most references by the
		* time this runs, so no delegates should exist, making it pointless. */
		
		[DllImport (LIBC, CallingConvention=CallingConvention.Cdecl)]
		public static extern void exit (int status);
		
		[CLSCompliant (false)]
		[DllImport (LIBC, CallingConvention=CallingConvention.Cdecl)]
		public static extern void _Exit (int status);
		
		[DllImport (LIBC, CallingConvention=CallingConvention.Cdecl, EntryPoint="getenv")]
		private static extern IntPtr sys_getenv (string name);
		
		[CLSCompliant (false)]
		[DllImport (LIBC, CallingConvention=CallingConvention.Cdecl, SetLastError=true)]
		public static extern int system (string @string);
		
		[DllImport (LIBC, CallingConvention=CallingConvention.Cdecl,
		SetLastError=true, EntryPoint="strerror")]
		private static extern IntPtr sys_strerror (int errnum);
		[CLSCompliant (false)]
		[DllImport (MPH, CallingConvention=CallingConvention.Cdecl,
		SetLastError=true, EntryPoint="Mono_Posix_Stdlib_strlen")]
		public static extern ulong strlen (IntPtr s);

	}
}
