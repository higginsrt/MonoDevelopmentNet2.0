//
// System.Threading.Monitor.cs
//
// Author:
//   Dick Porter (dick@ximian.com)
//
// (C) Ximian, Inc.  http://www.ximian.com
//

//
// Copyright (C) 2004 Novell, Inc (http://www.novell.com)
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

using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Contexts;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace System.Threading
{
	public partial class Monitor
	{
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static bool Monitor_try_enter(object obj, int ms);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static void Enter(object obj);
		
		[ReliabilityContractAttribute (Consistency.WillNotCorruptState, Cer.Success)]
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		public extern static void Exit(object obj);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static void Monitor_pulse(object obj);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static bool Monitor_test_synchronised(object obj);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static void Monitor_pulse_all(object obj);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern static bool Monitor_wait(object obj, int ms);
		
#if NET_4_0 || MOONLIGHT
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static void try_enter_with_atomic_var (object obj, int millisecondsTimeout, ref bool lockTaken);

	}
}
