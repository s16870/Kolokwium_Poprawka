using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolokwiumPoprawka.DTO.Request
{
    public class AssignTruckRequest
    {
        public int idAction { get; set; }
        public int idFireTruck { get; set; }
    }
}
