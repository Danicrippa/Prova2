using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using static Tasks.Manager;

namespace Prova2
{
    public class TasksManager
    {
        private List<Task> task;
        static string path = @"C:\Users\jgera\OneDrive\Área de Trabalho\Prova2\Prova2\Prova2\TasksManager.txt"

        public List<Task> Task
        {

        }
        }
        public static void InserireTask()
        {
            Console.WriteLine("inserisci task:");
            string InserireTask = Console.ReadLine();

            DateTime dataInserita = DateTime.Parse("09/07/2021");

            Console.WriteLine("inserisci data", DateTime);
           
            Console.WriteLine("scegli il livello di priorita:" Priority);
            enum Priority= enum.TryParse.ConsoleReadLine(), out priorita);
           
            bool isDate = true;

        DateTime dataInserita = DateTime.Now;
        DateTime dataScadenza = dataInserita + 10;
            do
            {
                isDate = DateTime.TryParse(Console.ReadLine(), out dataInserita);

            } while (!isDate || dataInserita<DateTime.dataScadenza);
        }


public static void  VisualizzareTask()
{
    Console.WriteLine("scegli task da visualizzare");
    string  VisualizzareTask = Console.ReadLine();
}

private static void AggiungereTask()
{
    Console.WriteLine("aggiungere task");

    string AggiungereTask = Console.ReadLine();

    DateTime dataInserita;

    Console.WriteLine("inserisci data", dataInserita);

    DateTime dataInserita = DateTime.Parse("09/07/2021");

    Console.WriteLine("scegli il livello di priorita:" Priority);
            enum Priority= enum.TryParse.ConsoleReadLine(), out priorita);

bool isDate = true;

public static void EliminareTask()
{
    Console.WriteLine("Scegliere task da essere eliminato");
    EliminareTask();

    Task EliminareTask = ScegliTask;
}

public static FiltrareTask()
{
    Console.WriteLine("scegli task da filtrare per priorità");
    Task FiltrareTask = List<Task>;
    get
            {
        if (task == null)
            return new List<Task>();
        else return task;
    }
    set { task = value; }

}
public static ScegliTask()
{
    bool isInt = false;
    int Priority = 0;

    if
    {
        Priority = 0
        Console.WriteLine(ScegliTask);
    }
}

public static void SalvaSuFile()
{
    using (StreamWriter sw = new StreamWriter(path, true))
    {
        sw.WriteLine("Task");
        sw.WriteLine();
        foreach (Task conto in task)
        {
            sw.WriteLine($"Task: { task}, priorità: { Priority}, DateTime: {DateTime.DateTime.Now}");
        }
    }
}
