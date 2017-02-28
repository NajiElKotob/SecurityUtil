using Microsoft.VisualStudio.TestTools.UnitTesting;
using DotNETHeroes.SecurityUtil.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DotNETHeroes.SecurityUtil.Cryptography.Tests
{
    [TestClass()]
    public class RandomnessTests
    {
        [TestMethod()]
        public void RandomKeyTest()
        {
            int expected = 30; //Length of string
            var actual = Randomness.RandomKey().Length;
            Assert.AreEqual(expected , actual);

        }

        [TestMethod()]
        public void GenerateNewGuidTest()
        {
            //References:
            //GUID Patterns http://www.regexlib.com/Search.aspx?k=guid

            string expected = @"^\{?[a-fA-F\d]{8}-?([a-fA-F\d]{4}-?){3}[a-fA-F\d]{12}\}?$"; // GUID Pattern 
            string actual = Randomness.GenerateNewGuid(); //Digits only - 32 characters
            Regex rgx = new Regex(expected, RegexOptions.None);
            
            Assert.IsTrue(rgx.IsMatch(actual));
        }
    }
}