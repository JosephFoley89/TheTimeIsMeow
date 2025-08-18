using TheTimeIsMeow;
using System.Timers;
using System.Threading;
using System;

internal class Program {
    public static System.Timers.Timer timer;
    public static Time time = new Time();

    private static void Main(string[] args) {
        Console.CursorVisible = false;
        SetTimer();
        Console.Read();
    }

    private static void SetTimer() {
        timer = new System.Timers.Timer(1000);
        timer.Elapsed += OnTimedEvent;
        timer.AutoReset = true;
        timer.Enabled = true;
    }

    private static void OnTimedEvent(object source, ElapsedEventArgs e) {
        Console.SetCursorPosition(0, 0);
        Console.Clear();
        DateTime dateTime = DateTime.Now;
        time.DisplayTime(new List<int>() { dateTime.Hour, 60, dateTime.Minute, 60, dateTime.Second });

        Console.Title = DateTime.Now.ToString("HH:mm:ss");
    }
}