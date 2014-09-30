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
using System.Globalization;
using System.Text;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

#if MSTEST
using System.Runtime.InteropServices;
#endif

namespace System
{
	public partial struct Decimal
	{
#if !MSTEST
		private static int decimal2UInt64 (ref Decimal val, out ulong result)
		{
			throw new System.NotImplementedException();
		}
		private static int decimal2Int64 (ref Decimal val, out long result)
		{
			throw new System.NotImplementedException();
		}
		private static int double2decimal (out Decimal erg, double val, int digits)
		{
			throw new System.NotImplementedException();
		}
		private static int decimalIncr (ref Decimal d1, ref Decimal d2)
		{
			throw new System.NotImplementedException();
		}
		internal static int decimal2string (ref Decimal val,
		int digits, int decimals, char[] bufDigits, int bufSize, out int decPos, out int sign)
		{
			throw new System.NotImplementedException();
		}
		internal static int string2decimal (out Decimal val, String sDigits, uint decPos, int sign)
		{
			throw new System.NotImplementedException();
		}
		internal static int decimalSetExponent (ref Decimal val, int exp)
		{
			throw new System.NotImplementedException();
		}
		private static double decimal2double (ref Decimal val)
		{
			throw new System.NotImplementedException();
		}
		private static void decimalFloorAndTrunc (ref Decimal val, int floorFlag)
		{
			throw new System.NotImplementedException();
		}
		private static int decimalMult (ref Decimal pd1, ref Decimal pd2)
		{
			throw new System.NotImplementedException();
		}
		private static int decimalDiv (out Decimal pc, ref Decimal pa, ref Decimal pb)
		{
			throw new System.NotImplementedException();
		}
		private static int decimalIntDiv (out Decimal pc, ref Decimal pa, ref Decimal pb)
		{
			throw new System.NotImplementedException();
		}
		private static int decimalCompare (ref Decimal d1, ref Decimal d2)
		{
			throw new System.NotImplementedException();
		}
#else
		internal static int decimal2string (ref Decimal val,
		int digits, int decimals,
		[MarshalAs(UnmanagedType.LPWStr)]StringBuilder bufDigits,
		int bufSize, out int decPos, out int sign)
		{
			throw new System.NotImplementedException();
		}
		private static void decimalRound (ref Decimal val, int decimals)
		{
			throw new System.NotImplementedException();
		}
#endif
	}
}
