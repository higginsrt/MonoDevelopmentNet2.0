//
// Mono.Posix.Catalog.cs: Wrappers for the libintl library.
//
// Author:
//   Edd Dumbill (edd@usefulinc.com)
//
// (C) 2004 Edd Dumbill
//
// This file implements the low-level syscall interface to the POSIX
// subsystem.
//
// This file tries to stay close to the low-level API as much as possible
// using enumerations, structures and in a few cases, using existing .NET
// data types.
//
// Implementation notes:
//
//    Since the values for the various constants on the API changes
//    from system to system (even Linux on different architectures will
//    have different values), we define our own set of values, and we
//    use a set of C helper routines to map from the constants we define
//    to the values of the native OS.
//
//    Bitfields are flagged with the [Map] attribute, and a helper program
//    generates a set of map_XXXX routines that we can call to convert
//    from our value definitions to the value definitions expected by the
//    OS.
//
//    Methods that require tuning are bound as `internal syscal_NAME' methods
//    and then a `NAME' method is exposed.
//

using System;
using System.Runtime.InteropServices;

namespace Mono.Posix
{
	public partial class Catalog
	{
		[DllImport("intl")]
		static extern IntPtr bindtextdomain (IntPtr domainname, IntPtr dirname);
		[DllImport("intl")]
		static extern IntPtr bind_textdomain_codeset (IntPtr domainname,
		IntPtr codeset);
		[DllImport("intl")]
		static extern IntPtr textdomain (IntPtr domainname);
		
		[DllImport("intl")]
		static extern IntPtr gettext (IntPtr instring);
		
		[DllImport("intl")]
		static extern IntPtr ngettext (IntPtr singular, IntPtr plural, Int32 n);

	}
}
