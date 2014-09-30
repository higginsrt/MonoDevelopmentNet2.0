/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Reflection.Emit;
using System.Security;
using System.Threading;
using System.Text;

namespace System.Reflection
{
	 partial struct MonoMethodInfo
	{
		static void get_method_info (IntPtr handle, out MonoMethodInfo info)
		{
			throw new System.NotImplementedException();
		}
		static int get_method_attributes (IntPtr handle)
		{
			throw new System.NotImplementedException();
		}
		static ParameterInfo[] get_parameter_info (IntPtr handle, MemberInfo member)
		{
			throw new System.NotImplementedException();
		}
		static UnmanagedMarshal get_retval_marshal (IntPtr handle)
		{
			throw new System.NotImplementedException();
		}

	}
	 partial class MonoMethod
	{
		internal static string get_name (MethodBase method)
		{
			throw new System.NotImplementedException();
		}
		internal static MonoMethod get_base_method (MonoMethod method, bool definition)
		{
			throw new System.NotImplementedException();
		}
		internal Object InternalInvoke (Object obj, Object[] parameters, out Exception exc)
		{
			throw new System.NotImplementedException();
		}
		internal static DllImportAttribute GetDllImportAttribute (IntPtr mhandle)
		{
			throw new System.NotImplementedException();
		}
		MethodInfo MakeGenericMethod_impl (Type [] types)
		{
			throw new System.NotImplementedException();
		}
		public override Type [] GetGenericArguments ()
		{
			throw new System.NotImplementedException();
		}
		MethodInfo GetGenericMethodDefinition_impl ()
		{
			throw new System.NotImplementedException();
		}
		public override bool IsGenericMethodDefinition {
			get
			{
				throw new System.NotImplementedException();
			}
		}
		public override bool IsGenericMethod {
			get
			{
				throw new System.NotImplementedException();
			}
		}

	}
	 partial class MonoCMethod
	{
		internal Object InternalInvoke (Object obj, Object[] parameters, out Exception exc)
		{
			throw new System.NotImplementedException();
		}

	}
}
