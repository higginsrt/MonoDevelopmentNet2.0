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
using System.Runtime.InteropServices;
using Mono.Unix.Native;

namespace Mono.Unix.Native
{
	public partial class NativeConvert
	{
		private static int FromAccessModes (AccessModes value, out Int32 rval)
		{
			throw new System.NotImplementedException();
		}
		private static int ToAccessModes (Int32 value, out AccessModes rval)
		{
			throw new System.NotImplementedException();
		}
		private static int FromConfstrName (ConfstrName value, out Int32 rval)
		{
			throw new System.NotImplementedException();
		}
		private static int ToConfstrName (Int32 value, out ConfstrName rval)
		{
			throw new System.NotImplementedException();
		}
		private static int FromDirectoryNotifyFlags (DirectoryNotifyFlags value, out Int32 rval)
		{
			throw new System.NotImplementedException();
		}
		private static int ToDirectoryNotifyFlags (Int32 value, out DirectoryNotifyFlags rval)
		{
			throw new System.NotImplementedException();
		}
		private static int FromEpollEvents (EpollEvents value, out UInt32 rval)
		{
			throw new System.NotImplementedException();
		}
		private static int ToEpollEvents (UInt32 value, out EpollEvents rval)
		{
			throw new System.NotImplementedException();
		}
		private static int FromEpollFlags (EpollFlags value, out Int32 rval)
		{
			throw new System.NotImplementedException();
		}
		private static int ToEpollFlags (Int32 value, out EpollFlags rval)
		{
			throw new System.NotImplementedException();
		}
		private static int FromErrno (Errno value, out Int32 rval)
		{
			throw new System.NotImplementedException();
		}
		private static int ToErrno (Int32 value, out Errno rval)
		{
			throw new System.NotImplementedException();
		}
		private static int FromFcntlCommand (FcntlCommand value, out Int32 rval)
		{
			throw new System.NotImplementedException();
		}
		private static int ToFcntlCommand (Int32 value, out FcntlCommand rval)
		{
			throw new System.NotImplementedException();
		}
		private static int FromFilePermissions (FilePermissions value, out UInt32 rval)
		{
			throw new System.NotImplementedException();
		}
		private static int ToFilePermissions (UInt32 value, out FilePermissions rval)
		{
			throw new System.NotImplementedException();
		}
		private static int FromFlock (ref Flock source, IntPtr destination)
		{
			throw new System.NotImplementedException();
		}
		private static int ToFlock (IntPtr source, out Flock destination)
		{
			throw new System.NotImplementedException();
		}
		private static int FromLockType (LockType value, out Int16 rval)
		{
			throw new System.NotImplementedException();
		}
		private static int ToLockType (Int16 value, out LockType rval)
		{
			throw new System.NotImplementedException();
		}
		private static int FromLockfCommand (LockfCommand value, out Int32 rval)
		{
			throw new System.NotImplementedException();
		}
		private static int ToLockfCommand (Int32 value, out LockfCommand rval)
		{
			throw new System.NotImplementedException();
		}
		private static int FromMlockallFlags (MlockallFlags value, out Int32 rval)
		{
			throw new System.NotImplementedException();
		}
		private static int ToMlockallFlags (Int32 value, out MlockallFlags rval)
		{
			throw new System.NotImplementedException();
		}
		private static int FromMmapFlags (MmapFlags value, out Int32 rval)
		{
			throw new System.NotImplementedException();
		}
		private static int ToMmapFlags (Int32 value, out MmapFlags rval)
		{
			throw new System.NotImplementedException();
		}
		private static int FromMmapProts (MmapProts value, out Int32 rval)
		{
			throw new System.NotImplementedException();
		}
		private static int ToMmapProts (Int32 value, out MmapProts rval)
		{
			throw new System.NotImplementedException();
		}
		private static int FromMountFlags (MountFlags value, out UInt64 rval)
		{
			throw new System.NotImplementedException();
		}
		private static int ToMountFlags (UInt64 value, out MountFlags rval)
		{
			throw new System.NotImplementedException();
		}
		private static int FromMremapFlags (MremapFlags value, out UInt64 rval)
		{
			throw new System.NotImplementedException();
		}
		private static int ToMremapFlags (UInt64 value, out MremapFlags rval)
		{
			throw new System.NotImplementedException();
		}
		private static int FromMsyncFlags (MsyncFlags value, out Int32 rval)
		{
			throw new System.NotImplementedException();
		}
		private static int ToMsyncFlags (Int32 value, out MsyncFlags rval)
		{
			throw new System.NotImplementedException();
		}
		private static int FromOpenFlags (OpenFlags value, out Int32 rval)
		{
			throw new System.NotImplementedException();
		}
		private static int ToOpenFlags (Int32 value, out OpenFlags rval)
		{
			throw new System.NotImplementedException();
		}
		private static int FromPathconfName (PathconfName value, out Int32 rval)
		{
			throw new System.NotImplementedException();
		}
		private static int ToPathconfName (Int32 value, out PathconfName rval)
		{
			throw new System.NotImplementedException();
		}
		private static int FromPollEvents (PollEvents value, out Int16 rval)
		{
			throw new System.NotImplementedException();
		}
		private static int ToPollEvents (Int16 value, out PollEvents rval)
		{
			throw new System.NotImplementedException();
		}
		private static int FromPollfd (ref Pollfd source, IntPtr destination)
		{
			throw new System.NotImplementedException();
		}
		private static int ToPollfd (IntPtr source, out Pollfd destination)
		{
			throw new System.NotImplementedException();
		}
		private static int FromPosixFadviseAdvice (PosixFadviseAdvice value, out Int32 rval)
		{
			throw new System.NotImplementedException();
		}
		private static int ToPosixFadviseAdvice (Int32 value, out PosixFadviseAdvice rval)
		{
			throw new System.NotImplementedException();
		}
		private static int FromPosixMadviseAdvice (PosixMadviseAdvice value, out Int32 rval)
		{
			throw new System.NotImplementedException();
		}
		private static int ToPosixMadviseAdvice (Int32 value, out PosixMadviseAdvice rval)
		{
			throw new System.NotImplementedException();
		}
		private static int FromSeekFlags (SeekFlags value, out Int16 rval)
		{
			throw new System.NotImplementedException();
		}
		private static int ToSeekFlags (Int16 value, out SeekFlags rval)
		{
			throw new System.NotImplementedException();
		}
		private static int FromSignum (Signum value, out Int32 rval)
		{
			throw new System.NotImplementedException();
		}
		private static int ToSignum (Int32 value, out Signum rval)
		{
			throw new System.NotImplementedException();
		}
		private static int FromStat (ref Stat source, IntPtr destination)
		{
			throw new System.NotImplementedException();
		}
		private static int ToStat (IntPtr source, out Stat destination)
		{
			throw new System.NotImplementedException();
		}
		private static int FromSysconfName (SysconfName value, out Int32 rval)
		{
			throw new System.NotImplementedException();
		}
		private static int ToSysconfName (Int32 value, out SysconfName rval)
		{
			throw new System.NotImplementedException();
		}
		private static int FromSyslogFacility (SyslogFacility value, out Int32 rval)
		{
			throw new System.NotImplementedException();
		}
		private static int ToSyslogFacility (Int32 value, out SyslogFacility rval)
		{
			throw new System.NotImplementedException();
		}
		private static int FromSyslogLevel (SyslogLevel value, out Int32 rval)
		{
			throw new System.NotImplementedException();
		}
		private static int ToSyslogLevel (Int32 value, out SyslogLevel rval)
		{
			throw new System.NotImplementedException();
		}
		private static int FromSyslogOptions (SyslogOptions value, out Int32 rval)
		{
			throw new System.NotImplementedException();
		}
		private static int ToSyslogOptions (Int32 value, out SyslogOptions rval)
		{
			throw new System.NotImplementedException();
		}
		private static int FromTimespec (ref Timespec source, IntPtr destination)
		{
			throw new System.NotImplementedException();
		}
		private static int ToTimespec (IntPtr source, out Timespec destination)
		{
			throw new System.NotImplementedException();
		}
		private static int FromTimeval (ref Timeval source, IntPtr destination)
		{
			throw new System.NotImplementedException();
		}
		private static int ToTimeval (IntPtr source, out Timeval destination)
		{
			throw new System.NotImplementedException();
		}
		private static int FromTimezone (ref Timezone source, IntPtr destination)
		{
			throw new System.NotImplementedException();
		}
		private static int ToTimezone (IntPtr source, out Timezone destination)
		{
			throw new System.NotImplementedException();
		}
		private static int FromUtimbuf (ref Utimbuf source, IntPtr destination)
		{
			throw new System.NotImplementedException();
		}
		private static int ToUtimbuf (IntPtr source, out Utimbuf destination)
		{
			throw new System.NotImplementedException();
		}
		private static int FromWaitOptions (WaitOptions value, out Int32 rval)
		{
			throw new System.NotImplementedException();
		}
		private static int ToWaitOptions (Int32 value, out WaitOptions rval)
		{
			throw new System.NotImplementedException();
		}
		private static int FromXattrFlags (XattrFlags value, out Int32 rval)
		{
			throw new System.NotImplementedException();
		}
		private static int ToXattrFlags (Int32 value, out XattrFlags rval)
		{
			throw new System.NotImplementedException();
		}

	}
}
