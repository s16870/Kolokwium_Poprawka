using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KolokwiumPoprawka.Models
{
    public class Firefighter
    {
        [Key]
        public int IdFirefighter { get; set; }
        [MaxLength(30)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }

        public ICollection<Firefighter_Action> Firefighter_Actions { get; set; }
    }
}
