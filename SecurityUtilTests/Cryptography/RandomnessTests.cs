using Microsoft.VisualStudio.TestTools.UnitTesting;
using DotNETHeroes.SecurityUtil.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNETHeroes.SecurityUtil.Cryptography.Tests
{
    [TestClass()]
    public class RandomnessTests
    {
        [TestMethod()]
        public void RandomKeyTest()
        {
           var randomKey = Randomness.RandomKey();
           
        }
    }
}