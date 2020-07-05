using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KolokwiumPoprawka.DTO.Request;
using KolokwiumPoprawka.DTO.Response;
using KolokwiumPoprawka.Models;
using Microsoft.EntityFrameworkCore;

namespace KolokwiumPoprawka.Services
{
    public class FireFightersService : IFireFightersService
    {
        private readonly FireFightersDBContext _context;

        public FireFightersService(FireFightersDBContext context)
        {
            _context = context;
        }

        public AssignTruckResponse AssignTruck(AssignTruckRequest req)
        {
            var action = _context.Actions.Where(a => a.IdAction.Equals(req.idAction)).FirstOrDefault();
            if(action == null)
            {
                throw new Exception("Action not found!");
            }
            var truck = _context.FireTrucks.Where(ft => ft.IdFireTruck.Equals(req.idFireTruck)).FirstOrDefault();
            if(truck == null)
            {
                throw new Exception("Fire Truck not found!");
            }
            if(action.NeedSpecialEquipment == true && truck.SpecialEquipment == false)
            {
                throw new Exception("Fire Truck needs special equipment");
            }
            var fireTruckAction = new FireTruck_Action
            {
                IdAction = action.IdAction,
                IdFireTruck = truck.IdFireTruck,
                AssigmentDate = DateTime.Now
            };
            _context.Add(fireTruckAction);
            _context.SaveChanges();
            return new AssignTruckResponse
            {
                AssigmentDate = fireTruckAction.AssigmentDate,
                Action = action,
                FireTruck = truck
            };
        }

        public GetFireFighterActionsResponse GetFireFighterActions(int id)
        {
            var firefighter = _context.Firefighters.Where(f => f.IdFirefighter.Equals(id)).Include(f => f.Firefighter_Actions).ThenInclude(fa => fa.Action).FirstOrDefault();

            if(firefighter == null)
            {
                throw new Exception("Firefighter not found!");
            }
            return new GetFireFighterActionsResponse
            {
                Actions = firefighter.Firefighter_Actions.Select(fa => new GetActionsResponse
                {
                    IdAction = fa.Action.IdAction,
                    StartTime = fa.Action.StartTime,
                    EndTime = fa.Action.EndTime
                }).ToList()
            };
        }
    }
}
