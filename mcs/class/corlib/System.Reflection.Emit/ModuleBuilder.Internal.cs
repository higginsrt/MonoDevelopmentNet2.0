
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

//
// System.Reflection.Emit/ModuleBuilder.cs
//
// Author:
//   Paolo Molaro (lupus@ximian.com)
//
// (C) 2001 Ximian, Inc.  http://www.ximian.com
//

using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics.SymbolStore;
using System.IO;
using System.Resources;
using System.Globalization;

namespace System.Reflection.Emit
{
	public partial class ModuleBuilder
	{
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern void basic_init (ModuleBuilder ab);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern void set_wrappers_type (ModuleBuilder mb, Type ab);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern Type create_modified_type (TypeBuilder tb, string modifiers);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern int getUSIndex (ModuleBuilder mb, string str);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern int getToken (ModuleBuilder mb, object obj, bool create_open_instance);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern int getMethodToken (ModuleBuilder mb, MethodInfo method,
		Type[] opt_param_types);
		
		/*
		* Register the token->obj mapping with the runtime so the Module.Resolve... 
		* methods will work for obj.
		*/
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		internal extern void RegisterToken (object obj, int token);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private static extern void build_metadata (ModuleBuilder mb);
		
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		private extern void WriteToFile (IntPtr handle);

	}
}
