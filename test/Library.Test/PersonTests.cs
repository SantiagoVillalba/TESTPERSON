using NUnit.Framework;
using System;
using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Insertá tu código de inicialización aquí
            Person nuevo = new Person ("Santiago","5.146.871-4");
        }

        [Test]
        public void IdFunciona() // Cambiá el nombre para indicar qué estás probando
        {
            
            Equals(IdUtils.IdIsValid(nuevo.ID),true);
            // Insertá tu código  de pruebaaquí
        }
        
        [Test]
        public void IdVacio() // Cambiá el nombre para indicar qué estás probando
        {
            //Console.WriteLine(IdUtils.IdIsValid(""));
            Equals(IdUtils.IdIsValid(""),false);
            // Insertá tu código  de pruebaaquí
        }
        [Test]
        public void IdChecking() // Cambiá el nombre para indicar qué estás probando
        {
            //Console.WriteLine(IdUtils.IdIsValid(""));
            Equals(IdUtils.IdIsValid("5.146.871-5"),false);
            // Insertá tu código  de pruebaaquí
        }

        
    }
}