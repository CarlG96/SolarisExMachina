using SolarisExMachinaClassLibrary;

namespace SolarisExMachinaTests
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldReturnMegaTank()
        {
            // Arrange
            Mech mech;

            // Act 
            mech = new Mech('a');

            // Assert
            Assert.True(mech.Name == "MegaTank");
            Assert.True(mech.Weapon == Weapon.Gun);
            Assert.True(mech.WeaponLevel == 1);
            Assert.True(mech.Movement == Movement.Treads);
            Assert.True(mech.MovementLevel == 1);
            Assert.True(mech.Armour == Armour.Heavy);
            Assert.True(mech.ArmourLevel == 1);
            Assert.True(mech.Core == Core.Robust);
        }

        [Fact]
        public void ShouldReturnSamurai()
        {
            // Arrange
            Mech mech;

            // Act 
            mech = new Mech('b');

            // Assert
            Assert.True(mech.Name == "Samurai");
            Assert.True(mech.Weapon == Weapon.Sharp);
            Assert.True(mech.WeaponLevel == 1);
            Assert.True(mech.Movement == Movement.Legs);
            Assert.True(mech.MovementLevel == 1);
            Assert.True(mech.Armour == Armour.Medium);
            Assert.True(mech.ArmourLevel == 1);
            Assert.True(mech.Core == Core.Overclock);
        }

        [Fact]
        public void ShouldReturnPunishment()
        {
            // Arrange
            Mech mech;

            // Act 
            mech = new Mech('c');

            // Assert
            Assert.True(mech.Name == "Punishment");
            Assert.True(mech.Weapon == Weapon.Flame);
            Assert.True(mech.WeaponLevel == 1);
            Assert.True(mech.Movement == Movement.Spider);
            Assert.True(mech.MovementLevel == 1);
            Assert.True(mech.Armour == Armour.Medium);
            Assert.True(mech.ArmourLevel == 1);
            Assert.True(mech.Core == Core.Volatile);
        }

        [Fact]
        public void ShouldReturnX5000()
        {
            // Arrange
            Mech mech;

            // Act 
            mech = new Mech('d');

            // Assert
            Assert.True(mech.Name == "X5000");
            Assert.True(mech.Weapon == Weapon.Laser);
            Assert.True(mech.WeaponLevel == 1);
            Assert.True(mech.Movement == Movement.Hover);
            Assert.True(mech.MovementLevel == 1);
            Assert.True(mech.Armour == Armour.Light);
            Assert.True(mech.ArmourLevel == 1);
            Assert.True(mech.Core == Core.Robust);
        }

    }
}