using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_Andrzejkowicz_v1
{
    class ProgressReport
    {
        public int PercentComplete { get; set; }
        public string ConsoleOutput { get; set; }
        public Boolean sprawdzArpa = false;
        public List<string> PublicznaLista = new List<string>();
    }
}
