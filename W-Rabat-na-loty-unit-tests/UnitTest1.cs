using Rabat_Na_Loty;

namespace W_Rabat_na_loty_unit_tests;

[TestClass]
public class UnitTest1
{
     [TestMethod]
        public void TestCheckIsSeason_WinterSeason_Christmas() {
            DateTime flightDate = new DateTime(2024, 12, 25);
            bool result = Program.CheckIsSeason(flightDate);
            Assert.IsTrue(result);
        } 

        [TestMethod]
        public void TestCheckIsSeason_WinterSeason_NewYear() {
            DateTime flightDate = new DateTime(2025, 1, 5);
            bool result = Program.CheckIsSeason(flightDate);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestCheckIsSeason_SpringSeason_Start() {
            DateTime flightDate = new DateTime(2024, 3, 22);
            bool result = Program.CheckIsSeason(flightDate);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestCheckIsSeason_SpringSeason_End() {
            DateTime flightDate = new DateTime(2024, 4, 5);
            bool result = Program.CheckIsSeason(flightDate);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestCheckIsSeason_Summer_July() {
            DateTime flightDate = new DateTime(2024, 7, 15);
            bool result = Program.CheckIsSeason(flightDate);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestCheckIsSeason_Summer_August() {
            DateTime flightDate = new DateTime(2024, 8, 20);
            bool result = Program.CheckIsSeason(flightDate);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestCheckIsSeason_OutOfSeason_February() {
            DateTime flightDate = new DateTime(2024, 2, 15);
            bool result = Program.CheckIsSeason(flightDate);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestCheckIsSeason_OutOfSeason_May() {
            DateTime flightDate = new DateTime(2024, 5, 15);
            bool result = Program.CheckIsSeason(flightDate);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestCheckIsSeason_OutOfSeason_October() {
            DateTime flightDate = new DateTime(2024, 10, 15);
            bool result = Program.CheckIsSeason(flightDate);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestCheckIsSeason_OutOfSeason_November() {
            DateTime flightDate = new DateTime(2024, 11, 15);
            bool result = Program.CheckIsSeason(flightDate);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestCheckIsSeason_Border_WinterStart() {
            DateTime flightDate = new DateTime(2024, 12, 20);
            bool result = Program.CheckIsSeason(flightDate);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestCheckIsSeason_Border_WinterEnd() {
            DateTime flightDate = new DateTime(2025, 1, 10);
            bool result = Program.CheckIsSeason(flightDate);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestCheckIsSeason_Border_SpringStart() {
            DateTime flightDate = new DateTime(2024, 3, 20);
            bool result = Program.CheckIsSeason(flightDate);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestCheckIsSeason_Border_SpringEnd() {
            DateTime flightDate = new DateTime(2024, 4, 10);
            bool result = Program.CheckIsSeason(flightDate);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestCheckIsSeason_Border_JuneEnd() {
            DateTime flightDate = new DateTime(2024, 6, 30);
            bool result = Program.CheckIsSeason(flightDate);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestCheckIsSeason_Border_SeptemberStart() {
            DateTime flightDate = new DateTime(2024, 9, 1);
            bool result = Program.CheckIsSeason(flightDate);
            Assert.IsFalse(result);
        }
}