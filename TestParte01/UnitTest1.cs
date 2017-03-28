using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parte01;
using System.Collections.Generic;
using System.Linq;


namespace TestParte01
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ChangeString()
        {
            //Planteamiento
            string entrada1 = "123 abcd*3";
            string salida1 = "123 bcde*3";
            string entrada2 = "**Casa 52";
            string salida2 = "**Dbtb 52";
            //Prueba
            var changeString = new ChangeString();
            var result1 = changeString.build(entrada1);
            var result2 = changeString.build(entrada2);
            //Afirmacion
            Assert.AreEqual(salida1, result1);
            Assert.AreEqual(salida2, result2);
        }
        [TestMethod]
        public void CompleteRange()
        {
            //Planteamiento
            List<int> entrada1 = new List<int> { 2, 1, 4, 5 };
            List<int> salida1 = new List<int> { 1, 2, 3, 4, 5 };
            List<int> entrada2 = new List<int> { 4, 2, 9 };
            List<int> salida2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> entrada3 = new List<int> { 58, 60, 55 };
            List<int> salida3 = new List<int>();
            for(int i=1;i<=60;i++)
            {
                salida3.Add(i);
            }//{1, 2, ... 54, 55, 56, 57, 58, 59, 60}

            //Prueba
            var completeRange = new CompleteRange();
            var result1 = completeRange.build(entrada1);
            var result2 = completeRange.build(entrada2);
            var result3 = completeRange.build(entrada3);

            //Afirmnacion
            CollectionAssert.AreEqual(salida1,result1);
            CollectionAssert.AreEqual(salida2, result2);
            CollectionAssert.AreEqual(salida3, result3);
            
        }
        [TestMethod]
        public void MoneyParts()
        {
            //Planteamiento
            double entrada1 = 0.1;
            double entrada2 = 0.5;
            double entrada3 = 10.50;

            //Prueba
            var moneyParts = new MoneyParts();
            var result1 = moneyParts.build(entrada1);
            var result2= moneyParts.build(entrada2);
            var result3 = moneyParts.build(entrada3);

            //Afirmacion
            //verificar que el monto ingresado sea igual a la suma de cada grupo de combinaciones
            foreach(var item in result1)
            {
                Assert.AreEqual(entrada1, Math.Round(item.Sum(), 2));
            }
            //verificar que el monto ingresado sea igual a la suma de cada grupo de combinaciones
            foreach (var item in result2)
            {
                Assert.AreEqual(entrada2, Math.Round(item.Sum(), 2));
            }
            //verificar que el monto ingresado sea igual a la suma de cada grupo de combinaciones
            foreach (var item in result3)
            {
                Assert.AreEqual(entrada3, Math.Round(item.Sum(), 2));
            }
        }
    }
}
