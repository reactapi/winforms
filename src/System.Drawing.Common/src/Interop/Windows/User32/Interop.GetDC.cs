// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class User32
    {
#if NET7_0_OR_GREATER
        [LibraryImport(Libraries.User32)]
        public static partial IntPtr GetDC(
#else
        [DllImport(Libraries.User32, ExactSpelling = true)]
        public static extern IntPtr GetDC(
#endif
            IntPtr hWnd);

        public static IntPtr GetDC(HandleRef hWnd)
        {
            IntPtr dc = GetDC(hWnd.Handle);
            GC.KeepAlive(hWnd.Wrapper);
            return dc;
        }
    }
}
