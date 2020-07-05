using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KolokwiumPoprawka.Models
{
    public class FireTruck
    {
        [Key]
        public int IdFireTruck { get; set; }
        [MaxLength(10)]
        public String OperationalNumber { get; set; }
        public Boolean SpecialEquipment { get; set; }
        public ICollection<FireTruck_Action> FireTruck_Actions { get; set; }
    }
}
