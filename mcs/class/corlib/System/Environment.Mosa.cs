/*
 * (c) 2010 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 *
 */

using System.IO;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Runtime.InteropServices;

namespace System
{
	public static partial class Environment
	{

		/// <summary>
		/// Gets or sets the exit code of this process
		/// </summary>
		public static int ExitCode
		{
			get { throw new System.NotImplementedException(); }
			set { throw new System.NotImplementedException(); }
		}

		static public bool HasShutdownStarted
		{
			get { throw new System.NotImplementedException(); }
		}

		/// <summary>
		/// Gets the name of the local computer
		/// </summary>
		public static string MachineName
		{
			get { throw new System.NotImplementedException(); }
		}

		/// <summary>
		/// Gets the standard new line value
		/// </summary>
		public static string NewLine
		{
			get { throw new System.NotImplementedException(); }
		}

		internal static PlatformID Platform
		{
			get { throw new System.NotImplementedException(); }
		}

		internal static string GetOSVersionString()
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// Get the number of milliseconds that have elapsed since the system was booted
		/// </summary>
		public static int TickCount
		{
			get { throw new System.NotImplementedException(); }
		}

		public static string UserName
		{
			get { throw new System.NotImplementedException(); }
		}

		public static void Exit(int exitCode)
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// Return an array of the command line arguments of the current process
		/// </summary>
		public static string[] GetCommandLineArgs()
		{
			throw new System.NotImplementedException();
		}

		internal static string internalGetEnvironmentVariable(string variable)
		{
			throw new System.NotImplementedException();
		}

		private static string GetWindowsFolderPath(int folder)
		{
			throw new System.NotImplementedException();
		}

#if !NET_2_1

		private static void internalBroadcastSettingChange()
		{
			throw new System.NotImplementedException();
		}
		internal static void InternalSetEnvironmentVariable(string variable, string value)
		{
			throw new System.NotImplementedException();
		}

#endif

		public static int ProcessorCount
		{
			get { throw new System.NotImplementedException(); }
		}

#if !NET_2_1
		internal static string internalGetGacPath()
		{
			throw new System.NotImplementedException();
		}
#endif
		private static string[] GetLogicalDrivesInternal()
		{
			throw new System.NotImplementedException();
		}

		private static string[] GetEnvironmentVariableNames()
		{
			throw new System.NotImplementedException();
		}

		internal static string GetMachineConfigPath()
		{
			throw new System.NotImplementedException();
		}

		internal static string internalGetHome()
		{
			throw new System.NotImplementedException();
		}

		internal static int GetPageSize()
		{
			throw new System.NotImplementedException();
		}

	}
}
