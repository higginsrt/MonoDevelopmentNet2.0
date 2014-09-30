
using System;
using System.Runtime.InteropServices;
using Mono.Unix.Native;

namespace Mono.Unix.Native
{
	public partial class NativeConvert
	{
		
		[DllImport (LIB, EntryPoint="Mono_Posix_FromAccessModes")]
		private static extern int FromAccessModes (AccessModes value, out Int32 rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_ToAccessModes")]
		private static extern int ToAccessModes (Int32 value, out AccessModes rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_FromConfstrName")]
		private static extern int FromConfstrName (ConfstrName value, out Int32 rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_ToConfstrName")]
		private static extern int ToConfstrName (Int32 value, out ConfstrName rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_FromDirectoryNotifyFlags")]
		private static extern int FromDirectoryNotifyFlags (DirectoryNotifyFlags value, out Int32 rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_ToDirectoryNotifyFlags")]
		private static extern int ToDirectoryNotifyFlags (Int32 value, out DirectoryNotifyFlags rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_FromEpollEvents")]
		private static extern int FromEpollEvents (EpollEvents value, out UInt32 rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_ToEpollEvents")]
		private static extern int ToEpollEvents (UInt32 value, out EpollEvents rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_FromEpollFlags")]
		private static extern int FromEpollFlags (EpollFlags value, out Int32 rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_ToEpollFlags")]
		private static extern int ToEpollFlags (Int32 value, out EpollFlags rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_FromErrno")]
		private static extern int FromErrno (Errno value, out Int32 rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_ToErrno")]
		private static extern int ToErrno (Int32 value, out Errno rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_FromFcntlCommand")]
		private static extern int FromFcntlCommand (FcntlCommand value, out Int32 rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_ToFcntlCommand")]
		private static extern int ToFcntlCommand (Int32 value, out FcntlCommand rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_FromFilePermissions")]
		private static extern int FromFilePermissions (FilePermissions value, out UInt32 rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_ToFilePermissions")]
		private static extern int ToFilePermissions (UInt32 value, out FilePermissions rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_FromFlock")]
		private static extern int FromFlock (ref Flock source, IntPtr destination);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_ToFlock")]
		private static extern int ToFlock (IntPtr source, out Flock destination);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_FromLockType")]
		private static extern int FromLockType (LockType value, out Int16 rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_ToLockType")]
		private static extern int ToLockType (Int16 value, out LockType rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_FromLockfCommand")]
		private static extern int FromLockfCommand (LockfCommand value, out Int32 rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_ToLockfCommand")]
		private static extern int ToLockfCommand (Int32 value, out LockfCommand rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_FromMlockallFlags")]
		private static extern int FromMlockallFlags (MlockallFlags value, out Int32 rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_ToMlockallFlags")]
		private static extern int ToMlockallFlags (Int32 value, out MlockallFlags rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_FromMmapFlags")]
		private static extern int FromMmapFlags (MmapFlags value, out Int32 rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_ToMmapFlags")]
		private static extern int ToMmapFlags (Int32 value, out MmapFlags rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_FromMmapProts")]
		private static extern int FromMmapProts (MmapProts value, out Int32 rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_ToMmapProts")]
		private static extern int ToMmapProts (Int32 value, out MmapProts rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_FromMountFlags")]
		private static extern int FromMountFlags (MountFlags value, out UInt64 rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_ToMountFlags")]
		private static extern int ToMountFlags (UInt64 value, out MountFlags rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_FromMremapFlags")]
		private static extern int FromMremapFlags (MremapFlags value, out UInt64 rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_ToMremapFlags")]
		private static extern int ToMremapFlags (UInt64 value, out MremapFlags rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_FromMsyncFlags")]
		private static extern int FromMsyncFlags (MsyncFlags value, out Int32 rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_ToMsyncFlags")]
		private static extern int ToMsyncFlags (Int32 value, out MsyncFlags rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_FromOpenFlags")]
		private static extern int FromOpenFlags (OpenFlags value, out Int32 rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_ToOpenFlags")]
		private static extern int ToOpenFlags (Int32 value, out OpenFlags rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_FromPathconfName")]
		private static extern int FromPathconfName (PathconfName value, out Int32 rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_ToPathconfName")]
		private static extern int ToPathconfName (Int32 value, out PathconfName rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_FromPollEvents")]
		private static extern int FromPollEvents (PollEvents value, out Int16 rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_ToPollEvents")]
		private static extern int ToPollEvents (Int16 value, out PollEvents rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_FromPollfd")]
		private static extern int FromPollfd (ref Pollfd source, IntPtr destination);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_ToPollfd")]
		private static extern int ToPollfd (IntPtr source, out Pollfd destination);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_FromPosixFadviseAdvice")]
		private static extern int FromPosixFadviseAdvice (PosixFadviseAdvice value, out Int32 rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_ToPosixFadviseAdvice")]
		private static extern int ToPosixFadviseAdvice (Int32 value, out PosixFadviseAdvice rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_FromPosixMadviseAdvice")]
		private static extern int FromPosixMadviseAdvice (PosixMadviseAdvice value, out Int32 rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_ToPosixMadviseAdvice")]
		private static extern int ToPosixMadviseAdvice (Int32 value, out PosixMadviseAdvice rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_FromSeekFlags")]
		private static extern int FromSeekFlags (SeekFlags value, out Int16 rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_ToSeekFlags")]
		private static extern int ToSeekFlags (Int16 value, out SeekFlags rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_FromSignum")]
		private static extern int FromSignum (Signum value, out Int32 rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_ToSignum")]
		private static extern int ToSignum (Int32 value, out Signum rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_FromStat")]
		private static extern int FromStat (ref Stat source, IntPtr destination);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_ToStat")]
		private static extern int ToStat (IntPtr source, out Stat destination);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_FromSysconfName")]
		private static extern int FromSysconfName (SysconfName value, out Int32 rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_ToSysconfName")]
		private static extern int ToSysconfName (Int32 value, out SysconfName rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_FromSyslogFacility")]
		private static extern int FromSyslogFacility (SyslogFacility value, out Int32 rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_ToSyslogFacility")]
		private static extern int ToSyslogFacility (Int32 value, out SyslogFacility rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_FromSyslogLevel")]
		private static extern int FromSyslogLevel (SyslogLevel value, out Int32 rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_ToSyslogLevel")]
		private static extern int ToSyslogLevel (Int32 value, out SyslogLevel rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_FromSyslogOptions")]
		private static extern int FromSyslogOptions (SyslogOptions value, out Int32 rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_ToSyslogOptions")]
		private static extern int ToSyslogOptions (Int32 value, out SyslogOptions rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_FromTimespec")]
		private static extern int FromTimespec (ref Timespec source, IntPtr destination);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_ToTimespec")]
		private static extern int ToTimespec (IntPtr source, out Timespec destination);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_FromTimeval")]
		private static extern int FromTimeval (ref Timeval source, IntPtr destination);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_ToTimeval")]
		private static extern int ToTimeval (IntPtr source, out Timeval destination);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_FromTimezone")]
		private static extern int FromTimezone (ref Timezone source, IntPtr destination);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_ToTimezone")]
		private static extern int ToTimezone (IntPtr source, out Timezone destination);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_FromUtimbuf")]
		private static extern int FromUtimbuf (ref Utimbuf source, IntPtr destination);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_ToUtimbuf")]
		private static extern int ToUtimbuf (IntPtr source, out Utimbuf destination);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_FromWaitOptions")]
		private static extern int FromWaitOptions (WaitOptions value, out Int32 rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_ToWaitOptions")]
		private static extern int ToWaitOptions (Int32 value, out WaitOptions rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_FromXattrFlags")]
		private static extern int FromXattrFlags (XattrFlags value, out Int32 rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_ToXattrFlags")]
		private static extern int ToXattrFlags (Int32 value, out XattrFlags rval);

	}
}
