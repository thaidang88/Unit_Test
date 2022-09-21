using BankAccountPrj;
using NUnit.Framework;

namespace TestBankAccountNUnit
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Debit_WithValidAmount_UpdatesBalance123()
        {
            // Arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // Act
            account.Debit(debitAmount);

            // Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }

        [Test]
        public void SimpleArithmetic()
        {
            int r1 = Arithmetic.add(3, 3);
            Assert.AreEqual(r1, 6);

            int r2 = Arithmetic.sub(3, 3);
            Assert.AreEqual(r2, 0);

            int r3 = Arithmetic.mul(3, 3);
            Assert.AreEqual(r3, 9);

            int r4 = Arithmetic.div(3, 3);
            Assert.AreEqual(r4, 1);
        }

        [Test]
        public void AddSub()
        {
            int r1 = Arithmetic.add(3, 3);
            Assert.AreEqual(r1, 6);

            int r2 = Arithmetic.sub(3, 3);
            Assert.AreEqual(r2, 0);
        }

        [Test]
        [Ignore("Ignoring")]
        public void MulDiv()
        {
            int r3 = Arithmetic.mul(3, 3);
            Assert.AreEqual(r3, 9);

            int r4 = Arithmetic.div(3, 3);
            Assert.AreEqual(r4, 1);
        }

        [TestCase(1, 2, 3)]
        [TestCase(2, 2, 4)]
        [TestCase(-1, 4, 3)]
        public void Add(int x, int y, int z)
        {
            int r = Arithmetic.add(x, y);
            Assert.AreEqual(r, z);
        }

        [TestCase(1, 2, -1)]
        [TestCase(2, 2, 0)]
        [TestCase(3, 2, 1)]
        public void Sub(int x, int y, int z)
        {
            int r = Arithmetic.sub(x, y);
            Assert.AreEqual(r, z);
        }

        [TestCase(9, 3, 27)]
        [TestCase(3, 3, 9)]
        [TestCase(-3, -3, 9)]
        public void Mul(int x, int y, int z)
        {
            int r = Arithmetic.mul(x, y);
            Assert.AreEqual(r, z);
        }

        [TestCase(9, 3, 3)]
        [TestCase(3, 3, 1)]
        [TestCase(8, 2, 4)]
        public void Div(int x, int y, int z)
        {
            int r = Arithmetic.div(x, y);
            Assert.AreEqual(r, z);
        }

        [TestCaseSource(nameof(AddCases))]
        public void AddSource(int x, int y, int z)
        {
            int r = Arithmetic.add(x, y);
            Assert.AreEqual(r, z);
        }

        [TestCaseSource(nameof(SubCases))]
        public void SubSource(int x, int y, int z)
        {
            int r = Arithmetic.sub(x, y);
            Assert.AreEqual(r, z);
        }

        [TestCaseSource(nameof(MulCases))]
        public void MulSource(int x, int y, int z)
        {
            int r = Arithmetic.mul(x, y);
            Assert.AreEqual(r, z);
        }


        [TestCaseSource(nameof(DivCases))]
        public void DivSource(int x, int y, int z)
        {
            int r = Arithmetic.div(x, y);
            Assert.AreEqual(r, z);
        }

        static object[] AddCases =
        {
        new object[] { 1, 2, 3 },
        new object[] { 2, 2, 4 },
        new object[] { -1, 4, 3 }
    };

        static object[] SubCases =
        {
        new object[] { 1, 2, -1 },
        new object[] { 2, 2, 0 },
        new object[] { 3, 2, 1 }
    };

        static object[] MulCases =
        {
        new object[] { 9, 3, 27 },
        new object[] { 3, 3, 9 },
        new object[] { -3, -3, 9 }
    };

        static object[] DivCases =
        {
        new object[] { 9, 3, 3 },
        new object[] { 3, 3, 1 },
        new object[] { 8, 2, 4 }
    };

        [TestCase(1, 2, ExpectedResult = 3)]
        [TestCase(2, 2, ExpectedResult = 4)]
        [TestCase(-1, 4, ExpectedResult = 3)]
        public int Add(int x, int y)
        {
            return Arithmetic.add(x, y);
        }

        [TestCase(1, 2, ExpectedResult = -1)]
        [TestCase(2, 2, ExpectedResult = 0)]
        [TestCase(3, 2, ExpectedResult = 1)]
        public int Sub(int x, int y)
        {
            return Arithmetic.sub(x, y);
        }

        [TestCase(9, 3, ExpectedResult = 27)]
        [TestCase(3, 3, ExpectedResult = 9)]
        [TestCase(-3, -3, ExpectedResult = 9)]
        public int Mul(int x, int y)
        {
            return Arithmetic.mul(x, y);
        }

        [TestCase(9, 3, ExpectedResult = 3)]
        [TestCase(3, 3, ExpectedResult = 1)]
        [TestCase(8, 2, ExpectedResult = 4)]
        public int Div(int x, int y)
        {
            return Arithmetic.div(x, y);
        }
    }
}