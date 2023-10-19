namespace ConsoleApp7;

class Clock
{
    public Clock(Timer timer)
    {
        timer.Tick += OnTick;
    }

    private void OnTick(object sender, EventArgs e)
    {
        Console.WriteLine($"Current time: {DateTime.Now.ToLongTimeString()}");
    }
}