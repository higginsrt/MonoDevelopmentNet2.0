
#if NET_2_0
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Mono.Audio
{
	 partial class AlsaDevice
	{
		
		[DllImport ("libasound.so.2")]
		static extern int snd_pcm_open (ref IntPtr handle, string pcm_name, int stream, int mode);
		
		[DllImport ("libasound.so.2")]
		static extern int snd_pcm_close (IntPtr handle);
		
		[DllImport ("libasound.so.2")]
		static extern int snd_pcm_drain (IntPtr handle);
		
		[DllImport ("libasound.so.2")]
		static extern int snd_pcm_writei (IntPtr handle, byte[] buf, int size);
		
		[DllImport ("libasound.so.2")]
		static extern int snd_pcm_set_params (IntPtr handle, int format, int access, int channels, int rate, int soft_resample, int latency);

	}
}
