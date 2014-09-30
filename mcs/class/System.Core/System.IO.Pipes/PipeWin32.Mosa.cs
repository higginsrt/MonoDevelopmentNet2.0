/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

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
		internal static bool CreatePipe (out IntPtr readHandle, out IntPtr writeHandle, ref SecurityAttributesHack pipeAtts, int size)
		{
			throw new System.NotImplementedException();
		}
		internal static IntPtr CreateNamedPipe (string name, uint openMode, int pipeMode, int maxInstances, int outBufferSize, int inBufferSize, int defaultTimeout, ref SecurityAttributesHack securityAttributes, IntPtr atts)
		{
			throw new System.NotImplementedException();
		}
		internal static bool ConnectNamedPipe (SafePipeHandle handle, IntPtr overlapped)
		{
			throw new System.NotImplementedException();
		}
		internal static bool DisconnectNamedPipe (SafePipeHandle handle)
		{
			throw new System.NotImplementedException();
		}
		internal static bool GetNamedPipeHandleState (SafePipeHandle handle, out int state, out int curInstances, out int maxCollectionCount, out int collectDateTimeout, byte [] userName, int maxUserNameSize)
		{
			throw new System.NotImplementedException();
		}
		internal static bool WaitNamedPipe (string name, int timeout)
		{
			throw new System.NotImplementedException();
		}
		internal static IntPtr CreateFile (string name, PipeAccessRights desiredAccess, FileShare fileShare, ref SecurityAttributesHack atts, int creationDisposition, int flags, IntPtr templateHandle)
		{
			throw new System.NotImplementedException();
		}

	}
}
#endif
