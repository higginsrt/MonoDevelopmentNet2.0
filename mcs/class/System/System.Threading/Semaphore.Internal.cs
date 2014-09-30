//
// System.Threading.Semaphore.cs
//
// Author:
//	Sebastien Pouliot  <sebastien@ximian.com>
//
// Copyright (C) 2005 Novell, Inc (http://www.novell.com)
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

#if NET_2_0

using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Runtime.CompilerServices;
using System.IO;

namespace System.Threading
{
	public partial class Semaphore
	{
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern IntPtr CreateSemaphore_internal (
		int initialCount, int maximumCount, string name,
		out bool createdNew);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern int ReleaseSemaphore_internal (
		IntPtr handle, int releaseCount, out bool fail);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private static extern IntPtr OpenSemaphore_internal (string name, SemaphoreRights rights, out MonoIOError error);

	}
}
