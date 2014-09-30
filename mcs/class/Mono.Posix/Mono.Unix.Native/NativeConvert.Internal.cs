
using System;
using System.IO;
using System.Runtime.InteropServices;
using Mono.Unix.Native;

namespace Mono.Unix.Native
{
	public partial class NativeConvert
	{
		
		[DllImport (LIB, EntryPoint="Mono_Posix_FromRealTimeSignum")]
		private static extern int FromRealTimeSignum (Int32 offset, out Int32 rval);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_FromStatvfs")]
		private static extern int FromStatvfs (ref Statvfs source, IntPtr destination);
		
		[DllImport (LIB, EntryPoint="Mono_Posix_ToStatvfs")]
		private static extern int ToStatvfs (IntPtr source, out Statvfs destination);

	}
}
