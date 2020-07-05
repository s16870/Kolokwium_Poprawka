using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KolokwiumPoprawka.DTO.Response;
using KolokwiumPoprawka.DTO.Request;

namespace KolokwiumPoprawka.Services
{
    public interface IFireFightersService
    {
        GetFireFighterActionsResponse GetFireFighterActions(int id);
        AssignTruckResponse AssignTruck(AssignTruckRequest req);
    }
}
