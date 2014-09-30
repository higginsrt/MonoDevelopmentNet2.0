//
// System.NumberFormatter.cs
//
// Author:
//   Kazuki Oikawa (kazuki@panicode.com)
//   Eyal Alaluf (eyala@mainsoft.com)
//
// Copyright (C) 2004 Novell, Inc (http://www.novell.com)
// Copyright (C) 2008 Mainsoft Co. (http://www.mainsoft.com)
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

// NumberFormatter is shared with Grasshopper and hence the #if TARGET_JVM for
// marking the use of unsafe code that is not supported in Grasshopper.

using System.Globalization;
using System.Text;
using System.Threading;
using System.Runtime.CompilerServices;

namespace System
{
	 partial class NumberFormatter
	{
		
		[MethodImplAttribute(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		private unsafe static extern void GetFormatterTables (out ulong* MantissaBitsTable, out int* TensExponentTable,
		out char* DigitLowerTable, out char* DigitUpperTable,
		out long* TenPowersList, out int* DecHexDigits);

	}
}
