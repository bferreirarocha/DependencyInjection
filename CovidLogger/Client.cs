using System;

namespace CovidLogger
{
    internal class Client
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Bruno!");
            ICovidlogger logger;
            int contaggi = 0;

            for (int i = 0; i < 500; i++)
            {
                contaggi = i;
                Console.WriteLine(contaggi);
            }

            if (contaggi >= 400)
            {
                logger = new ReZone();
            }
            else
            {
                logger = new OrangeZone();
            }
            LoggerService loggersvc = new LoggerService("Veneto", logger);
            loggersvc.LogInfo();
            Console.ReadLine();
        }
    }



    public interface ICovidlogger
    {
        public void Info();
    }
    class ReZone : ICovidlogger
    {

        public void Info()
        {
            Console.WriteLine("Sei in zona Rossa");
            Console.WriteLine("Metti la mascherina anche all'aperto");
            Console.WriteLine("non uscire dal comune");
        }
    }
    class OrangeZone : ICovidlogger
    {
        public void Info()
        {
            Console.WriteLine("Sei in zona Arancione");
            Console.WriteLine("Metti la mascherina anche solo al chiuso");
            Console.WriteLine("puoi uscire  dall regione");
        }
    }


}
