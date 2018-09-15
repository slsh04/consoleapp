﻿using System;
using System.Timers;

public class Example
{
    private static Timer aTimer;

    public static void Main()
    {
        SetTimer();

        Console.WriteLine("\nPress the Enter key to exit the application...\n");
        Console.WriteLine("The application started at {0:HH:mm:ss.fff}", DateTime.Now);
        Console.ReadLine();
        aTimer.Stop();
        aTimer.Dispose();

        Console.WriteLine("Terminating the application...");
    }

    private static void SetTimer()
    {
        // Create a timer with a two second interval.
        aTimer = new Timer(2000);
        // Hook up the Elapsed event for the timer. 
        aTimer.Elapsed += OnTimedEvent;
        aTimer.AutoReset = true;
        aTimer.Enabled = true;
    }

    private static void OnTimedEvent(Object source, ElapsedEventArgs e)
    {
        //  Console.WriteLine("сейчас {0:HH:mm:ss}", e.SignalTime);
        Console.WriteLine($"{e.SignalTime.Hour}:{e.SignalTime.Minute}:{e.SignalTime.Second}");
    }
}