using System.Collections.Generic;
using Timers;

public static class TimerManager
{
    private static readonly List<Timer> _timers = new();

    public static void RegisterTimer(Timer timer) => _timers.Add(timer);
    public static void DeregisterTimer(Timer timer) => _timers.Remove(timer);

    public static void UpdateTimers()
    {
        foreach (var timer in new List<Timer>(_timers))
        {
            timer.Tick();
        }
    }

    public static void Clear() => _timers.Clear();
}