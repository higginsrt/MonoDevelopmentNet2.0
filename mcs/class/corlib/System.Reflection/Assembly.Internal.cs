//
// System.Reflection/Assembly.cs
//
// Author:
//   Paolo Molaro (lupus@ximian.com)
//
// (C) 2001 Ximian, Inc.  http://www.ximian.com
// Copyright (C) 2004-2005 Novell, Inc (http://www.novell.com)
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

using System.Security;
using System.Security.Policy;
using System.Security.Permissions;
using System.Runtime.Serialization;
using System.Reflection;
using System.Reflection.Emit;
using System.IO;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;
using System.Configuration.Assemblies;

using Mono.Security;

namespace System.Reflection
{
	public partial class Assembly
	{
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern string get_code_base (bool escaped);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern string get_fullname ();
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern string get_location ();
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern string InternalImageRuntimeVersion ();
		
		public virtual extern MethodInfo EntryPoint {
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		get;
		}
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal extern bool get_global_assembly_cache ();
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern object GetFilesInternal (String name, bool getResourceModules);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal extern IntPtr GetManifestResourceInternal (String name, out int size, out Module module);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal virtual extern Type[] GetTypes (bool exportedOnly);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal extern Type InternalGetType (Module module, String name, Boolean throwOnError, Boolean ignoreCase);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal extern static void InternalGetAssemblyName (string assemblyFile, AssemblyName aname);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		static extern void FillName (Assembly ass, AssemblyName aname);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public static extern Assembly GetEntryAssembly();
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern static Assembly LoadFrom (String assemblyFile, bool refonly);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private static extern Assembly load_with_partial_name (string name, Evidence e);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal virtual extern Module[] GetModulesInternal ();
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal extern string[] GetNamespaces ();
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern virtual String[] GetManifestResourceNames ();
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static Assembly GetExecutingAssembly ();
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public extern static Assembly GetCallingAssembly ();
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal static extern AssemblyName[] GetReferencedAssemblies (Assembly module);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		private extern bool GetManifestResourceInfoInternal (String name, ManifestResourceInfo info);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal static extern int MonoDebugger_GetMethodToken (MethodBase method);
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal extern Module GetManifestModuleInternal ();
		
		[ComVisible (false)]
		public virtual extern bool ReflectionOnly {
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		get;
		}
		
		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		extern internal static bool LoadPermissions (Assembly a, 
		ref IntPtr minimum, ref int minLength,
		ref IntPtr optional, ref int optLength,
		ref IntPtr refused, ref int refLength);

	}
}
