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
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

using Microsoft.Win32;

namespace System.Diagnostics
{
	 partial class Win32EventLog
	{

		private partial class PInvoke
		{
			public static int ClearEventLog (IntPtr hEventLog, string lpBackupFileName)
			{
				throw new System.NotImplementedException();
			}
			public static int CloseEventLog (IntPtr hEventLog)
			{
				throw new System.NotImplementedException();
			}
			public static int DeregisterEventSource (IntPtr hEventLog)
			{
				throw new System.NotImplementedException();
			}
			public static int FormatMessage (FormatMessageFlags dwFlags, IntPtr lpSource, uint dwMessageId, int dwLanguageId, ref IntPtr lpBuffer, int nSize, IntPtr [] arguments)
			{
				throw new System.NotImplementedException();
			}
			public static bool FreeLibrary (IntPtr hModule)
			{
				throw new System.NotImplementedException();
			}
			public static int GetNumberOfEventLogRecords (IntPtr hEventLog, ref int NumberOfRecords)
			{
				throw new System.NotImplementedException();
			}
			public static int GetOldestEventLogRecord (IntPtr hEventLog, ref int OldestRecord)
			{
				throw new System.NotImplementedException();
			}
			public static IntPtr LoadLibraryEx (string lpFileName, IntPtr hFile, LoadFlags dwFlags)
			{
				throw new System.NotImplementedException();
			}
			public static IntPtr LocalFree (IntPtr hMem)
			{
				throw new System.NotImplementedException();
			}
			public static bool LookupAccountSid (
			string lpSystemName,
			[MarshalAs (UnmanagedType.LPArray)] byte [] Sid,
			StringBuilder lpName,
			ref uint cchName,
			StringBuilder ReferencedDomainName,
			ref uint cchReferencedDomainName,
			out SidNameUse peUse)
			{
				throw new System.NotImplementedException();
			}
			public static int NotifyChangeEventLog (IntPtr hEventLog, IntPtr hEvent)
			{
				throw new System.NotImplementedException();
			}
			public static IntPtr OpenEventLog (string machineName, string logName)
			{
				throw new System.NotImplementedException();
			}
			public static IntPtr RegisterEventSource (string machineName, string sourceName)
			{
				throw new System.NotImplementedException();
			}
			public static int ReportEvent (IntPtr hHandle, ushort wType,
			ushort wCategory, uint dwEventID, IntPtr sid, ushort wNumStrings,
			uint dwDataSize, string [] lpStrings, byte [] lpRawData)
			{
				throw new System.NotImplementedException();
			}
			public static int ReadEventLog (IntPtr hEventLog, ReadFlags dwReadFlags, int dwRecordOffset, byte [] buffer, int nNumberOfBytesToRead, ref int pnBytesRead, ref int pnMinNumberOfBytesNeeded)
			{
				throw new System.NotImplementedException();
			}

		}
	}
}
