using ConsoleApp7;
using ConsoleApp7.Bank;
using ConsoleApp7.Gui;


namespace ConsoleApp7
{

    
    class Program
    {
        static void Main(string[] args)
        {
            /*Account account = new Account(1000);
            Logger logger = new Logger(Path.Combine(Environment.CurrentDirectory, "balance_log.txt"), account);
            account.BalanceChanged -= logger.LogBalanceChange;
            account.BalanceChanged += Account.ShowMessage;
            account.BalanceChanged += Account.ShowBalance;
            account.Deposit(200);
            account.Withdraw(100);
            account.AddInterest(1.5m);
            account.TransferFunds(new Account(500), 100);
            */
            
            Button button = new Button("Click me");

            button.Subscribe(ConsoleOutputHandler);
            button.Subscribe(ColorChangeHandler);

            button.ClickButton();

            button.Unsubscribe(ConsoleOutputHandler);

            button.ClickButton();

        }
        static void ConsoleOutputHandler(object sender, EventArgs e)
        {
            Console.WriteLine($"Button clicked. Text: {((Button)sender).Text}");
        }

        static void ColorChangeHandler(object sender, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Button clicked. Text: {((Button)sender).Text}");
            Console.ResetColor();
        }
        /*Timer timer = new Timer();
          Clock clock = new Clock(timer);
          Counter counter = new Counter(timer);

          Console.WriteLine("Press Enter to exit.");
          Console.ReadLine();*/
    }
}
