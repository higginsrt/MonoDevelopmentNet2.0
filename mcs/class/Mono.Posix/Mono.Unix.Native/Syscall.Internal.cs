//
// Mono.Unix/Syscall.cs
//
// Authors:
//   Miguel de Icaza (miguel@novell.com)
//   Jonathan Pryor (jonpryor@vt.edu)
//
// (C) 2003 Novell, Inc.
// (C) 2004-2006 Jonathan Pryor
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
//    Bitfields are flagged with the [Map] attribute, and a helper program
//    generates a set of routines that we can call to convert from our value 
//    definitions to the value definitions expected by the OS; see
//    NativeConvert for the conversion routines.
//
//    Methods that require tuning are bound as `private sys_NAME' methods
//    and then a `NAME' method is exposed.
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
using System.Collections;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using Mono.Unix.Native;

namespace Mono.Unix.Native
{
	public partial class Syscall
	{
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_setxattr")]
		public static extern int setxattr (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string path, 
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string name, byte[] value, ulong size, XattrFlags flags);
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_lsetxattr")]
		public static extern int lsetxattr (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string path, 
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string name, byte[] value, ulong size, XattrFlags flags);
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_fsetxattr")]
		public static extern int fsetxattr (int fd, 
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string name, byte[] value, ulong size, XattrFlags flags);
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_getxattr")]
		public static extern long getxattr (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string path, 
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string name, byte[] value, ulong size);
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_lgetxattr")]
		public static extern long lgetxattr (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string path, 
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string name, byte[] value, ulong size);
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_fgetxattr")]
		public static extern long fgetxattr (int fd, 
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string name, byte[] value, ulong size);
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_listxattr")]
		public static extern long listxattr (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string path, byte[] list, ulong size);
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_llistxattr")]
		public static extern long llistxattr (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string path, byte[] list, ulong size);
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_flistxattr")]
		public static extern long flistxattr (int fd, byte[] list, ulong size);
		
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_removexattr")]
		public static extern int removexattr (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string path, 
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string name);
		
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_lremovexattr")]
		public static extern int lremovexattr (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string path, 
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string name);
		
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_fremovexattr")]
		public static extern int fremovexattr (int fd, 
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string name);
		
		[DllImport (LIBC, SetLastError=true)]
		public static extern IntPtr opendir (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string name);
		
		[DllImport (LIBC, SetLastError=true)]
		public static extern int closedir (IntPtr dir);
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_seekdir")]
		public static extern int seekdir (IntPtr dir, long offset);
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_telldir")]
		public static extern long telldir (IntPtr dir);
		
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_rewinddir")]
		public static extern int rewinddir (IntPtr dir);
		
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_readdir")]
		private static extern int sys_readdir (IntPtr dir, out _Dirent dentry);
		
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_readdir_r")]
		private static extern int sys_readdir_r (IntPtr dirp, out _Dirent entry, out IntPtr result);
		
		[DllImport (LIBC, SetLastError=true)]
		public static extern int dirfd (IntPtr dir);
		
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_fcntl")]
		public static extern int fcntl (int fd, FcntlCommand cmd);
		
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_fcntl_arg")]
		public static extern int fcntl (int fd, FcntlCommand cmd, long arg);
		
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_fcntl_lock")]
		public static extern int fcntl (int fd, FcntlCommand cmd, ref Flock @lock);
		
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_open")]
		public static extern int open (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string pathname, OpenFlags flags);
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_open_mode")]
		public static extern int open (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string pathname, OpenFlags flags, FilePermissions mode);
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_creat")]
		public static extern int creat (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string pathname, FilePermissions mode);
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_posix_fadvise")]
		public static extern int posix_fadvise (int fd, long offset, 
		long len, PosixFadviseAdvice advice);
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_posix_fallocate")]
		public static extern int posix_fallocate (int fd, long offset, ulong len);
		
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_endfsent")]
		private static extern int sys_endfsent ();
		
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_getfsent")]
		private static extern int sys_getfsent (out _Fstab fs);
		
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_getfsfile")]
		private static extern int sys_getfsfile (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string mount_point, out _Fstab fs);
		
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_getfsspec")]
		private static extern int sys_getfsspec (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string special_file, out _Fstab fs);
		
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_setfsent")]
		private static extern int sys_setfsent ();
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_setgroups")]
		public static extern int setgroups (ulong size, uint[] list);
		
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_getgrnam")]
		private static extern int sys_getgrnam (string name, out _Group group);
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_getgrgid")]
		private static extern int sys_getgrgid (uint uid, out _Group group);
		
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_getgrnam_r")]
		private static extern int sys_getgrnam_r (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string name, out _Group grbuf, out IntPtr grbufp);
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_getgrgid_r")]
		private static extern int sys_getgrgid_r (uint uid, out _Group grbuf, out IntPtr grbufp);
		
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_getgrent")]
		private static extern int sys_getgrent (out _Group grbuf);
		
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_setgrent")]
		private static extern int sys_setgrent ();
		
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_endgrent")]
		private static extern int sys_endgrent ();
		
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_fgetgrent")]
		private static extern int sys_fgetgrent (IntPtr stream, out _Group grbuf);
		
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_getpwnam")]
		private static extern int sys_getpwnam (string name, out _Passwd passwd);
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_getpwuid")]
		private static extern int sys_getpwuid (uint uid, out _Passwd passwd);
		
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_getpwnam_r")]
		private static extern int sys_getpwnam_r (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string name, out _Passwd pwbuf, out IntPtr pwbufp);
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_getpwuid_r")]
		private static extern int sys_getpwuid_r (uint uid, out _Passwd pwbuf, out IntPtr pwbufp);
		
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_getpwent")]
		private static extern int sys_getpwent (out _Passwd pwbuf);
		
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_setpwent")]
		private static extern int sys_setpwent ();
		
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_endpwent")]
		private static extern int sys_endpwent ();
		
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_fgetpwent")]
		private static extern int sys_fgetpwent (IntPtr stream, out _Passwd pwbuf);
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_psignal")]
		private static extern int psignal (int sig, string s);
		[DllImport (LIBC, SetLastError=true, EntryPoint="kill")]
		private static extern int sys_kill (int pid, int sig);
		
		[DllImport (LIBC, SetLastError=true, EntryPoint="strsignal")]
		private static extern IntPtr sys_strsignal (int sig);
		[DllImport (MPH, EntryPoint="Mono_Posix_Syscall_L_ctermid")]
		private static extern int _L_ctermid ();
		
		[DllImport (MPH, EntryPoint="Mono_Posix_Syscall_L_cuserid")]
		private static extern int _L_cuserid ();
		
		[DllImport (LIBC, SetLastError=true, EntryPoint="cuserid")]
		private static extern IntPtr sys_cuserid ([Out] StringBuilder @string);
		[DllImport (LIBC, SetLastError=true)]
		public static extern int mkstemp (StringBuilder template);
		
		[DllImport (LIBC, SetLastError=true)]
		public static extern int ttyslot ();
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_strerror_r")]
		private static extern int sys_strerror_r (int errnum, 
		[Out] StringBuilder buf, ulong n);
		
		[DllImport (LIBC, SetLastError=true, EntryPoint="epoll_create")]
		private static extern int sys_epoll_create (int size);
		
		[DllImport (LIBC, SetLastError=true, EntryPoint="epoll_create1")]
		private static extern int sys_epoll_create1 (EpollFlags flags);
		
		[DllImport (LIBC, SetLastError=true, EntryPoint="epoll_ctl")]
		private static extern int sys_epoll_ctl (int epfd, EpollOp op, int fd, ref EpollEvent ee);
		
		[DllImport (LIBC, SetLastError=true, EntryPoint="epoll_wait")]
		private static extern int sys_epoll_wait (int epfd, EpollEvent [] ee, int maxevents, int timeout);
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_posix_madvise")]
		public static extern int posix_madvise (IntPtr addr, ulong len, 
		PosixMadviseAdvice advice);
		
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_mmap")]
		public static extern IntPtr mmap (IntPtr start, ulong length, 
		MmapProts prot, MmapFlags flags, int fd, long offset);
		
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_munmap")]
		public static extern int munmap (IntPtr start, ulong length);
		
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_mprotect")]
		public static extern int mprotect (IntPtr start, ulong len, MmapProts prot);
		
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_msync")]
		public static extern int msync (IntPtr start, ulong len, MsyncFlags flags);
		
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_mlock")]
		public static extern int mlock (IntPtr start, ulong len);
		
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_munlock")]
		public static extern int munlock (IntPtr start, ulong len);
		
		[DllImport (LIBC, SetLastError=true, EntryPoint="mlockall")]
		private static extern int sys_mlockall (int flags);
		
		[DllImport (LIBC, SetLastError=true)]
		public static extern int munlockall ();
		
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_mremap")]
		public static extern IntPtr mremap (IntPtr old_address, ulong old_size, 
		ulong new_size, MremapFlags flags);
		
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_mincore")]
		public static extern int mincore (IntPtr start, ulong length, byte[] vec);
		
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_remap_file_pages")]
		public static extern int remap_file_pages (IntPtr start, ulong size,
		MmapProts prot, long pgoff, MmapFlags flags);
		
		[DllImport (LIBC, SetLastError=true, EntryPoint="poll")]
		private static extern int sys_poll (_pollfd[] ufds, uint nfds, int timeout);
		
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_sendfile")]
		public static extern long sendfile (int out_fd, int in_fd, 
		ref long offset, ulong count);
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_stat")]
		public static extern int stat (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string file_name, out Stat buf);
		
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_fstat")]
		public static extern int fstat (int filedes, out Stat buf);
		
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_lstat")]
		public static extern int lstat (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string file_name, out Stat buf);
		[DllImport (LIBC, SetLastError=true, EntryPoint="chmod")]
		private static extern int sys_chmod (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string path, uint mode);
		[DllImport (LIBC, SetLastError=true, EntryPoint="fchmod")]
		private static extern int sys_fchmod (int filedes, uint mode);
		[DllImport (LIBC, SetLastError=true, EntryPoint="umask")]
		private static extern uint sys_umask (uint mask);
		[DllImport (LIBC, SetLastError=true, EntryPoint="mkdir")]
		private static extern int sys_mkdir (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string oldpath, uint mode);
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_mknod")]
		public static extern int mknod (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string pathname, FilePermissions mode, ulong dev);
		[DllImport (LIBC, SetLastError=true, EntryPoint="mkfifo")]
		private static extern int sys_mkfifo (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string pathname, uint mode);
		
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_statvfs")]
		public static extern int statvfs (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string path, out Statvfs buf);
		
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_fstatvfs")]
		public static extern int fstatvfs (int fd, out Statvfs buf);
		
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_gettimeofday")]
		public static extern int gettimeofday (out Timeval tv, out Timezone tz);
		
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_gettimeofday")]
		private static extern int gettimeofday (out Timeval tv, IntPtr ignore);
		
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_gettimeofday")]
		private static extern int gettimeofday (IntPtr ignore, out Timezone tz);
		
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_settimeofday")]
		public static extern int settimeofday (ref Timeval tv, ref Timezone tz);
		
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_gettimeofday")]
		private static extern int settimeofday (ref Timeval tv, IntPtr ignore);
		
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_utimes")]
		private static extern int sys_utimes (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string filename, Timeval[] tvp);
		
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_lutimes")]
		private static extern int sys_lutimes (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string filename, Timeval[] tvp);
		
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_futimes")]
		private static extern int sys_futimes (int fd, Timeval[] tvp);
		
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_uname")]
		private static extern int sys_uname (out _Utsname buf);
		[DllImport (LIBC, SetLastError=true)]
		public static extern int wait (out int status);
		[DllImport (LIBC, SetLastError=true)]
		private static extern int waitpid (int pid, out int status, int options);
		
		[DllImport (MPH, EntryPoint="Mono_Posix_Syscall_WIFEXITED")]
		private static extern int _WIFEXITED (int status);
		
		[DllImport (MPH, EntryPoint="Mono_Posix_Syscall_WEXITSTATUS")]
		public static extern int WEXITSTATUS (int status);
		
		[DllImport (MPH, EntryPoint="Mono_Posix_Syscall_WIFSIGNALED")]
		private static extern int _WIFSIGNALED (int status);
		
		[DllImport (MPH, EntryPoint="Mono_Posix_Syscall_WTERMSIG")]
		private static extern int _WTERMSIG (int status);
		
		[DllImport (MPH, EntryPoint="Mono_Posix_Syscall_WIFSTOPPED")]
		private static extern int _WIFSTOPPED (int status);
		
		[DllImport (MPH, EntryPoint="Mono_Posix_Syscall_WSTOPSIG")]
		private static extern int _WSTOPSIG (int status);
		
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_openlog")]
		private static extern int sys_openlog (IntPtr ident, int option, int facility);
		
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_syslog")]
		private static extern int sys_syslog (int priority, string message);
		
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_closelog")]
		public static extern int closelog ();
		
		[DllImport (LIBC, SetLastError=true, EntryPoint="setlogmask")]
		private static extern int sys_setlogmask (int mask);
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_nanosleep")]
		public static extern int nanosleep (ref Timespec req, ref Timespec rem);
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_stime")]
		public static extern int stime (ref long t);
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_time")]
		public static extern long time (out long t);
		
		[DllImport (LIBC, SetLastError=true, EntryPoint="access")]
		private static extern int sys_access (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string pathname, int mode);
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_lseek")]
		private static extern long sys_lseek (int fd, long offset, int whence);
		
		[DllImport (LIBC, SetLastError=true)]
		public static extern int close (int fd);
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_read")]
		public static extern long read (int fd, IntPtr buf, ulong count);
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_write")]
		public static extern long write (int fd, IntPtr buf, ulong count);
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_pread")]
		public static extern long pread (int fd, IntPtr buf, ulong count, long offset);
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_pwrite")]
		public static extern long pwrite (int fd, IntPtr buf, ulong count, long offset);
		
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_pipe")]
		public static extern int pipe (out int reading, out int writing);
		
		[DllImport (LIBC, SetLastError=true)]
		public static extern uint alarm (uint seconds);
		
		[DllImport (LIBC, SetLastError=true)]
		public static extern uint sleep (uint seconds);
		
		[DllImport (LIBC, SetLastError=true)]
		public static extern uint ualarm (uint usecs, uint interval);
		
		[DllImport (LIBC, SetLastError=true)]
		public static extern int pause ();
		[DllImport (LIBC, SetLastError=true)]
		public static extern int chown (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string path, uint owner, uint group);
		[DllImport (LIBC, SetLastError=true)]
		public static extern int fchown (int fd, uint owner, uint group);
		[DllImport (LIBC, SetLastError=true)]
		public static extern int lchown (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string path, uint owner, uint group);
		
		[DllImport (LIBC, SetLastError=true)]
		public static extern int chdir (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string path);
		
		[DllImport (LIBC, SetLastError=true)]
		public static extern int fchdir (int fd);
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_getcwd")]
		public static extern IntPtr getcwd ([Out] StringBuilder buf, ulong size);
		
		[DllImport (LIBC, SetLastError=true)]
		public static extern int dup (int fd);
		
		[DllImport (LIBC, SetLastError=true)]
		public static extern int dup2 (int fd, int fd2);
		
		[DllImport (LIBC, SetLastError=true)]
		public static extern int execve (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string path, string[] argv, string[] envp);
		
		[DllImport (LIBC, SetLastError=true)]
		public static extern int fexecve (int fd, string[] argv, string[] envp);
		
		[DllImport (LIBC, SetLastError=true)]
		public static extern int execv (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string path, string[] argv);
		
		[DllImport (LIBC, SetLastError=true)]
		public static extern int execvp (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string path, string[] argv);
		
		[DllImport (LIBC, SetLastError=true)]
		public static extern int nice (int inc);
		
		[DllImport (LIBC, SetLastError=true)]
		[CLSCompliant (false)]
		public static extern int _exit (int status);
		
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_fpathconf")]
		public static extern long fpathconf (int filedes, PathconfName name, Errno defaultError);
		
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_pathconf")]
		public static extern long pathconf (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string path, PathconfName name, Errno defaultError);
		
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_sysconf")]
		public static extern long sysconf (SysconfName name, Errno defaultError);
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_confstr")]
		public static extern ulong confstr (ConfstrName name, [Out] StringBuilder buf, ulong len);
		[DllImport (LIBC, SetLastError=true)]
		public static extern int getpid ();
		[DllImport (LIBC, SetLastError=true)]
		public static extern int getppid ();
		[DllImport (LIBC, SetLastError=true)]
		public static extern int setpgid (int pid, int pgid);
		[DllImport (LIBC, SetLastError=true)]
		public static extern int getpgid (int pid);
		
		[DllImport (LIBC, SetLastError=true)]
		public static extern int setpgrp ();
		[DllImport (LIBC, SetLastError=true)]
		public static extern int getpgrp ();
		[DllImport (LIBC, SetLastError=true)]
		public static extern int setsid ();
		[DllImport (LIBC, SetLastError=true)]
		public static extern int getsid (int pid);
		[DllImport (LIBC, SetLastError=true)]
		public static extern uint getuid ();
		[DllImport (LIBC, SetLastError=true)]
		public static extern uint geteuid ();
		[DllImport (LIBC, SetLastError=true)]
		public static extern uint getgid ();
		[DllImport (LIBC, SetLastError=true)]
		public static extern uint getegid ();
		[DllImport (LIBC, SetLastError=true)]
		public static extern int getgroups (int size, uint[] list);
		[DllImport (LIBC, SetLastError=true)]
		public static extern int setuid (uint uid);
		[DllImport (LIBC, SetLastError=true)]
		public static extern int setreuid (uint ruid, uint euid);
		[DllImport (LIBC, SetLastError=true)]
		public static extern int setregid (uint rgid, uint egid);
		[DllImport (LIBC, SetLastError=true)]
		public static extern int seteuid (uint euid);
		[DllImport (LIBC, SetLastError=true)]
		public static extern int setegid (uint uid);
		[DllImport (LIBC, SetLastError=true)]
		public static extern int setgid (uint gid);
		[DllImport (LIBC, SetLastError=true)]
		public static extern int getresuid (out uint ruid, out uint euid, out uint suid);
		[DllImport (LIBC, SetLastError=true)]
		public static extern int getresgid (out uint rgid, out uint egid, out uint sgid);
		[DllImport (LIBC, SetLastError=true)]
		public static extern int setresuid (uint ruid, uint euid, uint suid);
		[DllImport (LIBC, SetLastError=true)]
		public static extern int setresgid (uint rgid, uint egid, uint sgid);
		"shutdown code.\nUse System.Diagnostics.Process instead")]
		private static extern int fork ();
		"shutdown code.\nUse System.Diagnostics.Process instead")]
		private static extern int vfork ();
		
		[DllImport (LIBC, SetLastError=true, EntryPoint="ttyname")]
		private static extern IntPtr sys_ttyname (int fd);
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_ttyname_r")]
		public static extern int ttyname_r (int fd, [Out] StringBuilder buf, ulong buflen);
		
		[DllImport (LIBC, EntryPoint="isatty")]
		private static extern int sys_isatty (int fd);
		
		[DllImport (LIBC, SetLastError=true)]
		public static extern int link (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string oldpath, 
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string newpath);
		
		[DllImport (LIBC, SetLastError=true)]
		public static extern int symlink (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string oldpath, 
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string newpath);
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_readlink")]
		public static extern int readlink (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string path, [Out] StringBuilder buf, ulong bufsiz);
		
		[DllImport (LIBC, SetLastError=true)]
		public static extern int unlink (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string pathname);
		
		[DllImport (LIBC, SetLastError=true)]
		public static extern int rmdir (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string pathname);
		[DllImport (LIBC, SetLastError=true)]
		public static extern int tcgetpgrp (int fd);
		[DllImport (LIBC, SetLastError=true)]
		public static extern int tcsetpgrp (int fd, int pgrp);
		
		[DllImport (LIBC, SetLastError=true, EntryPoint="getlogin")]
		private static extern IntPtr sys_getlogin ();
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_getlogin_r")]
		public static extern int getlogin_r ([Out] StringBuilder name, ulong bufsize);
		
		[DllImport (LIBC, SetLastError=true)]
		public static extern int setlogin (string name);
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_gethostname")]
		public static extern int gethostname ([Out] StringBuilder name, ulong len);
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_sethostname")]
		public static extern int sethostname (string name, ulong len);
		
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_gethostid")]
		public static extern long gethostid ();
		
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_sethostid")]
		public static extern int sethostid (long hostid);
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_getdomainname")]
		public static extern int getdomainname ([Out] StringBuilder name, ulong len);
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_setdomainname")]
		public static extern int setdomainname (string name, ulong len);
		
		[DllImport (LIBC, SetLastError=true)]
		public static extern int vhangup ();
		
		[DllImport (LIBC, SetLastError=true)]
		public static extern int revoke (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string file);
		
		[DllImport (LIBC, SetLastError=true)]
		public static extern int acct (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string filename);
		
		[DllImport (LIBC, SetLastError=true, EntryPoint="getusershell")]
		private static extern IntPtr sys_getusershell ();
		
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_setusershell")]
		private static extern int sys_setusershell ();
		
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_endusershell")]
		private static extern int sys_endusershell ();
		
#if false
		[DllImport (LIBC, SetLastError=true)]
		private static extern int daemon (int nochdir, int noclose);
#endif
		
		[DllImport (LIBC, SetLastError=true)]
		public static extern int chroot (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string path);
		
		[DllImport (LIBC, SetLastError=true)]
		public static extern int fsync (int fd);
		
		[DllImport (LIBC, SetLastError=true)]
		public static extern int fdatasync (int fd);
		
		[DllImport (MPH, SetLastError=true,
		EntryPoint="Mono_Posix_Syscall_sync")]
		public static extern int sync ();
		
		[DllImport (LIBC, SetLastError=true)]
		[Obsolete ("Dropped in POSIX 1003.1-2001.  " +
		"Use Syscall.sysconf (SysconfName._SC_PAGESIZE).")]
		public static extern int getpagesize ();
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_truncate")]
		public static extern int truncate (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string path, long length);
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_ftruncate")]
		public static extern int ftruncate (int fd, long length);
		
		[DllImport (LIBC, SetLastError=true)]
		public static extern int getdtablesize ();
		
		[DllImport (LIBC, SetLastError=true)]
		public static extern int brk (IntPtr end_data_segment);
		
		[DllImport (LIBC, SetLastError=true)]
		public static extern IntPtr sbrk (IntPtr increment);
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_lockf")]
		public static extern int lockf (int fd, LockfCommand cmd, long len);
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_swab")]
		public static extern int swab (IntPtr from, IntPtr to, long n);
		
		[DllImport (MPH, SetLastError=true, 
		EntryPoint="Mono_Posix_Syscall_utime")]
		private static extern int sys_utime (
		[MarshalAs (UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(FileNameMarshaler))]
		string filename, ref Utimbuf buf, int use_buf);

	}
}
