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
using System.Runtime.InteropServices;

namespace Mono.Posix
{
	public partial class Syscall
	{
		public static int exit (int status)
		{
			throw new System.NotImplementedException();
		}
		public static int fork ()
		{
			throw new System.NotImplementedException();
		}
		public unsafe static IntPtr read (int fileDescriptor, void *buf, IntPtr count)
		{
			throw new System.NotImplementedException();
		}
		public unsafe static IntPtr write (int fileDescriptor, void *buf, IntPtr count)
		{
			throw new System.NotImplementedException();
		}
		internal static int syscall_open (string pathname, int flags, int mode)
		{
			throw new System.NotImplementedException();
		}
		internal static int map_Mono_Posix_OpenFlags (OpenFlags flags)
		{
			throw new System.NotImplementedException();
		}
		internal static int map_Mono_Posix_FileMode (FileMode mode)
		{
			throw new System.NotImplementedException();
		}
		public static int close (int fileDescriptor)
		{
			throw new System.NotImplementedException();
		}
		unsafe internal static int syscall_waitpid (int pid, int * status, int options)
		{
			throw new System.NotImplementedException();
		}
		internal static int map_Mono_Posix_WaitOptions (WaitOptions wait_options)
		{
			throw new System.NotImplementedException();
		}
		public static int WIFEXITED (int status)
		{
			throw new System.NotImplementedException();
		}
		public static int WEXITSTATUS (int status)
		{
			throw new System.NotImplementedException();
		}
		public static int WIFSIGNALED (int status)
		{
			throw new System.NotImplementedException();
		}
		public static int WTERMSIG (int status)
		{
			throw new System.NotImplementedException();
		}
		public static int WIFSTOPPED (int status)
		{
			throw new System.NotImplementedException();
		}
		public static int WSTOPSIG (int status)
		{
			throw new System.NotImplementedException();
		}
		internal static int syscall_creat (string pathname, int flags)
		{
			throw new System.NotImplementedException();
		}
		public static int link (string oldPath, string newPath)
		{
			throw new System.NotImplementedException();
		}
		public static int unlink (string path)
		{
			throw new System.NotImplementedException();
		}
		public static int symlink (string oldpath, string newpath)
		{
			throw new System.NotImplementedException();
		}
		public static int chdir (string path)
		{
			throw new System.NotImplementedException();
		}
		internal static int syscall_chmod (string path, int mode)
		{
			throw new System.NotImplementedException();
		}
		public static int chown (string path, int owner, int group)
		{
			throw new System.NotImplementedException();
		}
		public static int lchown (string path, int owner, int group)
		{
			throw new System.NotImplementedException();
		}
		public static int lseek (int fileDescriptor, int offset, int whence)
		{
			throw new System.NotImplementedException();
		}
		public static int getpid ()
		{
			throw new System.NotImplementedException();
		}
		public static int setuid (int uid)
		{
			throw new System.NotImplementedException();
		}
		public static int getuid ()
		{
			throw new System.NotImplementedException();
		}
		public static uint alarm (uint seconds)
		{
			throw new System.NotImplementedException();
		}
		public static int pause ()
		{
			throw new System.NotImplementedException();
		}
		internal static int syscall_access (string pathname, int mode)
		{
			throw new System.NotImplementedException();
		}
		internal static int map_Mono_Posix_AccessMode (AccessMode mode)
		{
			throw new System.NotImplementedException();
		}
		public static int nice (int increment)
		{
			throw new System.NotImplementedException();
		}
		public static void sync ()
		{
			throw new System.NotImplementedException();
		}
		public static void kill (int pid, int sig)
		{
			throw new System.NotImplementedException();
		}
		public static int rename (string oldPath, string newPath)
		{
			throw new System.NotImplementedException();
		}
		internal static int syscall_mkdir (string pathname, int mode)
		{
			throw new System.NotImplementedException();
		}
		public static int rmdir (string path)
		{
			throw new System.NotImplementedException();
		}
		public static int dup (int fileDescriptor)
		{
			throw new System.NotImplementedException();
		}
		public static int setgid (int gid)
		{
			throw new System.NotImplementedException();
		}
		public static int getgid ()
		{
			throw new System.NotImplementedException();
		}
		public static int signal (int signum, sighandler_t handler)
		{
			throw new System.NotImplementedException();
		}
		public static int geteuid ()
		{
			throw new System.NotImplementedException();
		}
		public static int getegid ()
		{
			throw new System.NotImplementedException();
		}
		public static int setpgid (int pid, int pgid)
		{
			throw new System.NotImplementedException();
		}
		public static int umask (int umask)
		{
			throw new System.NotImplementedException();
		}
		public static int chroot (string path)
		{
			throw new System.NotImplementedException();
		}
		public static int dup2 (int oldFileDescriptor, int newFileDescriptor)
		{
			throw new System.NotImplementedException();
		}
		public static int getppid ()
		{
			throw new System.NotImplementedException();
		}
		public static int getpgrp ()
		{
			throw new System.NotImplementedException();
		}
		public static int setsid ()
		{
			throw new System.NotImplementedException();
		}
		public static int setreuid (int ruid, int euid)
		{
			throw new System.NotImplementedException();
		}
		public static int setregid (int rgid, int egid)
		{
			throw new System.NotImplementedException();
		}
		private static string helper_Mono_Posix_GetUserName (int uid)
		{
			throw new System.NotImplementedException();
		}
		private static string helper_Mono_Posix_GetGroupName (int gid)
		{
			throw new System.NotImplementedException();
		}
		static int syscall_gethostname (byte[] p, int len)
		{
			throw new System.NotImplementedException();
		}
		static int syscall_isatty (int desc)
		{
			throw new System.NotImplementedException();
		}
		internal static int helper_Mono_Posix_Stat (string filename, bool dereference,
		out int device, out int inode, out int mode,
		out int nlinks, out int uid, out int gid,
		out int rdev, out long size, out long blksize, out long blocks,
		out long atime, out long mtime, out long ctime)
		{
			throw new System.NotImplementedException();
		}
		private static int readlink(string path, byte[] buffer, int buflen)
		{
			throw new System.NotImplementedException();
		}
		static IntPtr _strerror(int errnum)
		{
			throw new System.NotImplementedException();
		}
		public static IntPtr opendir(string path)
		{
			throw new System.NotImplementedException();
		}
		public static int closedir(IntPtr dir)
		{
			throw new System.NotImplementedException();
		}
		public static string readdir(IntPtr dir)
		{
			throw new System.NotImplementedException();
		}

	}
}
