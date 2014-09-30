//
// System.Diagnostics.PerformanceCounterCategory.cs
//
// Authors:
//   Jonathan Pryor (jonpryor@vt.edu)
//
// (C) 2002
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

using System.Security.Permissions;
using System.Runtime.CompilerServices;

namespace System.Diagnostics
{
	public partial class PerformanceCounterCategory
	{
#endif		
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		static extern bool CategoryDelete (string name);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		static extern string CategoryHelpInternal (string category, string machine);
		
		/* this icall allows a null counter and it will just search for the category */
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		static extern bool CounterCategoryExists (string counter, string category, string machine);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		static extern bool Create (string categoryName, string categoryHelp,
		PerformanceCounterCategoryType categoryType, CounterCreationData[] items);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		static extern int InstanceExistsInternal (string instance, string category, string machine);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		static extern string[] GetCategoryNames (string machine);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		static extern string[] GetCounterNames (string category, string machine);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		static extern string[] GetInstanceNames (string category, string machine);

	}
}
