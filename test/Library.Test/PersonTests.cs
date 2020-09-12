using NUnit.Framework;
using System;
using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        private Person person;
        [SetUp]
        public void Setup()
        {
            
            this.person = new Person ("Santiago","5.146.871-4");
        }

        [Test]
        public void IdFunciona() 
        {
            
            Equals(IdUtils.IdIsValid(person.ID),true);
            
        }
        
        [Test]
        public void IdVacio() 
        {
            
            Equals(IdUtils.IdIsValid(""),false);
            
        }
        [Test]
        public void IdChecking() 
        {
            
            Equals(IdUtils.IdIsValid("5.146.871-5"),false);
            
        }

        [Test]

        public void InvalidName() 
        {
            person.Name="";
            
            Equals(person.Name,"Santiago");
            
        }

        [Test]
        public void ValidName() 
        {
            person.Name="Pedro";
            
            Equals(person.Name,"Pedro");
            
        }

        [Test]
        public void InvalidIdPerson() 
        {
            person.ID="5.146.871-5";
            
            Equals(person.ID,"5.146.871-4");
            
        }

        [Test]
        public void ValidIdPerson() 
        {
            person.ID="5.377.044-0";
            
            Equals(person.ID,"5.377.044-0");
            
        }
        


        
    }
}