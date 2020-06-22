using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace HalloJan
{
    class Program
    {


        private static Logger logger = LogManager.GetCurrentClassLogger();


        static void Main(string[] args)
        {

            logger.Info("Hallo Jan Program Gestartet!");


            // Klasse 16 Jetzt bist du dran
            Console.WriteLine("----Kleinprogramm Hallo Jan----\n");


            Console.Write("Wie heiße ich nochmal?:");
            String name; 
            name = Console.ReadLine();
            Console.WriteLine("\n Hallo Jan, ich bin {0}!\n", name);

            Console.WriteLine("Drücken Sie eine Taste zum beenden\n\n");


            ////FEHLER PROVOZIEREN - Klasse 18 (+17)
            /// Aus der Fehlerliste kann man die Beschreibungen vom Fehler finden, auch links zu Info darüber und sonst kann man 
            /// die rechte maus benutzen und das ganze kopieren und Jan kommentieren.
            //Console.WriteLine(hier ist etwas nicht richtig);
            //Console.WriteLine("hier ist etwas nicht richtig");

            //Console.WriteLine("hier "+ "ist "+ "etwas "+ "nicht "+ "richtig.");
            ////
            ///
            logger.Info("Jan wurde erfolgreich salutiert.");
            Console.ReadKey();

            logger.Info("Hallo Jan Program beendet");
        }
    }
}
