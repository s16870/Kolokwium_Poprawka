using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KolokwiumPoprawka.Models
{
    public class Firefighter_Action
    {
        public int IdFirefighter { get; set; }
        public int IdAction { get; set; }

        public Firefighter Firefighter { get; set; }
        public Action Action { get; set; }
    }
}
