//
// System.Configuration.ConfigurationSettings.cs
//
// Author:
//   Christopher Podurgiel (cpodurgiel@msn.com)
//   Gonzalo Paniagua Javier (gonzalo@ximian.com)
//   Eric Lindvall (eric@5stops.com)
//
// (c) Christopher Podurgiel
// (c) 2002 Ximian, Inc. (http://www.ximian.com)
// (c) 2003 Novell, Inc. (http://www.novell.com)
//

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

using NameValueCollection = PrebuiltSystem.System.Collections.Specialized.NameValueCollection;
#endif

using System;
using System.Collections;
using System.Collections.Specialized;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
#if (XML_DEP)
using System.Xml;
using System.Xml.XPath;
#endif
#if TARGET_JVM
using vmw.common;
using vmw.@internal.io;
#endif

namespace System.Configuration
{
	 partial class DefaultConfig
	{
#else
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern private static string get_bundled_machine_config ();
		[MethodImplAttribute(MethodImplOptions.InternalCall)]
		extern private static string get_machine_config_path ();

	}
}
