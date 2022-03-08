using System;

namespace CovidLogger
{
    public class LoggerService
    {
        string _from;
        ICovidlogger _covidlogger;
        public LoggerService(string from, ICovidlogger Covidlogger)
        {
            _from = from;
            _covidlogger = Covidlogger;
        }

        public void LogInfo()
        {
            Console.WriteLine($"Sei in {_from}");
            _covidlogger.Info();
        }
    }
}
