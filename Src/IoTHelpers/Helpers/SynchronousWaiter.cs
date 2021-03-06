﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTHelpers.Helpers
{
    internal static class SynchronousWaiter
    {
        public static void WaitMilliseconds(double milliseconds)
        {
            var stopwatch = Stopwatch.StartNew();
            var initialTick = stopwatch.ElapsedTicks;
            var initialElapsed = stopwatch.ElapsedMilliseconds;
            var desiredTicks = milliseconds / 1000.0 * Stopwatch.Frequency;
            var finalTick = initialTick + desiredTicks;

            while (stopwatch.ElapsedTicks < finalTick) ;
        }

        public static void WaitMicroseconds(double microseconds)
        {
            var stopwatch = Stopwatch.StartNew();
            var initialTick = stopwatch.ElapsedTicks;
            var initialElapsed = stopwatch.ElapsedMilliseconds;
            var desiredTicks = microseconds / 1e6 * Stopwatch.Frequency;
            var finalTick = initialTick + desiredTicks;

            while (stopwatch.ElapsedTicks < finalTick) ;
        }
    }
}
