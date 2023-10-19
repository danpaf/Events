using ConsoleApp7.Bank;

namespace ConsoleApp7;

public class Logger
{
    public string LogFile { get; }
    public Account Account { get; }

    public Logger(string logFile, Account account)
    {
        LogFile = logFile;
        Account = account;
        Account.BalanceChanged += LogBalanceChange;
    }

    public void LogBalanceChange(decimal balance)
    {
        using (System.IO.StreamWriter file =
               new System.IO.StreamWriter(LogFile, true))
        {
            file.WriteLine($"The balance is {balance}");
        }
    }
}