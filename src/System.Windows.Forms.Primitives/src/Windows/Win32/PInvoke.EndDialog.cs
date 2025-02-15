﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Windows.Win32
{
    internal static partial class PInvoke
    {
        public static BOOL EndDialog<T>(T hDlg, IntPtr nResult)
            where T : IHandle<HWND>
        {
            BOOL result = EndDialog(hDlg.Handle, nResult);
            GC.KeepAlive(hDlg.Wrapper);
            return result;
        }
    }
}
