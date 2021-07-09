using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova2
{
    class Task
    {
        public enum Priority
        {
            Alta,
            Media,
            Bassa
        }
        public class Task
        {
            public Task() { }

            private string descrizione;
            {
            string descrizione = new string();
        }
            private DateTime dataScadenza;
       
        
            private Priority priorita;


            public string Descrizione { get => descrizione; set => descrizione = value; }
            public DateTime DataScadenza { get => dataScadenza; set => dataScadenza = value; }
            public Priority priorita { get => priorita; set => priorita = value; }

    }
}
