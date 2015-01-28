using int2roman.lib;
using NUnit.Framework;
using System;

namespace int2roman.tests
{
    [TestFixture]
    public class int2roman_tests
    {
        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void ToRoman_Zero()
        {
            int.Parse("0").ToRoman();
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void ToRoman_Negative()
        {
            int.Parse("-1").ToRoman();
        }

        [Test]
        public void ToRoman_ExactSymbolValues()
        {
            Assert.AreEqual("I", int.Parse("1").ToRoman());
            Assert.AreEqual("V", int.Parse("5").ToRoman());
            Assert.AreEqual("X", int.Parse("10").ToRoman());
            Assert.AreEqual("L", int.Parse("50").ToRoman());
            Assert.AreEqual("C", int.Parse("100").ToRoman());
            Assert.AreEqual("D", int.Parse("500").ToRoman());
            Assert.AreEqual("M", int.Parse("1000").ToRoman());
        }

        [Test]
        public void ToRoman_OneToNine()
        {
            Assert.AreEqual("I", int.Parse("1").ToRoman());
            Assert.AreEqual("II", int.Parse("2").ToRoman());
            Assert.AreEqual("III", int.Parse("3").ToRoman());
            Assert.AreEqual("IV", int.Parse("4").ToRoman());
            Assert.AreEqual("V", int.Parse("5").ToRoman());
            Assert.AreEqual("VI", int.Parse("6").ToRoman());
            Assert.AreEqual("VII", int.Parse("7").ToRoman());
            Assert.AreEqual("VIII", int.Parse("8").ToRoman());
            Assert.AreEqual("IX", int.Parse("9").ToRoman());
        }

        [Test]
        public void ToRoman_TenToNineteen()
        {
            Assert.AreEqual("X", int.Parse("10").ToRoman());
            Assert.AreEqual("XI", int.Parse("11").ToRoman());
            Assert.AreEqual("XII", int.Parse("12").ToRoman());
            Assert.AreEqual("XIII", int.Parse("13").ToRoman());
            Assert.AreEqual("XIV", int.Parse("14").ToRoman());
            Assert.AreEqual("XV", int.Parse("15").ToRoman());
            Assert.AreEqual("XVI", int.Parse("16").ToRoman());
            Assert.AreEqual("XVII", int.Parse("17").ToRoman());
            Assert.AreEqual("XVIII", int.Parse("18").ToRoman());
            Assert.AreEqual("XIX", int.Parse("19").ToRoman());
        }

        [Test]
        public void ToRoman_TwentyToTwentyNine()
        {
            Assert.AreEqual("XX", int.Parse("20").ToRoman());
            Assert.AreEqual("XXI", int.Parse("21").ToRoman());
            Assert.AreEqual("XXII", int.Parse("22").ToRoman());
            Assert.AreEqual("XXIII", int.Parse("23").ToRoman());
            Assert.AreEqual("XXIV", int.Parse("24").ToRoman());
            Assert.AreEqual("XXV", int.Parse("25").ToRoman());
            Assert.AreEqual("XXVI", int.Parse("26").ToRoman());
            Assert.AreEqual("XXVII", int.Parse("27").ToRoman());
            Assert.AreEqual("XXVIII", int.Parse("28").ToRoman());
            Assert.AreEqual("XXIX", int.Parse("29").ToRoman());
        }

        [Test]
        public void ToRoman_ThirtyToThirtyNine()
        {
            Assert.AreEqual("XXX", int.Parse("30").ToRoman());
            Assert.AreEqual("XXXI", int.Parse("31").ToRoman());
            Assert.AreEqual("XXXII", int.Parse("32").ToRoman());
            Assert.AreEqual("XXXIII", int.Parse("33").ToRoman());
            Assert.AreEqual("XXXIV", int.Parse("34").ToRoman());
            Assert.AreEqual("XXXV", int.Parse("35").ToRoman());
            Assert.AreEqual("XXXVI", int.Parse("36").ToRoman());
            Assert.AreEqual("XXXVII", int.Parse("37").ToRoman());
            Assert.AreEqual("XXXVIII", int.Parse("38").ToRoman());
            Assert.AreEqual("XXXIX", int.Parse("39").ToRoman());
        }

        [Test]
        public void ToRoman_FortyToFortyNine()
        {
            Assert.AreEqual("XL", int.Parse("40").ToRoman());
            Assert.AreEqual("XLI", int.Parse("41").ToRoman());
            Assert.AreEqual("XLII", int.Parse("42").ToRoman());
            Assert.AreEqual("XLIII", int.Parse("43").ToRoman());
            Assert.AreEqual("XLIV", int.Parse("44").ToRoman());
            Assert.AreEqual("XLV", int.Parse("45").ToRoman());
            Assert.AreEqual("XLVI", int.Parse("46").ToRoman());
            Assert.AreEqual("XLVII", int.Parse("47").ToRoman());
            Assert.AreEqual("XLVIII", int.Parse("48").ToRoman());
            Assert.AreEqual("XLIX", int.Parse("49").ToRoman());
        }

        [Test]
        public void ToRoman_FiftyToFiftyNine()
        {
            Assert.AreEqual("L", int.Parse("50").ToRoman());
            Assert.AreEqual("LI", int.Parse("51").ToRoman());
            Assert.AreEqual("LII", int.Parse("52").ToRoman());
            Assert.AreEqual("LIII", int.Parse("53").ToRoman());
            Assert.AreEqual("LIV", int.Parse("54").ToRoman());
            Assert.AreEqual("LV", int.Parse("55").ToRoman());
            Assert.AreEqual("LVI", int.Parse("56").ToRoman());
            Assert.AreEqual("LVII", int.Parse("57").ToRoman());
            Assert.AreEqual("LVIII", int.Parse("58").ToRoman());
            Assert.AreEqual("LIX", int.Parse("59").ToRoman());
        }

        [Test]
        public void ToRoman_SixtyToSixtyNine()
        {
            Assert.AreEqual("LX", int.Parse("60").ToRoman());
            Assert.AreEqual("LXI", int.Parse("61").ToRoman());
            Assert.AreEqual("LXII", int.Parse("62").ToRoman());
            Assert.AreEqual("LXIII", int.Parse("63").ToRoman());
            Assert.AreEqual("LXIV", int.Parse("64").ToRoman());
            Assert.AreEqual("LXV", int.Parse("65").ToRoman());
            Assert.AreEqual("LXVI", int.Parse("66").ToRoman());
            Assert.AreEqual("LXVII", int.Parse("67").ToRoman());
            Assert.AreEqual("LXVIII", int.Parse("68").ToRoman());
            Assert.AreEqual("LXIX", int.Parse("69").ToRoman());
        }

        [Test]
        public void ToRoman_SeventyToSeventyNine()
        {
            Assert.AreEqual("LXX", int.Parse("70").ToRoman());
            Assert.AreEqual("LXXI", int.Parse("71").ToRoman());
            Assert.AreEqual("LXXII", int.Parse("72").ToRoman());
            Assert.AreEqual("LXXIII", int.Parse("73").ToRoman());
            Assert.AreEqual("LXXIV", int.Parse("74").ToRoman());
            Assert.AreEqual("LXXV", int.Parse("75").ToRoman());
            Assert.AreEqual("LXXVI", int.Parse("76").ToRoman());
            Assert.AreEqual("LXXVII", int.Parse("77").ToRoman());
            Assert.AreEqual("LXXVIII", int.Parse("78").ToRoman());
            Assert.AreEqual("LXXIX", int.Parse("79").ToRoman());
        }

        [Test]
        public void ToRoman_EightyToEightyNine()
        {
            Assert.AreEqual("LXXX", int.Parse("80").ToRoman());
            Assert.AreEqual("LXXXI", int.Parse("81").ToRoman());
            Assert.AreEqual("LXXXII", int.Parse("82").ToRoman());
            Assert.AreEqual("LXXXIII", int.Parse("83").ToRoman());
            Assert.AreEqual("LXXXIV", int.Parse("84").ToRoman());
            Assert.AreEqual("LXXXV", int.Parse("85").ToRoman());
            Assert.AreEqual("LXXXVI", int.Parse("86").ToRoman());
            Assert.AreEqual("LXXXVII", int.Parse("87").ToRoman());
            Assert.AreEqual("LXXXVIII", int.Parse("88").ToRoman());
            Assert.AreEqual("LXXXIX", int.Parse("89").ToRoman());
        }

        [Test]
        public void ToRoman_NinetyToNinetyNine()
        {
            Assert.AreEqual("XC", int.Parse("90").ToRoman());
            Assert.AreEqual("XCI", int.Parse("91").ToRoman());
            Assert.AreEqual("XCII", int.Parse("92").ToRoman());
            Assert.AreEqual("XCIII", int.Parse("93").ToRoman());
            Assert.AreEqual("XCIV", int.Parse("94").ToRoman());
            Assert.AreEqual("XCV", int.Parse("95").ToRoman());
            Assert.AreEqual("XCVI", int.Parse("96").ToRoman());
            Assert.AreEqual("XCVII", int.Parse("97").ToRoman());
            Assert.AreEqual("XCVIII", int.Parse("98").ToRoman());
            Assert.AreEqual("XCIX", int.Parse("99").ToRoman());
        }

        [Test]
        public void ToRoman_FourHundredToFourHundredNine()
        {
            //Spot check five hundred minus hundred substitutions
            Assert.AreEqual("CD", int.Parse("400").ToRoman());
            Assert.AreEqual("CDI", int.Parse("401").ToRoman());
            Assert.AreEqual("CDII", int.Parse("402").ToRoman());
            Assert.AreEqual("CDIII", int.Parse("403").ToRoman());
            Assert.AreEqual("CDIV", int.Parse("404").ToRoman());
            Assert.AreEqual("CDV", int.Parse("405").ToRoman());
            Assert.AreEqual("CDVI", int.Parse("406").ToRoman());
            Assert.AreEqual("CDVII", int.Parse("407").ToRoman());
            Assert.AreEqual("CDVIII", int.Parse("408").ToRoman());
            Assert.AreEqual("CDIX", int.Parse("409").ToRoman());
        }

        [Test]
        public void ToRoman_NineHundredNinetyToNineHundredNinetyNine()
        {
            //Spot check thousand minus hundred substitutions
            Assert.AreEqual("CMXC", int.Parse("990").ToRoman());
            Assert.AreEqual("CMXCI", int.Parse("991").ToRoman());
            Assert.AreEqual("CMXCII", int.Parse("992").ToRoman());
            Assert.AreEqual("CMXCIII", int.Parse("993").ToRoman());
            Assert.AreEqual("CMXCIV", int.Parse("994").ToRoman());
            Assert.AreEqual("CMXCV", int.Parse("995").ToRoman());
            Assert.AreEqual("CMXCVI", int.Parse("996").ToRoman());
            Assert.AreEqual("CMXCVII", int.Parse("997").ToRoman());
            Assert.AreEqual("CMXCVIII", int.Parse("998").ToRoman());
            Assert.AreEqual("CMXCIX", int.Parse("999").ToRoman());
        }

        [Test]
        public void ToRoman_OverAThousand()
        {
            //Spot check over a thousand
            Assert.AreEqual("MI", int.Parse("1001").ToRoman());
            Assert.AreEqual("MMCCXXII", int.Parse("2222").ToRoman());
            Assert.AreEqual("MMMMM", int.Parse("5000").ToRoman());
            Assert.AreEqual("MMMMMMMMMM", int.Parse("10000").ToRoman());
        }
    }
}