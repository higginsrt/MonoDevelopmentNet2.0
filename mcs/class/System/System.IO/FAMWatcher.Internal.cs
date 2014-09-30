// 
// System.IO.FAM.cs: interface with libfam
//
// Authors:
//	Gonzalo Paniagua Javier (gonzalo@ximian.com)
//
// (c) 2004 Novell, Inc. (http://www.novell.com)
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
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace System.IO
{
	 partial class FAMWatcher
	{
		
		[DllImport ("libfam.so.0", EntryPoint="FAMOpen")]
		extern static int fam_Open (out FAMConnection fc);
		
		[DllImport ("libfam.so.0", EntryPoint="FAMClose")]
		extern static int fam_Close (ref FAMConnection fc);
		
		[DllImport ("libfam.so.0", EntryPoint="FAMMonitorDirectory")]
		extern static int fam_MonitorDirectory (ref FAMConnection fc, string filename,
		out FAMRequest fr, IntPtr user_data);
		
		[DllImport ("libfam.so.0", EntryPoint="FAMCancelMonitor")]
		extern static int fam_CancelMonitor (ref FAMConnection fc, ref FAMRequest fr);
		
		[DllImport ("libfam.so.0", EntryPoint="FAMPending")]
		extern static int fam_Pending (ref FAMConnection fc);
		
		[DllImport ("libgamin-1.so.0", EntryPoint="FAMOpen")]
		extern static int gamin_Open (out FAMConnection fc);
		
		[DllImport ("libgamin-1.so.0", EntryPoint="FAMClose")]
		extern static int gamin_Close (ref FAMConnection fc);
		
		[DllImport ("libgamin-1.so.0", EntryPoint="FAMMonitorDirectory")]
		extern static int gamin_MonitorDirectory (ref FAMConnection fc, string filename,
		out FAMRequest fr, IntPtr user_data);
		
		[DllImport ("libgamin-1.so.0", EntryPoint="FAMCancelMonitor")]
		extern static int gamin_CancelMonitor (ref FAMConnection fc, ref FAMRequest fr);
		
		[DllImport ("libgamin-1.so.0", EntryPoint="FAMPending")]
		extern static int gamin_Pending (ref FAMConnection fc);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern static int InternalFAMNextEvent (ref FAMConnection fc, out string filename,
		out int code, out int reqnum);

	}
}
