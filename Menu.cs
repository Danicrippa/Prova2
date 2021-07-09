using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova2
{
    class Menu
    {
        public static void Star()
            {
            Console.WriteLine("Tasks");

            bool vuoiContinuare = true;

            do
            {
                Console.WriteLine();
                Console.WriteLine("premi 1 per inserireTask");
                Console.WriteLine("premi 2 per visualizzareTask");
                Console.WriteLine("premi 3 per aggiungereTask");
                Console.WriteLine("premi 4 per eliminareTask");
                Console.WriteLine("premi 5 per filtraretask");

                Console.WriteLine("premi 0 per uscire");

                bool isInt = true;
                int scelta = 0;

                do
                {
                    isInt = int.TryParse(Console.ReadLine(), out scelta);
                } while (!isInt);

                switch (scelta)
                {
                    case 1:
                        TasksManager.InserireTask();
                        break;
                    case 2:
                        TasksManager.VisualizzareTask();
                        break;
                    case 3:
                        TasksManager.AggiungereTask();
                        break;
                    case 4:
                        TasksManager.EliminareTask();
                        break;
                    case 5:
                        TasksManager.FiltrareTask();
                        break;
                    case 0:
                        vuoiContinuare = false;
                        TasksManager.SalvaSuFile();
                        break;
                    default:
                        Console.WriteLine("hai finito.");
                        break;
                }
                }while (vuoiContinuare);

        }
    }
}
