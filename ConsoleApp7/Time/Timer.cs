using System.Timers;

namespace ConsoleApp7;

class Timer
{
    public event EventHandler Tick;

    public Timer()
    {
        var timer = new System.Timers.Timer(1000);
        timer.Elapsed += OnTick;
        timer.AutoReset = true;
        timer.Enabled = true;
    }

    private void OnTick(object sender, ElapsedEventArgs e)
    {
        Tick?.Invoke(this, EventArgs.Empty);
    }
}