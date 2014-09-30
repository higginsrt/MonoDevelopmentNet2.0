//
// Mono.Posix.Syscall.cs: System calls to Posix subsystem features
//
// Author:
//   Miguel de Icaza (miguel@novell.com)
//
// (C) 2003 Novell, Inc.
//
// This file implements the low-level syscall interface to the POSIX
// subsystem.
//
// This file tries to stay close to the low-level API as much as possible
// using enumerations, structures and in a few cases, using existing .NET
// data types.
//
// Implementation notes:
//
//    Since the values for the various constants on the API changes
//    from system to system (even Linux on different architectures will
//    have different values), we define our own set of values, and we
//    use a set of C helper routines to map from the constants we define
//    to the values of the native OS.
//
//    Bitfields were flagged with the [Map] attribute, and a helper program
//    generates a set of map_XXXX routines that we can call to convert
//    from our value definitions to the value definitions expected by the
//    OS.
//
//    Methods that require tuning are bound as `internal syscal_NAME' methods
//    and then a `NAME' method is exposed.
//
// Deprecated Warning:
//
//    This class is deprecated, and exists only for backward compatibility.
//    Please use and maintain Mono.Unix.Native.Syscall.
//
//    The [Map] attributes have been removed.  The naming and methodology of
//    the mapping routines has changed.  The old map functions still exist in
//    MonoPosixHelper, but they will not be updated any further.
//    Consequently, there is little point in maintaining the [Map] attributes
//    in this file, as they would only bloat MonoPosixHelper.
//

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
using System.Text;
using System.Runtime.InteropServices;

namespace Mono.Posix
{
	public partial class Syscall
	{
		[DllImport ("libc", SetLastError=true)]
		public static extern int exit (int status);
		
		[DllImport ("libc", SetLastError=true)]
		public static extern int fork ();
		
		[DllImport ("libc", SetLastError=true)]
		public unsafe static extern IntPtr read (int fileDescriptor, void *buf, IntPtr count);
		
		[DllImport ("libc", SetLastError=true)]
		public unsafe static extern IntPtr write (int fileDescriptor, void *buf, IntPtr count);
		
		[DllImport ("libc", EntryPoint="open", SetLastError=true)]
		internal static extern int syscall_open (string pathname, int flags, int mode);
		
		[DllImport ("MonoPosixHelper")]
		internal extern static int map_Mono_Posix_OpenFlags (OpenFlags flags);
		[DllImport ("MonoPosixHelper")]
		internal extern static int map_Mono_Posix_FileMode (FileMode mode);
		
		[DllImport ("libc", SetLastError=true)]
		public static extern int close (int fileDescriptor);
		
		[DllImport ("libc", EntryPoint="waitpid", SetLastError=true)]
		unsafe internal static extern int syscall_waitpid (int pid, int * status, int options);
		
		[DllImport ("MonoPosixHelper")]
		internal extern static int map_Mono_Posix_WaitOptions (WaitOptions wait_options);
		
		[DllImport ("MonoPosixHelper", EntryPoint="wifexited")]
		public static extern int WIFEXITED (int status);
		[DllImport ("MonoPosixHelper", EntryPoint="wexitstatus")]
		public static extern int WEXITSTATUS (int status);
		[DllImport ("MonoPosixHelper", EntryPoint="wifsignaled")]
		public static extern int WIFSIGNALED (int status);
		[DllImport ("MonoPosixHelper", EntryPoint="wtermsig")]
		public static extern int WTERMSIG (int status);
		[DllImport ("MonoPosixHelper", EntryPoint="wifstopped")]
		public static extern int WIFSTOPPED (int status);
		[DllImport ("MonoPosixHelper", EntryPoint="wstopsig")]
		public static extern int WSTOPSIG (int status);
		
		[DllImport ("libc", EntryPoint="creat", SetLastError=true)]
		internal static extern int syscall_creat (string pathname, int flags);
		
		[DllImport ("libc", SetLastError=true)]
		public static extern int link (string oldPath, string newPath);
		
		[DllImport ("libc", SetLastError=true)]
		public static extern int unlink (string path);
		
		[DllImport ("libc", SetLastError=true)]
		public static extern int symlink (string oldpath, string newpath);
		
		[DllImport ("libc", SetLastError=true)]
		public static extern int chdir (string path);
		
		[DllImport ("libc", EntryPoint="chmod", SetLastError=true)]
		internal static extern int syscall_chmod (string path, int mode);
		
		[DllImport ("libc", SetLastError=true)]
		public static extern int chown (string path, int owner, int group);
		[DllImport ("libc", SetLastError=true)]
		public static extern int lchown (string path, int owner, int group);
		
		[DllImport ("libc", SetLastError=true)]
		public static extern int lseek (int fileDescriptor, int offset, int whence);
		
		[DllImport ("libc", SetLastError=true)]
		public static extern int getpid ();
		
		[DllImport ("libc", SetLastError=true)]
		public static extern int setuid (int uid);
		
		[DllImport ("libc", SetLastError=true)]
		public static extern int getuid ();
		
		[DllImport ("libc")]
		public static extern uint alarm (uint seconds);
		
		[DllImport ("libc", SetLastError=true)]
		public static extern int pause ();
		
		[DllImport ("libc", EntryPoint="access", SetLastError=true)]
		internal extern static int syscall_access (string pathname, int mode);
		
		[DllImport ("MonoPosixHelper")]
		internal extern static int map_Mono_Posix_AccessMode (AccessMode mode);
		
		[DllImport ("libc", SetLastError=true)]
		public static extern int nice (int increment);
		
		[DllImport ("libc")]
		public static extern void sync ();
		
		[DllImport ("libc", SetLastError=true)]
		public static extern void kill (int pid, int sig);
		
		[DllImport ("libc", SetLastError=true)]
		public static extern int rename (string oldPath, string newPath);
		
		[DllImport ("libc", EntryPoint="mkdir", SetLastError=true)]
		internal extern static int syscall_mkdir (string pathname, int mode);
		
		[DllImport ("libc", SetLastError=true)]
		public static extern int rmdir (string path);
		
		[DllImport ("libc", SetLastError=true)]
		public static extern int dup (int fileDescriptor);
		
		[DllImport ("libc", SetLastError=true)]
		public static extern int setgid (int gid);
		[DllImport ("libc", SetLastError=true)]
		public static extern int getgid ();
		
		[DllImport ("libc", SetLastError=true)]
		public static extern int signal (int signum, sighandler_t handler);
		
		[DllImport ("libc", SetLastError=true)]
		public static extern int geteuid ();
		
		[DllImport ("libc", SetLastError=true)]
		public static extern int getegid ();
		
		[DllImport ("libc", SetLastError=true)]
		public static extern int setpgid (int pid, int pgid);
		
		[DllImport ("libc")]
		public static extern int umask (int umask);
		
		[DllImport ("libc", SetLastError=true)]
		public static extern int chroot (string path);
		
		[DllImport ("libc", SetLastError=true)]
		public static extern int dup2 (int oldFileDescriptor, int newFileDescriptor);
		
		[DllImport ("libc", SetLastError=true)]
		public static extern int getppid ();
		
		[DllImport ("libc", SetLastError=true)]
		public static extern int getpgrp ();
		
		[DllImport ("libc", SetLastError=true)]
		public static extern int setsid ();
		
		[DllImport ("libc", SetLastError=true)]
		public static extern int setreuid (int ruid, int euid);
		
		[DllImport ("libc", SetLastError=true)]
		public static extern int setregid (int rgid, int egid);
		
		[DllImport ("MonoPosixHelper", SetLastError=true)]
		private static extern string helper_Mono_Posix_GetUserName (int uid);
		
		[DllImport ("MonoPosixHelper", SetLastError=true)]
		private static extern string helper_Mono_Posix_GetGroupName (int gid);
		
		[DllImport ("libc", EntryPoint="gethostname", SetLastError=true)]
		static extern int syscall_gethostname (byte[] p, int len);
		
		[DllImport ("libc", EntryPoint="isatty")]
		static extern int syscall_isatty (int desc);
		
		[DllImport ("MonoPosixHelper")]
		internal extern static int helper_Mono_Posix_Stat (string filename, bool dereference,
		out int device, out int inode, out int mode,
		out int nlinks, out int uid, out int gid,
		out int rdev, out long size, out long blksize, out long blocks,
		out long atime, out long mtime, out long ctime);
		
		[DllImport ("libc")]
		private static extern int readlink(string path, byte[] buffer, int buflen);
		
		[DllImport ("libc", EntryPoint="strerror")]
		static extern IntPtr _strerror(int errnum);
		
		[DllImport ("libc")]
		public static extern IntPtr opendir(string path);
		
		[DllImport ("libc")]
		public static extern int closedir(IntPtr dir);
		
		[DllImport ("MonoPosixHelper", EntryPoint="helper_Mono_Posix_readdir")]
		public static extern string readdir(IntPtr dir);

	}
}
