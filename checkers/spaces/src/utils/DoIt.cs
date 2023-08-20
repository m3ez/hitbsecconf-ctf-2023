﻿using System;
using System.Threading.Tasks;

namespace checker.utils;

internal static class DoIt
{
	public static T TryOrDefault<T>(Func<T> func)
	{
		try { return func(); } catch { return default; }
	}

	public static async Task<T> TryOrDefaultAsync<T>(Func<Task<T>> func)
	{
		try { return await func(); } catch { return default; }
	}
}
