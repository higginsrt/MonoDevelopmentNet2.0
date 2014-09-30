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
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using Mono.Unix.Native;

namespace Mono.Unix.Native
{
	public partial class Syscall
	{
		public static int setxattr (
		string path,
		string name, byte[] value, ulong size, XattrFlags flags)
		{
			throw new System.NotImplementedException();
		}
		public static int lsetxattr (
		string path,
		string name, byte[] value, ulong size, XattrFlags flags)
		{
			throw new System.NotImplementedException();
		}
		public static int fsetxattr (int fd,
		string name, byte[] value, ulong size, XattrFlags flags)
		{
			throw new System.NotImplementedException();
		}
		public static long getxattr (
		string path,
		string name, byte[] value, ulong size)
		{
			throw new System.NotImplementedException();
		}
		public static long lgetxattr (
		string path,
		string name, byte[] value, ulong size)
		{
			throw new System.NotImplementedException();
		}
		public static long fgetxattr (int fd,
		string name, byte[] value, ulong size)
		{
			throw new System.NotImplementedException();
		}
		public static long listxattr (
		string path, byte[] list, ulong size)
		{
			throw new System.NotImplementedException();
		}
		public static long llistxattr (
		string path, byte[] list, ulong size)
		{
			throw new System.NotImplementedException();
		}
		public static long flistxattr (int fd, byte[] list, ulong size)
		{
			throw new System.NotImplementedException();
		}
		public static int removexattr (
		string path,
		string name)
		{
			throw new System.NotImplementedException();
		}
		public static int lremovexattr (
		string path,
		string name)
		{
			throw new System.NotImplementedException();
		}
		public static int fremovexattr (int fd,
		string name)
		{
			throw new System.NotImplementedException();
		}
		public static IntPtr opendir (
		string name)
		{
			throw new System.NotImplementedException();
		}
		public static int closedir (IntPtr dir)
		{
			throw new System.NotImplementedException();
		}
		public static int seekdir (IntPtr dir, long offset)
		{
			throw new System.NotImplementedException();
		}
		public static long telldir (IntPtr dir)
		{
			throw new System.NotImplementedException();
		}
		public static int rewinddir (IntPtr dir)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_readdir (IntPtr dir, out _Dirent dentry)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_readdir_r (IntPtr dirp, out _Dirent entry, out IntPtr result)
		{
			throw new System.NotImplementedException();
		}
		public static int dirfd (IntPtr dir)
		{
			throw new System.NotImplementedException();
		}
		public static int fcntl (int fd, FcntlCommand cmd)
		{
			throw new System.NotImplementedException();
		}
		public static int fcntl (int fd, FcntlCommand cmd, long arg)
		{
			throw new System.NotImplementedException();
		}
		public static int fcntl (int fd, FcntlCommand cmd, ref Flock @lock)
		{
			throw new System.NotImplementedException();
		}
		public static int open (
		string pathname, OpenFlags flags)
		{
			throw new System.NotImplementedException();
		}
		public static int open (
		string pathname, OpenFlags flags, FilePermissions mode)
		{
			throw new System.NotImplementedException();
		}
		public static int creat (
		string pathname, FilePermissions mode)
		{
			throw new System.NotImplementedException();
		}
		public static int posix_fadvise (int fd, long offset,
		long len, PosixFadviseAdvice advice)
		{
			throw new System.NotImplementedException();
		}
		public static int posix_fallocate (int fd, long offset, ulong len)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_endfsent ()
		{
			throw new System.NotImplementedException();
		}
		private static int sys_getfsent (out _Fstab fs)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_getfsfile (
		string mount_point, out _Fstab fs)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_getfsspec (
		string special_file, out _Fstab fs)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_setfsent ()
		{
			throw new System.NotImplementedException();
		}
		public static int setgroups (ulong size, uint[] list)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_getgrnam (string name, out _Group group)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_getgrgid (uint uid, out _Group group)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_getgrnam_r (
		string name, out _Group grbuf, out IntPtr grbufp)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_getgrgid_r (uint uid, out _Group grbuf, out IntPtr grbufp)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_getgrent (out _Group grbuf)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_setgrent ()
		{
			throw new System.NotImplementedException();
		}
		private static int sys_endgrent ()
		{
			throw new System.NotImplementedException();
		}
		private static int sys_fgetgrent (IntPtr stream, out _Group grbuf)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_getpwnam (string name, out _Passwd passwd)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_getpwuid (uint uid, out _Passwd passwd)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_getpwnam_r (
		string name, out _Passwd pwbuf, out IntPtr pwbufp)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_getpwuid_r (uint uid, out _Passwd pwbuf, out IntPtr pwbufp)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_getpwent (out _Passwd pwbuf)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_setpwent ()
		{
			throw new System.NotImplementedException();
		}
		private static int sys_endpwent ()
		{
			throw new System.NotImplementedException();
		}
		private static int sys_fgetpwent (IntPtr stream, out _Passwd pwbuf)
		{
			throw new System.NotImplementedException();
		}
		private static int psignal (int sig, string s)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_kill (int pid, int sig)
		{
			throw new System.NotImplementedException();
		}
		private static IntPtr sys_strsignal (int sig)
		{
			throw new System.NotImplementedException();
		}
		private static int _L_ctermid ()
		{
			throw new System.NotImplementedException();
		}
		private static int _L_cuserid ()
		{
			throw new System.NotImplementedException();
		}
		private static IntPtr sys_cuserid ([Out] StringBuilder @string)
		{
			throw new System.NotImplementedException();
		}
		public static int mkstemp (StringBuilder template)
		{
			throw new System.NotImplementedException();
		}
		public static int ttyslot ()
		{
			throw new System.NotImplementedException();
		}
		private static int sys_strerror_r (int errnum,
		[Out] StringBuilder buf, ulong n)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_epoll_create (int size)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_epoll_create1 (EpollFlags flags)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_epoll_ctl (int epfd, EpollOp op, int fd, ref EpollEvent ee)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_epoll_wait (int epfd, EpollEvent [] ee, int maxevents, int timeout)
		{
			throw new System.NotImplementedException();
		}
		public static int posix_madvise (IntPtr addr, ulong len,
		PosixMadviseAdvice advice)
		{
			throw new System.NotImplementedException();
		}
		public static IntPtr mmap (IntPtr start, ulong length,
		MmapProts prot, MmapFlags flags, int fd, long offset)
		{
			throw new System.NotImplementedException();
		}
		public static int munmap (IntPtr start, ulong length)
		{
			throw new System.NotImplementedException();
		}
		public static int mprotect (IntPtr start, ulong len, MmapProts prot)
		{
			throw new System.NotImplementedException();
		}
		public static int msync (IntPtr start, ulong len, MsyncFlags flags)
		{
			throw new System.NotImplementedException();
		}
		public static int mlock (IntPtr start, ulong len)
		{
			throw new System.NotImplementedException();
		}
		public static int munlock (IntPtr start, ulong len)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_mlockall (int flags)
		{
			throw new System.NotImplementedException();
		}
		public static int munlockall ()
		{
			throw new System.NotImplementedException();
		}
		public static IntPtr mremap (IntPtr old_address, ulong old_size,
		ulong new_size, MremapFlags flags)
		{
			throw new System.NotImplementedException();
		}
		public static int mincore (IntPtr start, ulong length, byte[] vec)
		{
			throw new System.NotImplementedException();
		}
		public static int remap_file_pages (IntPtr start, ulong size,
		MmapProts prot, long pgoff, MmapFlags flags)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_poll (_pollfd[] ufds, uint nfds, int timeout)
		{
			throw new System.NotImplementedException();
		}
		public static long sendfile (int out_fd, int in_fd,
		ref long offset, ulong count)
		{
			throw new System.NotImplementedException();
		}
		public static int stat (
		string file_name, out Stat buf)
		{
			throw new System.NotImplementedException();
		}
		public static int fstat (int filedes, out Stat buf)
		{
			throw new System.NotImplementedException();
		}
		public static int lstat (
		string file_name, out Stat buf)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_chmod (
		string path, uint mode)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_fchmod (int filedes, uint mode)
		{
			throw new System.NotImplementedException();
		}
		private static uint sys_umask (uint mask)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_mkdir (
		string oldpath, uint mode)
		{
			throw new System.NotImplementedException();
		}
		public static int mknod (
		string pathname, FilePermissions mode, ulong dev)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_mkfifo (
		string pathname, uint mode)
		{
			throw new System.NotImplementedException();
		}
		public static int statvfs (
		string path, out Statvfs buf)
		{
			throw new System.NotImplementedException();
		}
		public static int fstatvfs (int fd, out Statvfs buf)
		{
			throw new System.NotImplementedException();
		}
		public static int gettimeofday (out Timeval tv, out Timezone tz)
		{
			throw new System.NotImplementedException();
		}
		private static int gettimeofday (out Timeval tv, IntPtr ignore)
		{
			throw new System.NotImplementedException();
		}
		private static int gettimeofday (IntPtr ignore, out Timezone tz)
		{
			throw new System.NotImplementedException();
		}
		public static int settimeofday (ref Timeval tv, ref Timezone tz)
		{
			throw new System.NotImplementedException();
		}
		private static int settimeofday (ref Timeval tv, IntPtr ignore)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_utimes (
		string filename, Timeval[] tvp)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_lutimes (
		string filename, Timeval[] tvp)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_futimes (int fd, Timeval[] tvp)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_uname (out _Utsname buf)
		{
			throw new System.NotImplementedException();
		}
		public static int wait (out int status)
		{
			throw new System.NotImplementedException();
		}
		private static int waitpid (int pid, out int status, int options)
		{
			throw new System.NotImplementedException();
		}
		private static int _WIFEXITED (int status)
		{
			throw new System.NotImplementedException();
		}
		public static int WEXITSTATUS (int status)
		{
			throw new System.NotImplementedException();
		}
		private static int _WIFSIGNALED (int status)
		{
			throw new System.NotImplementedException();
		}
		private static int _WTERMSIG (int status)
		{
			throw new System.NotImplementedException();
		}
		private static int _WIFSTOPPED (int status)
		{
			throw new System.NotImplementedException();
		}
		private static int _WSTOPSIG (int status)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_openlog (IntPtr ident, int option, int facility)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_syslog (int priority, string message)
		{
			throw new System.NotImplementedException();
		}
		public static int closelog ()
		{
			throw new System.NotImplementedException();
		}
		private static int sys_setlogmask (int mask)
		{
			throw new System.NotImplementedException();
		}
		public static int nanosleep (ref Timespec req, ref Timespec rem)
		{
			throw new System.NotImplementedException();
		}
		public static int stime (ref long t)
		{
			throw new System.NotImplementedException();
		}
		public static long time (out long t)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_access (
		string pathname, int mode)
		{
			throw new System.NotImplementedException();
		}
		private static long sys_lseek (int fd, long offset, int whence)
		{
			throw new System.NotImplementedException();
		}
		public static int close (int fd)
		{
			throw new System.NotImplementedException();
		}
		public static long read (int fd, IntPtr buf, ulong count)
		{
			throw new System.NotImplementedException();
		}
		public static long write (int fd, IntPtr buf, ulong count)
		{
			throw new System.NotImplementedException();
		}
		public static long pread (int fd, IntPtr buf, ulong count, long offset)
		{
			throw new System.NotImplementedException();
		}
		public static long pwrite (int fd, IntPtr buf, ulong count, long offset)
		{
			throw new System.NotImplementedException();
		}
		public static int pipe (out int reading, out int writing)
		{
			throw new System.NotImplementedException();
		}
		public static uint alarm (uint seconds)
		{
			throw new System.NotImplementedException();
		}
		public static uint sleep (uint seconds)
		{
			throw new System.NotImplementedException();
		}
		public static uint ualarm (uint usecs, uint interval)
		{
			throw new System.NotImplementedException();
		}
		public static int pause ()
		{
			throw new System.NotImplementedException();
		}
		public static int chown (
		string path, uint owner, uint group)
		{
			throw new System.NotImplementedException();
		}
		public static int fchown (int fd, uint owner, uint group)
		{
			throw new System.NotImplementedException();
		}
		public static int lchown (
		string path, uint owner, uint group)
		{
			throw new System.NotImplementedException();
		}
		public static int chdir (
		string path)
		{
			throw new System.NotImplementedException();
		}
		public static int fchdir (int fd)
		{
			throw new System.NotImplementedException();
		}
		public static IntPtr getcwd ([Out] StringBuilder buf, ulong size)
		{
			throw new System.NotImplementedException();
		}
		public static int dup (int fd)
		{
			throw new System.NotImplementedException();
		}
		public static int dup2 (int fd, int fd2)
		{
			throw new System.NotImplementedException();
		}
		public static int execve (
		string path, string[] argv, string[] envp)
		{
			throw new System.NotImplementedException();
		}
		public static int fexecve (int fd, string[] argv, string[] envp)
		{
			throw new System.NotImplementedException();
		}
		public static int execv (
		string path, string[] argv)
		{
			throw new System.NotImplementedException();
		}
		public static int execvp (
		string path, string[] argv)
		{
			throw new System.NotImplementedException();
		}
		public static int nice (int inc)
		{
			throw new System.NotImplementedException();
		}
		public static int _exit (int status)
		{
			throw new System.NotImplementedException();
		}
		public static long fpathconf (int filedes, PathconfName name, Errno defaultError)
		{
			throw new System.NotImplementedException();
		}
		public static long pathconf (
		string path, PathconfName name, Errno defaultError)
		{
			throw new System.NotImplementedException();
		}
		public static long sysconf (SysconfName name, Errno defaultError)
		{
			throw new System.NotImplementedException();
		}
		public static ulong confstr (ConfstrName name, [Out] StringBuilder buf, ulong len)
		{
			throw new System.NotImplementedException();
		}
		public static int getpid ()
		{
			throw new System.NotImplementedException();
		}
		public static int getppid ()
		{
			throw new System.NotImplementedException();
		}
		public static int setpgid (int pid, int pgid)
		{
			throw new System.NotImplementedException();
		}
		public static int getpgid (int pid)
		{
			throw new System.NotImplementedException();
		}
		public static int setpgrp ()
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
		public static int getsid (int pid)
		{
			throw new System.NotImplementedException();
		}
		public static uint getuid ()
		{
			throw new System.NotImplementedException();
		}
		public static uint geteuid ()
		{
			throw new System.NotImplementedException();
		}
		public static uint getgid ()
		{
			throw new System.NotImplementedException();
		}
		public static uint getegid ()
		{
			throw new System.NotImplementedException();
		}
		public static int getgroups (int size, uint[] list)
		{
			throw new System.NotImplementedException();
		}
		public static int setuid (uint uid)
		{
			throw new System.NotImplementedException();
		}
		public static int setreuid (uint ruid, uint euid)
		{
			throw new System.NotImplementedException();
		}
		public static int setregid (uint rgid, uint egid)
		{
			throw new System.NotImplementedException();
		}
		public static int seteuid (uint euid)
		{
			throw new System.NotImplementedException();
		}
		public static int setegid (uint uid)
		{
			throw new System.NotImplementedException();
		}
		public static int setgid (uint gid)
		{
			throw new System.NotImplementedException();
		}
		public static int getresuid (out uint ruid, out uint euid, out uint suid)
		{
			throw new System.NotImplementedException();
		}
		public static int getresgid (out uint rgid, out uint egid, out uint sgid)
		{
			throw new System.NotImplementedException();
		}
		public static int setresuid (uint ruid, uint euid, uint suid)
		{
			throw new System.NotImplementedException();
		}
		public static int setresgid (uint rgid, uint egid, uint sgid)
		{
			throw new System.NotImplementedException();
		}
		private static int fork ()
		{
			throw new System.NotImplementedException();
		}
		private static int vfork ()
		{
			throw new System.NotImplementedException();
		}
		private static IntPtr sys_ttyname (int fd)
		{
			throw new System.NotImplementedException();
		}
		public static int ttyname_r (int fd, [Out] StringBuilder buf, ulong buflen)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_isatty (int fd)
		{
			throw new System.NotImplementedException();
		}
		public static int link (
		string oldpath,
		string newpath)
		{
			throw new System.NotImplementedException();
		}
		public static int symlink (
		string oldpath,
		string newpath)
		{
			throw new System.NotImplementedException();
		}
		public static int readlink (
		string path, [Out] StringBuilder buf, ulong bufsiz)
		{
			throw new System.NotImplementedException();
		}
		public static int unlink (
		string pathname)
		{
			throw new System.NotImplementedException();
		}
		public static int rmdir (
		string pathname)
		{
			throw new System.NotImplementedException();
		}
		public static int tcgetpgrp (int fd)
		{
			throw new System.NotImplementedException();
		}
		public static int tcsetpgrp (int fd, int pgrp)
		{
			throw new System.NotImplementedException();
		}
		private static IntPtr sys_getlogin ()
		{
			throw new System.NotImplementedException();
		}
		public static int getlogin_r ([Out] StringBuilder name, ulong bufsize)
		{
			throw new System.NotImplementedException();
		}
		public static int setlogin (string name)
		{
			throw new System.NotImplementedException();
		}
		public static int gethostname ([Out] StringBuilder name, ulong len)
		{
			throw new System.NotImplementedException();
		}
		public static int sethostname (string name, ulong len)
		{
			throw new System.NotImplementedException();
		}
		public static long gethostid ()
		{
			throw new System.NotImplementedException();
		}
		public static int sethostid (long hostid)
		{
			throw new System.NotImplementedException();
		}
		public static int getdomainname ([Out] StringBuilder name, ulong len)
		{
			throw new System.NotImplementedException();
		}
		public static int setdomainname (string name, ulong len)
		{
			throw new System.NotImplementedException();
		}
		public static int vhangup ()
		{
			throw new System.NotImplementedException();
		}
		public static int revoke (
		string file)
		{
			throw new System.NotImplementedException();
		}
		public static int acct (
		string filename)
		{
			throw new System.NotImplementedException();
		}
		private static IntPtr sys_getusershell ()
		{
			throw new System.NotImplementedException();
		}
		private static int sys_setusershell ()
		{
			throw new System.NotImplementedException();
		}
		private static int sys_endusershell ()
		{
			throw new System.NotImplementedException();
		}
		private static int daemon (int nochdir, int noclose)
		{
			throw new System.NotImplementedException();
		}
		public static int chroot (
		string path)
		{
			throw new System.NotImplementedException();
		}
		public static int fsync (int fd)
		{
			throw new System.NotImplementedException();
		}
		public static int fdatasync (int fd)
		{
			throw new System.NotImplementedException();
		}
		public static int sync ()
		{
			throw new System.NotImplementedException();
		}
		public static int getpagesize ()
		{
			throw new System.NotImplementedException();
		}
		public static int truncate (
		string path, long length)
		{
			throw new System.NotImplementedException();
		}
		public static int ftruncate (int fd, long length)
		{
			throw new System.NotImplementedException();
		}
		public static int getdtablesize ()
		{
			throw new System.NotImplementedException();
		}
		public static int brk (IntPtr end_data_segment)
		{
			throw new System.NotImplementedException();
		}
		public static IntPtr sbrk (IntPtr increment)
		{
			throw new System.NotImplementedException();
		}
		public static int lockf (int fd, LockfCommand cmd, long len)
		{
			throw new System.NotImplementedException();
		}
		public static int swab (IntPtr from, IntPtr to, long n)
		{
			throw new System.NotImplementedException();
		}
		private static int sys_utime (
		string filename, ref Utimbuf buf, int use_buf)
		{
			throw new System.NotImplementedException();
		}

	}
}
