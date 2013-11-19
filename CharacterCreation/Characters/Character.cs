using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    public class Character
    {
        public string Id { get; set; }
        public string CharacterId { get; set; }
        
        public Class Class { get; set; }
        public Race Race { get; set; }

        public string Name { get; set; }
        public int Stamina { get; set; }
        public int Defence { get; set; }
        public int Hit { get; set; }
        public int Crit { get; set; }

        public List<Item> Inventory { get; set; }
    }
}
