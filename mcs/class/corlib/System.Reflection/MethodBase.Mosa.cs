/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

using System.Diagnostics;
using System.Globalization;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Reflection
{
	public partial class MethodBase
	{
		public static MethodBase GetCurrentMethod ()
		{
			throw new System.NotImplementedException();
		}
		private static MethodBase GetMethodFromHandleInternalType (IntPtr method_handle, IntPtr type_handle)
		{
			throw new System.NotImplementedException();
		}
		internal static MethodBody GetMethodBodyInternal (IntPtr handle)
		{
			throw new System.NotImplementedException();
		}

	}
}
