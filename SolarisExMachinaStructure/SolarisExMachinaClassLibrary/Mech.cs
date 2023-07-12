namespace SolarisExMachinaClassLibrary
{
    public class Mech
    {
        private string _name;
        private Weapon _weapon;
        private int _weaponLevel;
        private Movement _movement;
        private int _movementLevel;
        private Armour _armour;
        private int _armourLevel;
        private Core _core;

        public Mech(char choice)
        {
            switch (choice) 
            {
                case 'a': 
                    _name = "MegaTank";
                    _weapon = Weapon.Gun;
                    _movement = Movement.Treads;
                    _armour = Armour.Heavy;
                    _core = Core.Robust;
                    break;
                case 'b':
                    _name = "Samurai";
                    _weapon = Weapon.Sharp;
                    _movement = Movement.Legs;
                    _armour = Armour.Medium;
                    _core = Core.Overclock;
                    break;
                case 'c':
                    _name = "Punishment";
                    _weapon = Weapon.Flame;
                    _movement = Movement.Spider;
                    _armour = Armour.Medium;
                    _core = Core.Volatile;
                    break;
                case 'd':
                    _name = "X5000";
                    _weapon = Weapon.Laser;
                    _movement = Movement.Hover;
                    _armour = Armour.Light;
                    _core = Core.Robust;
                    break;
                default: throw new Exception("Failed to input the correct character");
                    
            }
            _weaponLevel = 1;
            _movementLevel = 1;
            _armourLevel = 1;
        }
    }


}