using FizzBuzzTdd.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTdd.Tests
{
    [TestFixture]
    public class UnitTests
    {//test
        [Test]
        public void When_I_enter_1()
        {
            var sut = new FizzBuzz();
            var actual = sut.Answer(1);

            Assert.AreEqual("1", actual);
        }

        [Test]
        public void When_I_enter_2()
        {
            var sut = new FizzBuzz();
            var actual = sut.Answer(2);

            Assert.AreEqual("1 2", actual);
        }

        [Test]
        public void When_I_enter_3()
        {
            var sut = new FizzBuzz();
            var actual = sut.Answer(3);

            Assert.AreEqual("1 2 Fizz", actual);
        }

        [Test]
        public void When_I_enter_5()
        {
            var sut = new FizzBuzz();
            var actual = sut.Answer(5);

            Assert.AreEqual("1 2 Fizz 4 Buzz", actual);
        }

        [Test]
        public void When_I_enter_15()
        {
            var sut = new FizzBuzz();
            var actual = sut.Answer(15);

            Assert.AreEqual("1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz", actual);
        }
    }
}
