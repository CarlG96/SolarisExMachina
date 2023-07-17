using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SolarisExMachinaClassLibrary
{
    public class Engine
    {
        private Intro _intro = new Intro();
        MechChoiceHandler _mechChoiceHandler = new MechChoiceHandler();
        MapBuilder _mapBuilder; // TODO
        MovementHandler _movementHandler; // TODO
        LocationHandler _locationHandler; // TODO
        BattleHandler _battleHandler; // TODO
        GarageHandler _garageHandler; // TODO

        public Engine()
        {

        }

        public void Run()
        {
            _intro.Play();
        }

        // Intro - Opening
        // Intro - ChooseMech
        // CreateMap
        // while(!dead)
        // Ask for movement
        // Make Movement
        // Check for random battle/ garage
        // if(randomBattle)
        // Fight Random Battle
        // Add Cores from Random Battle
        // if(garage)
        // ask for want to visit
        // if(wanttovisit)
        // display options
        // if(wantoptions)
        // remove money
        // complete

    }
}
