using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarisExMachinaClassLibrary
{
    public class MechBuilder // Class used whenever an instance of mech is being created
    {
        Mech _mechUnderConstruction;

        public MechBuilder()
        {
            _mechUnderConstruction = new Mech();
        }

        public MechBuilder NameMech(string name)
        {
            _mechUnderConstruction.Name = name;
            return this;
        }

        public MechBuilder SetWeapon(Weapon weapon)
        {
            _mechUnderConstruction.Weapon = weapon;
            return this;
        }

        public MechBuilder SetMovement(Movement movement)
        {
            _mechUnderConstruction.Movement = movement;
            return this;
        }

        public MechBuilder SetArmour(Armour armour)
        {
            _mechUnderConstruction.Armour = armour;
            return this;
        }

        public MechBuilder SetCore(Core core)
        {
            _mechUnderConstruction.Core = core;
            return this;
        }

        public MechBuilder SetWeaponLevel(int weaponLevel)
        {
            _mechUnderConstruction.WeaponLevel = weaponLevel;
            return this;
        }

        public MechBuilder SetMovementLevel(int movementLevel)
        {
            _mechUnderConstruction.MovementLevel = movementLevel;
            return this;
        }

        public MechBuilder SetArmourLevel(int armourLevel)
        {
            _mechUnderConstruction.ArmourLevel = armourLevel;
            return this;
        }



    }
}
