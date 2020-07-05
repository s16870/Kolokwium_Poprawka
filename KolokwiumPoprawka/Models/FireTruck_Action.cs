using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KolokwiumPoprawka.Models
{
    public class FireTruck_Action
    {
        [Key]
        public int IdFireTruckAction { get; set; }
        [ForeignKey("FireTruck")]
        public int IdFireTruck { get; set; }
        [ForeignKey("Action")]
        public int IdAction { get; set; }
        public DateTime AssigmentDate { get; set; }
        public FireTruck FireTruck { get; set; }
        public Action Action { get; set; }
    }
}
