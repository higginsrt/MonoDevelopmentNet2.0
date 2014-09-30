//
// PipeWin32.cs
//
// Author:
//	Atsushi Enomoto <atsushi@ximian.com>
//
// Copyright (C) 2009 Novell, Inc.  http://www.novell.com
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

#if !BOOTSTRAP_BASIC

using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Security.Principal;
using System.Text;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

namespace System.IO.Pipes
{
	 partial class Win32Marshal
	{
		
		[DllImport ("kernel32")]
		internal static extern bool CreatePipe (out IntPtr readHandle, out IntPtr writeHandle, ref SecurityAttributesHack pipeAtts, int size);
		
		[DllImport ("kernel32")]
		internal static extern IntPtr CreateNamedPipe (string name, uint openMode, int pipeMode, int maxInstances, int outBufferSize, int inBufferSize, int defaultTimeout, ref SecurityAttributesHack securityAttributes, IntPtr atts);
		
		[DllImport ("kernel32")]
		internal static extern bool ConnectNamedPipe (SafePipeHandle handle, IntPtr overlapped);
		
		[DllImport ("kernel32")]
		internal static extern bool DisconnectNamedPipe (SafePipeHandle handle);
		
		[DllImport ("kernel32")]
		internal static extern bool GetNamedPipeHandleState (SafePipeHandle handle, out int state, out int curInstances, out int maxCollectionCount, out int collectDateTimeout, byte [] userName, int maxUserNameSize);
		
		[DllImport ("kernel32")]
		internal static extern bool WaitNamedPipe (string name, int timeout);
		
		[DllImport ("kernel32")]
		internal static extern IntPtr CreateFile (string name, PipeAccessRights desiredAccess, FileShare fileShare, ref SecurityAttributesHack atts, int creationDisposition, int flags, IntPtr templateHandle);

	}
}
