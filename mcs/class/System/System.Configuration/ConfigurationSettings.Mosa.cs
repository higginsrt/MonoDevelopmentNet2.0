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
using System.Collections;
using System.Collections.Specialized;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
#if (XML_DEP)
using System.Xml;
using System.Xml.XPath;
#endif

namespace System.Configuration
{
	 partial class DefaultConfig
	{
		private static string get_bundled_machine_config ()
		{
			throw new System.NotImplementedException();
		}
		private static string get_machine_config_path ()
		{
			throw new System.NotImplementedException();
		}

	}
}
