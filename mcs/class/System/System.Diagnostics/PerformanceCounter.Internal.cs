//
// System.Diagnostics.PerformanceCounter.cs
//
// Authors:
//   Jonathan Pryor (jonpryor@vt.edu)
//   Andreas Nahr (ClassDevelopment@A-SoftTech.com)
//
// (C) 2002
// (C) 2003 Andreas Nahr
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
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
#if NET_2_0
using System.Runtime.ConstrainedExecution;
#endif

namespace System.Diagnostics
{
	public partial class PerformanceCounter
	{
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		static extern IntPtr GetImpl (string category, string counter,
		string instance, string machine, out PerformanceCounterType ctype, out bool custom);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		static extern bool GetSample (IntPtr impl, bool only_value, out CounterSample sample);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		static extern long UpdateValue (IntPtr impl, bool do_incr, long value);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		static extern void FreeData (IntPtr impl);

	}
}
