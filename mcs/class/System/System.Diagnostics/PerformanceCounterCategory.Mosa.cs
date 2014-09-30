/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

using System.Security.Permissions;
using System.Runtime.CompilerServices;

namespace System.Diagnostics
{
	public partial class PerformanceCounterCategory
	{
		static bool CategoryDelete (string name)
		{
			throw new System.NotImplementedException();
		}
		static string CategoryHelpInternal (string category, string machine)
		{
			throw new System.NotImplementedException();
		}
		static bool CounterCategoryExists (string counter, string category, string machine)
		{
			throw new System.NotImplementedException();
		}
		static bool Create (string categoryName, string categoryHelp,
		PerformanceCounterCategoryType categoryType, CounterCreationData[] items)
		{
			throw new System.NotImplementedException();
		}
		static int InstanceExistsInternal (string instance, string category, string machine)
		{
			throw new System.NotImplementedException();
		}
		static string[] GetCategoryNames (string machine)
		{
			throw new System.NotImplementedException();
		}
		static string[] GetCounterNames (string category, string machine)
		{
			throw new System.NotImplementedException();
		}
		static string[] GetInstanceNames (string category, string machine)
		{
			throw new System.NotImplementedException();
		}

	}
}
