using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KolokwiumPoprawka.Models;

namespace KolokwiumPoprawka.DTO.Response
{
    public class AssignTruckResponse
    {
        public DateTime AssigmentDate { get; set; }
        public KolokwiumPoprawka.Models.Action Action { get; set; }
        public FireTruck FireTruck { get; set; }
    }
}
