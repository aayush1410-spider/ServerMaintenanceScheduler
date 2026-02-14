using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        List<(int start, int end)> requests = new List<(int, int)>
        {
            (900, 1030),
            (1000, 1100),
            (1030, 1130),
            (1100, 1200)
        };

        int result = GetCountForMaxMaintenanceTasks(requests);

        Console.WriteLine(result);
    }

    public static int GetCountForMaxMaintenanceTasks(List<(int start, int end)> durations)
    {
        if (durations == null || durations.Count == 0)
            return 0;

        durations.Sort((a, b) => a.end.CompareTo(b.end));

        int count = 0;
        int lastEndTime = -1;

        foreach (var duration in durations)
        {
            if (duration.start >= lastEndTime)
            {
                count++;
                lastEndTime = duration.end;
            }
        }

        return count;
    }
}
