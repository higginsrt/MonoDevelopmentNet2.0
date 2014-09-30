/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

#if SECURITY_DEP
using System;
using System.Runtime.InteropServices;
using Mono.Security.X509;
using Mono.Security.X509.Extensions;

namespace Mono.Security.X509
{
	 partial class OSX509Certificates
	{
		static IntPtr SecCertificateCreateWithData (IntPtr allocator, IntPtr nsdataRef)
		{
			throw new System.NotImplementedException();
		}
		static int SecTrustCreateWithCertificates (IntPtr certOrCertArray, IntPtr policies, out IntPtr sectrustref)
		{
			throw new System.NotImplementedException();
		}
		static IntPtr SecPolicyCreateSSL (int server, IntPtr cfStringHostname)
		{
			throw new System.NotImplementedException();
		}
		static int SecTrustEvaluate (IntPtr secTrustRef, out SecTrustResult secTrustResultTime)
		{
			throw new System.NotImplementedException();
		}
		unsafe static IntPtr CFDataCreate (IntPtr allocator, byte *bytes, IntPtr length)
		{
			throw new System.NotImplementedException();
		}
		unsafe static void CFRelease (IntPtr handle)
		{
			throw new System.NotImplementedException();
		}
		static IntPtr CFArrayCreate (IntPtr allocator, IntPtr values, IntPtr numValues, IntPtr callbacks)
		{
			throw new System.NotImplementedException();
		}

	}
}

#endif