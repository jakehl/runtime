// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// Generated by Fuzzlyn v1.5 on 2022-06-05 17:15:09
// Run on Arm64 MacOS
// Seed: 9776694006090703095
// Reduced from 187.4 KiB to 0.3 KiB in 00:00:51
// Debug: Outputs 255
// Release: Outputs 4294967295
using System;
using System.Runtime.CompilerServices;

public class Runtime_70333_2
{
    public static int Main()
    {
        uint vr6 = (uint)M50(255);
        if (vr6 == 255)
        {
            Console.WriteLine("PASS: Result was 255");
            return 100;
        }

        Console.WriteLine("FAIL: Result was {0}", vr6);
        return -1;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static long M50(byte arg0)
    {
        arg0 = 246;
        arg0 = (byte)(-1 % (arg0 | 1));
        return arg0;
    }
}
