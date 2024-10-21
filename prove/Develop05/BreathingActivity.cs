using System;
using System.Collections.Generic;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 50)
    {
    }

    public override void Run()
    {

        DisplayStartingMessage();
        int _duration = int.Parse(Console.ReadLine());

        for (int i = 3; i > _duration; i--)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(3);
            Thread.Sleep(1000);
            Console.WriteLine("Breathe out...");
            ShowCountdown(3);
        }
        DisplayEndingMessage();
    }
}