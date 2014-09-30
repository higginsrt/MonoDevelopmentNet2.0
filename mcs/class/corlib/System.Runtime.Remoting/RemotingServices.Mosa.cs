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
using System.Text;
using System.Reflection;
using System.Threading;
using System.Collections;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Remoting.Services;
using System.Security.Permissions;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Serialization.Formatters;

namespace System.Runtime.Remoting
{
	public partial class RemotingServices
	{
		internal static object InternalExecute (MethodBase method, Object obj,
		Object[] parameters, out object [] out_args)
		{
			throw new System.NotImplementedException();
		}
		internal static MethodBase GetVirtualMethod (Type type, MethodBase method)
		{
			throw new System.NotImplementedException();
		}
		public static bool IsTransparentProxy (object proxy)
		{
			throw new System.NotImplementedException();
		}

	}
}
