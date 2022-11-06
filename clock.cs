using System;
public static class Clock
{
    public static int Past(int h, int m, int s)
    {
        int time = (h * 60 * 60 * 1000) + (m * 60 * 1000) + (s * 1000);
        return time;
    }
}