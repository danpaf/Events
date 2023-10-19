namespace ConsoleApp7;


class Counter
{
    private int count = 0;

    public Counter(Timer timer)
    {
        timer.Tick += OnTick;
    }

    private void OnTick(object sender, EventArgs e)
    {
        count++;
        Console.WriteLine($"Counter value: {count}");
    }
}