namespace SolarisExMachinaClassLibrary
{
    public class Mech
    {
        public string Name { get; set; }
        public Weapon Weapon { get; set; }
        public int WeaponLevel { get; set; }
        public Movement Movement { get; set; }
        public int MovementLevel { get; set; }
        public Armour Armour { get; set; }
        public int ArmourLevel { get; set; }
        public Core Core { get; set; }

        public Mech()
        {   
            WeaponLevel = 1;
            MovementLevel = 1;
            ArmourLevel = 1;
        }
    }


}