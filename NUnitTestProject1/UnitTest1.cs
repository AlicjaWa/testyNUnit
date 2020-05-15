using NUnit.Framework;
using ConsoleApp1;
using System;

namespace NUnitTestProject1
{
    [TestFixture]
    public class Tests
    {

        Cat cat;

        [SetUp]
        public void setUp() {
        cat = new Cat();
        }

        [Test]
        public void settingCorrectBreedAndCheckMethodResult()
        {
            Boolean result = cat.setBreed("Persian");

            Assert.IsTrue(result);
        }

        [Test]
        public void settingCorrectBreedAndCheckResult()
        {
            String breed = "Persian";
            cat.setBreed(breed);

            Assert.AreEqual(cat.getBreed(), breed);
        }

        [Test]
        public void settingIncorrectBreedAndCheckMethodResult()
        {
            Boolean result = cat.setBreed("PlayStation");

            Assert.IsFalse(result);
        }

        [Test]
        public void settingIncorrectBreedAndCheckResult()
        {
            String breed = "PlayStation";
            cat.setBreed(breed);

            Assert.IsNull(cat.getBreed());
        }


        [Test]
        public void settingNegativeAge()
        {
            Assert.Throws<ArgumentException>(() => cat.setAge(-1));
        }

        [Test]
        public void settingToLargeAge()
        {
            Assert.Throws<ArgumentException>(() => cat.setAge(21));
        }

        [Test]
        public void settingCorrectAge()
        {
            cat.setAge(12);

            Assert.AreEqual(cat.getAge(), 12);
        }
        [Test]
        public void settingTypeOfFur()
        {
            cat.setTypeOfFur(TypeOfFur.LONG);
            Assert.AreEqual(cat.getTypeOfFur(), TypeOfFur.LONG);
        }



    }
}