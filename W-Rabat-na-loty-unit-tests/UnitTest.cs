using Rabat_Na_Loty;

namespace W_Rabat_na_loty_unit_tests;

[TestClass]
public class CalcBasicPromotionTests
{
    [TestMethod]
    public void TestCalcBasicPromotion_AgeLessThan2_Domestic()
    {
        int age = 1;
        bool isDomestic = true;

        int result = Program.CalcBasicPromotion(age, isDomestic);

        Assert.AreEqual(80, result, "Expected 80% discount for domestic flight for age < 2.");
    }

    [TestMethod]
    public void TestCalcBasicPromotion_AgeLessThan2_International()
    {
        int age = 1;
        bool isDomestic = false;

        int result = Program.CalcBasicPromotion(age, isDomestic);

        Assert.AreEqual(70, result, "Expected 70% discount for international flight for age < 2.");
    }

    [TestMethod]
    public void TestCalcBasicPromotion_AgeBetween2And16()
    {
        int[] testAges = { 2, 5, 10, 13, 16 };

        foreach (var age in testAges)
        {
            int resultDomestic = Program.CalcBasicPromotion(age, true);
            int resultInternational = Program.CalcBasicPromotion(age, false);

            Assert.AreEqual(10, resultDomestic, $"Expected 10% for age {age} (domestic flight).");
            Assert.AreEqual(10, resultInternational, $"Expected 10% for age {age} (international flight).");
        }
    }

    [TestMethod]
    public void TestCalcBasicPromotion_AgeGreaterThan16()
    {
        int age = 17;

        int resultDomestic = Program.CalcBasicPromotion(age, true);
        int resultInternational = Program.CalcBasicPromotion(age, false);

        Assert.AreEqual(0, resultDomestic, "Expected 0% for domestic flight for age > 16.");
        Assert.AreEqual(0, resultInternational, "Expected 0% for international flight for age > 16.");
    }
}

[TestClass]
public class AskForDateTests
{
    [TestMethod]
    public void TestAskForDate_ValidDate()
    {
        using var sw = new StringWriter();
        Console.SetOut(sw);
        using var sr = new StringReader("2024-12-25");
        Console.SetIn(sr);

        DateTime result = Program.AskForDate("Podaj datę:");
        Assert.AreEqual(new DateTime(2024, 12, 25), result);
    }

    [TestMethod]
    public void TestAskForDate_InvalidDate()
    {
        using var sw = new StringWriter();
        Console.SetOut(sw);
        using var sr = new StringReader("invalid\n2024-12-25");
        Console.SetIn(sr);

        DateTime result = Program.AskForDate("Podaj datę:");
        Assert.AreEqual(new DateTime(2024, 12, 25), result);

        string output = sw.ToString();
        Assert.IsTrue(output.Contains("Niepoprawny format daty. Spróbuj ponownie."));
    }

    [TestMethod]
    public void TestAskForDate_EmptyInput()
    {
        using var sw = new StringWriter();
        Console.SetOut(sw);
        using var sr = new StringReader("\n2024-12-25");
        Console.SetIn(sr);

        DateTime result = Program.AskForDate("Podaj datę:");
        Assert.AreEqual(new DateTime(2024, 12, 25), result);

        string output = sw.ToString();
        Assert.IsTrue(output.Contains("Niepoprawny format daty. Spróbuj ponownie."));
    }
}

[TestClass]
public class AskForYesNoAnswerTests
{
    [TestMethod]
    public void TestAskForYesNoAnswer_ValidYesAnswer()
    {
        using var sw = new StringWriter();
        Console.SetOut(sw);
        using var sr = new StringReader("t");
        Console.SetIn(sr);

        bool result = Program.AskForYesNoAnswer("Czy lot jest krajowy");
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void TestAskForYesNoAnswer_ValidNoAnswer()
    {
        using var sw = new StringWriter();
        Console.SetOut(sw);
        using var sr = new StringReader("n");
        Console.SetIn(sr);

        bool result = Program.AskForYesNoAnswer("Czy jesteś stałym klientem");
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void TestAskForYesNoAnswer_InvalidAnswer()
    {
        using var sw = new StringWriter();
        Console.SetOut(sw);
        using var sr = new StringReader("invalid\nt");
        Console.SetIn(sr);

        bool result = Program.AskForYesNoAnswer("Czy lot jest krajowy");
        Assert.IsTrue(result);

        string output = sw.ToString();
        Assert.IsTrue(output.Contains("Niepoprawna odpowiedź. Spróbuj ponownie."));
    }

    [TestMethod]
    public void TestAskForYesNoAnswer_EmptyInput()
    {
        using var sw = new StringWriter();
        Console.SetOut(sw);
        using var sr = new StringReader("\nT");
        Console.SetIn(sr);

        bool result = Program.AskForYesNoAnswer("Czy jesteś stałym klientem");
        Assert.IsTrue(result);

        string output = sw.ToString();
        Assert.IsTrue(output.Contains("Niepoprawna odpowiedź. Spróbuj ponownie."));
    }
}

[TestClass]
public class CheckIsSeasonTests
{
    [TestMethod]
    public void TestCheckIsSeason_WinterSeason_Christmas()
    {
        DateTime flightDate = new DateTime(2024, 12, 25);
        bool result = Program.CheckIsSeason(flightDate);
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void TestCheckIsSeason_WinterSeason_NewYear()
    {
        DateTime flightDate = new DateTime(2025, 1, 5);
        bool result = Program.CheckIsSeason(flightDate);
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void TestCheckIsSeason_SpringSeason_Start()
    {
        DateTime flightDate = new DateTime(2024, 3, 22);
        bool result = Program.CheckIsSeason(flightDate);
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void TestCheckIsSeason_SpringSeason_End()
    {
        DateTime flightDate = new DateTime(2024, 4, 5);
        bool result = Program.CheckIsSeason(flightDate);
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void TestCheckIsSeason_Summer_July()
    {
        DateTime flightDate = new DateTime(2024, 7, 15);
        bool result = Program.CheckIsSeason(flightDate);
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void TestCheckIsSeason_Summer_August()
    {
        DateTime flightDate = new DateTime(2024, 8, 20);
        bool result = Program.CheckIsSeason(flightDate);
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void TestCheckIsSeason_OutOfSeason_February()
    {
        DateTime flightDate = new DateTime(2024, 2, 15);
        bool result = Program.CheckIsSeason(flightDate);
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void TestCheckIsSeason_OutOfSeason_May()
    {
        DateTime flightDate = new DateTime(2024, 5, 15);
        bool result = Program.CheckIsSeason(flightDate);
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void TestCheckIsSeason_OutOfSeason_October()
    {
        DateTime flightDate = new DateTime(2024, 10, 15);
        bool result = Program.CheckIsSeason(flightDate);
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void TestCheckIsSeason_OutOfSeason_November()
    {
        DateTime flightDate = new DateTime(2024, 11, 15);
        bool result = Program.CheckIsSeason(flightDate);
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void TestCheckIsSeason_Border_WinterStart()
    {
        DateTime flightDate = new DateTime(2024, 12, 20);
        bool result = Program.CheckIsSeason(flightDate);
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void TestCheckIsSeason_Border_WinterEnd()
    {
        DateTime flightDate = new DateTime(2025, 1, 10);
        bool result = Program.CheckIsSeason(flightDate);
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void TestCheckIsSeason_Border_SpringStart()
    {
        DateTime flightDate = new DateTime(2024, 3, 20);
        bool result = Program.CheckIsSeason(flightDate);
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void TestCheckIsSeason_Border_SpringEnd()
    {
        DateTime flightDate = new DateTime(2024, 4, 10);
        bool result = Program.CheckIsSeason(flightDate);
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void TestCheckIsSeason_Border_JuneEnd()
    {
        DateTime flightDate = new DateTime(2024, 6, 30);
        bool result = Program.CheckIsSeason(flightDate);
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void TestCheckIsSeason_Border_SeptemberStart()
    {
        DateTime flightDate = new DateTime(2024, 9, 1);
        bool result = Program.CheckIsSeason(flightDate);
        Assert.IsFalse(result);
    }
}

[TestClass]
public class PrintDataTests
{
    [TestMethod]
    public void TestPrintData_AllValuesProvided()
    {
        DateTime dateOfBirth = new DateTime(1990, 5, 15);
        DateTime flightDate = new DateTime(2024, 12, 25);
        bool isDomestic = true;
        bool isRegularCustomer = false;
        bool isSeason = true;

        string expectedOutput = "=== Do obliczeń przyjęto:\r\n" +
                                $" * Data urodzenia: {dateOfBirth:dd.MM.yyyy}\r\n" +
                                $" * Data lotu: {flightDate:dddd, d MMMM yyyy}. Lot w sezonie\r\n" +
                                $" * Lot krajowy: {isDomestic}\r\n" +
                                $" * Stały klient: {isRegularCustomer}\r\n";

        using var sw = new StringWriter();
        Console.SetOut(sw);

        Program.PrintData(dateOfBirth, flightDate, isDomestic, isRegularCustomer, isSeason);

        string actualOutput = sw.ToString();
        Assert.AreEqual(expectedOutput, actualOutput);
    }

    [TestMethod]
    public void TestPrintData_LotPozaSezonem()
    {
        DateTime dateOfBirth = new DateTime(1990, 5, 15);
        DateTime flightDate = new DateTime(2024, 12, 25);
        bool isDomestic = true;
        bool isRegularCustomer = true;
        bool isSeason = false;

        string expectedOutput = "=== Do obliczeń przyjęto:\r\n" +
                                $" * Data urodzenia: {dateOfBirth:dd.MM.yyyy}\r\n" +
                                $" * Data lotu: {flightDate:dddd, d MMMM yyyy}. Lot poza sezonem\r\n" +
                                $" * Lot krajowy: {isDomestic}\r\n" +
                                $" * Stały klient: {isRegularCustomer}\r\n";

        using var sw = new StringWriter();
        Console.SetOut(sw);

        Program.PrintData(dateOfBirth, flightDate, isDomestic, isRegularCustomer, isSeason);

        string actualOutput = sw.ToString();
        Assert.AreEqual(expectedOutput, actualOutput);
    }

    [TestMethod]
    public void TestPrintData_RegularCustomerTrue()
    {
        DateTime dateOfBirth = new DateTime(1985, 8, 25);
        DateTime flightDate = new DateTime(2025, 3, 15);
        bool isDomestic = false;
        bool isRegularCustomer = true;
        bool isSeason = true;

        string expectedOutput = "=== Do obliczeń przyjęto:\r\n" +
                                $" * Data urodzenia: {dateOfBirth:dd.MM.yyyy}\r\n" +
                                $" * Data lotu: {flightDate:dddd, d MMMM yyyy}. Lot w sezonie\r\n" +
                                $" * Lot krajowy: {isDomestic}\r\n" +
                                $" * Stały klient: {isRegularCustomer}\r\n";

        using var sw = new StringWriter();
        Console.SetOut(sw);

        Program.PrintData(dateOfBirth, flightDate, isDomestic, isRegularCustomer, isSeason);

        string actualOutput = sw.ToString();
        Assert.AreEqual(expectedOutput, actualOutput);
    }

    [TestMethod]
    public void TestPrintData_AllFalse()
    {
        DateTime dateOfBirth = new DateTime(2000, 1, 1);
        DateTime flightDate = new DateTime(2023, 10, 10);
        bool isDomestic = false;
        bool isRegularCustomer = false;
        bool isSeason = false;

        string expectedOutput = "=== Do obliczeń przyjęto:\r\n" +
                                $" * Data urodzenia: {dateOfBirth:dd.MM.yyyy}\r\n" +
                                $" * Data lotu: {flightDate:dddd, d MMMM yyyy}. Lot poza sezonem\r\n" +
                                $" * Lot krajowy: {isDomestic}\r\n" +
                                $" * Stały klient: {isRegularCustomer}\r\n";

        using var sw = new StringWriter();
        Console.SetOut(sw);

        Program.PrintData(dateOfBirth, flightDate, isDomestic, isRegularCustomer, isSeason);

        string actualOutput = sw.ToString();
        Assert.AreEqual(expectedOutput, actualOutput);
    }
}

[TestClass]
public class PrintResultTests
{
    [TestMethod]
    public void TestPrintResult_WithDiscount()
    {
        int discount = 20;
        string expectedOutputStart = $"Przysługuje Ci rabat w wysokości: {discount}%\r\n";

        using var sw = new StringWriter();
        Console.SetOut(sw);

        Program.PrintResult(discount);

        string actualOutput = sw.ToString();

        Assert.IsTrue(actualOutput.StartsWith(expectedOutputStart));

        string actualDatePart = actualOutput.Substring(actualOutput.IndexOf("Data wygenerowania raportu: "));
        Assert.IsTrue(actualDatePart.StartsWith("Data wygenerowania raportu: "));
    }

    [TestMethod]
    public void TestPrintResult_DiscountZero()
    {
        int discount = 0;
        string expectedOutputStart = $"Przysługuje Ci rabat w wysokości: {discount}%\r\n";

        using var sw = new StringWriter();
        Console.SetOut(sw);

        Program.PrintResult(discount);

        string actualOutput = sw.ToString();

        Assert.IsTrue(actualOutput.StartsWith(expectedOutputStart));

        string actualDatePart = actualOutput.Substring(actualOutput.IndexOf("Data wygenerowania raportu: "));
        Assert.IsTrue(actualDatePart.StartsWith("Data wygenerowania raportu: "));
    }

    [TestMethod]
    public void TestPrintResult_LargeDiscount()
    {
        int discount = 100;
        string expectedOutputStart = $"Przysługuje Ci rabat w wysokości: {discount}%\r\n";

        using var sw = new StringWriter();
        Console.SetOut(sw);

        Program.PrintResult(discount);

        string actualOutput = sw.ToString();

        Assert.IsTrue(actualOutput.StartsWith(expectedOutputStart));

        string actualDatePart = actualOutput.Substring(actualOutput.IndexOf("Data wygenerowania raportu: "));
        Assert.IsTrue(actualDatePart.StartsWith("Data wygenerowania raportu: "));
    }
}

[TestClass]
public class DiscountTests
{
    [TestMethod]
    public void CalcDiscount_NiemowleLotKrajowy_PodstawowyRabat80()
    {
        DateTime dateOfBirth = DateTime.Now.AddYears(-1);
        DateTime flightDate = DateTime.Now.AddMonths(6);
        bool isDomestic = true;
        bool isRegularCustomer = false;
        bool isSeason = true;

        int result = Program.CalcDiscount(dateOfBirth, flightDate, isDomestic, isRegularCustomer, isSeason);

        Assert.AreEqual(80, result);
    }

    [TestMethod]
    public void CalcDiscount_NiemowleLotMiedzynarodowy_PodstawowyRabat70_ZWczesnaRezerwacja()
    {
        DateTime dateOfBirth = DateTime.Now.AddYears(-1);
        DateTime flightDate = DateTime.Now.AddMonths(6);
        bool isDomestic = false;
        bool isRegularCustomer = false;
        bool isSeason = true;

        int result = Program.CalcDiscount(dateOfBirth, flightDate, isDomestic, isRegularCustomer, isSeason);

        Assert.AreEqual(80, result);
    }

    [TestMethod]
    public void CalcDiscount_DzieckoLotKrajowy_PodstawowyRabat10()
    {
        DateTime dateOfBirth = DateTime.Now.AddYears(-10);
        DateTime flightDate = DateTime.Now.AddMonths(2);
        bool isDomestic = true;
        bool isRegularCustomer = false;
        bool isSeason = true;

        int result = Program.CalcDiscount(dateOfBirth, flightDate, isDomestic, isRegularCustomer, isSeason);

        Assert.AreEqual(10, result);
    }

    [TestMethod]
    public void CalcDiscount_DoroslyLotMiedzynarodowyPozaSezonem_15ProcentRabat()
    {
        DateTime dateOfBirth = DateTime.Now.AddYears(-30);
        DateTime flightDate = DateTime.Now.AddMonths(2);
        bool isDomestic = false;
        bool isRegularCustomer = false;
        bool isSeason = false;

        int result = Program.CalcDiscount(dateOfBirth, flightDate, isDomestic, isRegularCustomer, isSeason);

        Assert.AreEqual(15, result);
    }

    [TestMethod]
    public void CalcDiscount_DoroslyStalyKlient_15ProcentRabat()
    {
        DateTime dateOfBirth = DateTime.Now.AddYears(-30);
        DateTime flightDate = DateTime.Now.AddMonths(2);
        bool isDomestic = true;
        bool isRegularCustomer = true;
        bool isSeason = true;

        int result = Program.CalcDiscount(dateOfBirth, flightDate, isDomestic, isRegularCustomer, isSeason);

        Assert.AreEqual(15, result);
    }

    [TestMethod]
    public void CalcDiscount_DzieckoZKumulowanymiRabatami_Maximum30Procent()
    {
        DateTime dateOfBirth = DateTime.Now.AddYears(-10);
        DateTime flightDate = DateTime.Now.AddMonths(6);
        bool isDomestic = false;
        bool isRegularCustomer = true;
        bool isSeason = false;

        int result = Program.CalcDiscount(dateOfBirth, flightDate, isDomestic, isRegularCustomer, isSeason);

        Assert.AreEqual(30, result);
    }
}