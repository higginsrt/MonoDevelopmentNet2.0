/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

#if NET_2_0

using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Mono.Audio
{
	 partial class Win32SoundPlayer
	{
		static bool PlaySound (
		byte [] ptrToSound,
		UIntPtr hmod,
		SoundFlags flags)
		{
			throw new System.NotImplementedException();
		}

	}
}
#endif