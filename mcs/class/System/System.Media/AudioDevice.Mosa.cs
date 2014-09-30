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
	 partial class AlsaDevice
	{
		static int snd_pcm_open (ref IntPtr handle, string pcm_name, int stream, int mode)
		{
			throw new System.NotImplementedException();
		}
		static int snd_pcm_close (IntPtr handle)
		{
			throw new System.NotImplementedException();
		}
		static int snd_pcm_drain (IntPtr handle)
		{
			throw new System.NotImplementedException();
		}
		static int snd_pcm_writei (IntPtr handle, byte[] buf, int size)
		{
			throw new System.NotImplementedException();
		}
		static int snd_pcm_set_params (IntPtr handle, int format, int access, int channels, int rate, int soft_resample, int latency)
		{
			throw new System.NotImplementedException();
		}

	}
}
#endif