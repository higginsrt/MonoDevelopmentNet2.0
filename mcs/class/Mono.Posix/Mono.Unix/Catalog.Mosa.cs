/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

using System;
using System.Runtime.InteropServices;

namespace Mono.Unix
{
	public partial class Catalog
	{
		static IntPtr bindtextdomain (IntPtr domainname, IntPtr dirname)
		{
			throw new System.NotImplementedException();
		}
		static IntPtr bind_textdomain_codeset (IntPtr domainname,
		IntPtr codeset)
		{
			throw new System.NotImplementedException();
		}
		static IntPtr textdomain (IntPtr domainname)
		{
			throw new System.NotImplementedException();
		}
		static IntPtr gettext (IntPtr instring)
		{
			throw new System.NotImplementedException();
		}
		static IntPtr ngettext (IntPtr singular, IntPtr plural, Int32 n)
		{
			throw new System.NotImplementedException();
		}

	}
}
