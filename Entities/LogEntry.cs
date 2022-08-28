using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiden.Core.Entities
{
    public class LogEntry
    {
        public Exercise Exercise { get; set; }

        public int Sets { get; set; }

        public int Repitiions { get; set; }

        public LogEntry()
        {
        }

        public LogEntry(Exercise exercise, int sets, int repitiions)
        {
            Exercise = exercise;
            Sets = sets;
            Repitiions = repitiions;
        }
    }
}
