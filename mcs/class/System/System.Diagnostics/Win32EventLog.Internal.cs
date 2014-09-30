//
// System.Diagnostics.Win32EventLog.cs
//
// Author:
//	Gert Driesen <driesen@users.sourceforge.net>
//
// Copyright (C) 2006 Novell, Inc (http://www.novell.com)
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
			[DllImport ("advapi32.dll", SetLastError=true)]
			public static extern int ClearEventLog (IntPtr hEventLog, string lpBackupFileName);
			
			[DllImport ("advapi32.dll", SetLastError=true)]
			public static extern int CloseEventLog (IntPtr hEventLog);
			
			[DllImport ("advapi32.dll", SetLastError=true)]
			public static extern int DeregisterEventSource (IntPtr hEventLog);
			
			[DllImport ("kernel32.dll", CharSet=CharSet.Auto, SetLastError=true)]
			public static extern int FormatMessage (FormatMessageFlags dwFlags, IntPtr lpSource, uint dwMessageId, int dwLanguageId, ref IntPtr lpBuffer, int nSize, IntPtr [] arguments);
			
			[DllImport ("kernel32.dll", SetLastError=true)]
			public static extern bool FreeLibrary (IntPtr hModule);
			
			[DllImport ("advapi32.dll", SetLastError=true)]
			public static extern int GetNumberOfEventLogRecords (IntPtr hEventLog, ref int NumberOfRecords);
			
			[DllImport ("advapi32.dll", SetLastError=true)]
			public static extern int GetOldestEventLogRecord (IntPtr hEventLog, ref int OldestRecord);
			
			[DllImport ("kernel32.dll", SetLastError=true)]
			public static extern IntPtr LoadLibraryEx (string lpFileName, IntPtr hFile, LoadFlags dwFlags);
			
			[DllImport ("kernel32.dll", SetLastError=true)]
			public static extern IntPtr LocalFree (IntPtr hMem);
			
			[DllImport ("advapi32.dll", SetLastError=true)]
			public static extern bool LookupAccountSid (
			string lpSystemName,
			[MarshalAs (UnmanagedType.LPArray)] byte [] Sid,
			StringBuilder lpName,
			ref uint cchName,
			StringBuilder ReferencedDomainName,
			ref uint cchReferencedDomainName,
			out SidNameUse peUse);
			
			[DllImport ("Advapi32.dll", SetLastError = true)]
			public static extern int NotifyChangeEventLog (IntPtr hEventLog, IntPtr hEvent);
			
			[DllImport ("advapi32.dll", SetLastError=true)]
			public static extern IntPtr OpenEventLog (string machineName, string logName);
			
			[DllImport ("advapi32.dll", SetLastError=true)]
			public static extern IntPtr RegisterEventSource (string machineName, string sourceName);
			
			[DllImport ("Advapi32.dll", SetLastError=true)]
			public static extern int ReportEvent (IntPtr hHandle, ushort wType,
			ushort wCategory, uint dwEventID, IntPtr sid, ushort wNumStrings,
			uint dwDataSize, string [] lpStrings, byte [] lpRawData);
			
			[DllImport ("advapi32.dll", SetLastError=true)]
			public static extern int ReadEventLog (IntPtr hEventLog, ReadFlags dwReadFlags, int dwRecordOffset, byte [] buffer, int nNumberOfBytesToRead, ref int pnBytesRead, ref int pnMinNumberOfBytesNeeded);

		}
	}
}
