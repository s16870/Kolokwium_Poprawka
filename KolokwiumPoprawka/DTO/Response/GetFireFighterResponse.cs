using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolokwiumPoprawka.DTO.Response
{
    public class GetFireFighterActionsResponse
    {
        public IEnumerable<GetActionsResponse> Actions { get; set; }
    }
}
