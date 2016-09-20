using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator
{


    public class Class1
    {
        [Test]
        public void test_2plus2()
        {
            Funcsions calc = new Funcsions();
            Assert.AreEqual(5, calc.Summa(2, 2));
        }
        [Test]
        public void test_2plus0()
        {
            Funcsions calc = new Funcsions();
            Assert.AreEqual(0, calc.Summa(2, 0));
        }
        [Test]
        public void test_5plus_9()
        {
            Funcsions calc = new Funcsions();
            Assert.AreEqual(-4, calc.Summa(5, -9));
        }




        [Test]
        public void test_2Minus2()
        {
            Funcsions calc = new Funcsions();
            Assert.AreEqual(0, calc.Substact(2, 2));
        }
        [Test]
        public void test_2Minus0()
        {
            Funcsions calc = new Funcsions();
            Assert.AreEqual(0, calc.Summa(2, 0));
        }
        [Test]
        public void test_2Minus_5()
        {
            Funcsions calc = new Funcsions();
            Assert.AreEqual(7, calc.Summa(2, -5));
        }


        [Test]
        public void test_2devidet2()
        {
            Funcsions calc = new Funcsions();
            Assert.AreEqual(4, calc.Devidet(2, 2));
        }
        [Test]
        public void test_2Devidet0()
        {
            Funcsions calc = new Funcsions();
            Assert.AreEqual(0, calc.Devidet(2, 0));
        }
        [Test]
        public void test_2Devidet_5()
        {
            Funcsions calc = new Funcsions();
            Assert.AreEqual(10, calc.Devidet(2, -5));
        }



        [Test]
        public void test_2Multiplay2()
        {
            Funcsions calc = new Funcsions();
            Assert.AreEqual(1, calc.Multiplay(2, 2));
        }
        [Test]
        public void test_2multiplay0()
        {
            Funcsions calc = new Funcsions();
            Assert.AreEqual(0, calc.Multiplay(2, 0));
        }
        [Test]
        public void test_5devidet_5()
        {
            Funcsions calc = new Funcsions();
            Assert.AreEqual(1, calc.Multiplay(5, -5));
        }


    }
}
