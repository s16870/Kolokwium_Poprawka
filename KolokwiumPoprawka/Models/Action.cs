using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KolokwiumPoprawka.Models
{
    public class Action
    {
        [Key]
        public int IdAction { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public Boolean NeedSpecialEquipment { get; set; }
        public ICollection<Firefighter_Action> Firefighter_Actions { get; set; }
        public ICollection<FireTruck_Action> FireTruck_Actions { get; set; }
    }
}
