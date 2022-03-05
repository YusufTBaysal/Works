using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasıtKredimMnager = new TasitKrediManager();
            IKrediManager konutKredimMnager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>() { smsLoggerService, fileLoggerService };

            BasvuruManager basvurumanager = new BasvuruManager();
            basvurumanager.BasvuruYap(esnafKrediManager, loggers);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasıtKredimMnager };
            //basvurumanager.KrediOnBilgilendirmesiYap(krediler);

            Console.ReadKey();
        }
    }
}
