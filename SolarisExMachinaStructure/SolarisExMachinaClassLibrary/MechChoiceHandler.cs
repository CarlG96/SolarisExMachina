namespace SolarisExMachinaClassLibrary
{
    public class MechChoiceHandler
    {

        public Tribe GetTribe()
        {
            string input = Console.ReadLine().Trim(); //IMPURE
            switch (input) 
            {
                case "1":
                    return Tribe.Fire;        
                case "2":
                    return Tribe.Water;
                case "3":
                    return Tribe.Earth;
                case "4":
                    return Tribe.Air;
                case "5":
                    return Tribe.Metal;
                case "6":
                    return Tribe.Crystal;
                case "7":
                    return Tribe.Wood;
                case "8":
                    return Tribe.Mud;
                case "9":
                    return Tribe.Sound;
                case "10":
                    return Tribe.Ice;
                case "11":
                    return Tribe.Smog;
                case "12":
                    return Tribe.Lightning;
                case "13":
                    return Tribe.Steam;
                case "14":
                    return Tribe.Dust;
                case "15":
                    return Tribe.Shadow;
                case "16":
                    return Tribe.Radiance;
                default:
                    //TODO Error handle this
                    return Tribe.Fire;
            }
        }

        private void GiveTribeInfo()
        {
            string input = Console.ReadLine().Trim(); //IMPURE
            switch (input)
            {
                case "1":
                    // Give info on Fire tribe
                    break;
                case "2":
                    // Give info on Water tribe
                    break;
                case "3":
                    // Give info on Earth tribe
                    break;
                case "4":
                    // Give info on Air tribe
                    break;
                case "5":
                    // Give info on Metal tribe
                    break;
                case "6":
                    // Give info on Crystal tribe
                    break;
                case "7":
                    // Give info on Wood tribe
                    break;
                case "8":
                    // Give info on Mud tribe
                    break;
                case "9":
                    // Give info on Sound tribe
                    break;
                case "10":
                    // Give info on Ice tribe
                    break;
                case "11":
                    // Give info on Smog tribe
                    break;
                case "12":
                    // Give info on Lightning tribe
                    break;
                case "13":
                    // Give info on Steam tribe
                    break;
                case "14":
                    // Give info on Dust tribe
                    break;
                case "15":
                    // Give info on Shadow tribe
                    break;
                case "16":
                    // Give info on Radiance tribe
                    break;
                default:
                    //TODO Error handle this
                    break;

            }
        }

        public WeaponType GetWeaponType()
        {
            string input = Console.ReadLine().Trim(); // IMPURE
            switch (input)
            {
                case "1":
                    return WeaponType.Gun;
                case "2":
                    return WeaponType.Missile;
                case "3":
                    return WeaponType.Laser;
                case "4":
                    return WeaponType.Plasma;
                case "5":
                    return WeaponType.Blunt;
                case "6":
                    return WeaponType.Sharp;
                case "7":
                    return WeaponType.Unarmed;
                case "8":
                    return WeaponType.Electro;
                case "9":
                    return WeaponType.Flame;
                default:
                    //TODO Error handle this
                    return WeaponType.Gun;
            }
        }

        private void GetWeaponTypeInfo()
        {
            string input = Console.ReadLine().Trim(); // IMPURE
            switch (input)
            {
                case "1":
                    // Give info on Gun
                    break;
                case "2":
                    // Give info on Missile
                    break;
                case "3":
                    // Give info on Laser
                    break;
                case "4":
                    // Give info on Plasma
                    break;
                case "5":
                    // Give info on Blunt
                    break;
                case "6":
                    // Give info on Sharp
                    break;
                case "7":
                    // Give info on Unarmed
                    break;
                case "8":
                    // Give info on Electro
                    break;
                case "9":
                    // Give info on Flame
                    break;
                default:
                    // TODO error handle this
                    break;
            }
        }

        public MovementType GetMovementType()
        {
            string input = Console.ReadLine().Trim(); // IMPURE
            switch (input)
            {
                case "1":
                    return MovementType.Treads;
                case "2":
                    return MovementType.Legs;
                case "3":
                    return MovementType.Spider;
                case "4":
                    return MovementType.Hover;
                case "5":
                    return MovementType.Roll;
                case "6":
                    return MovementType.Wheels;
                default:
                    //TODO Error handle this
                    return MovementType.Treads;
            }
        }

        public ArmourType GetArmourType()
        {
            string input = Console.ReadLine().Trim(); //IMPURE
            switch (input)
            {
                case "1":
                    return ArmourType.Light;
                case "2":
                    return ArmourType.Medium;
                case "3":
                    return ArmourType.Heavy;
                default:
                    return ArmourType.Light;
            }
        }

        public CoreType GetCoreType()
        {
            string input = Console.ReadLine().Trim(); // IMPURE
            switch (input)
            {
                case "1":
                    return CoreType.Robust;
                case "2":
                    return CoreType.Volatile;
                case "3":
                    return CoreType.Overclock;
                default:
                    return CoreType.Robust;
            }
        }
    }
}