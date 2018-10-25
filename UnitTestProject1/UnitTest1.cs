using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServicePrs;
using Model;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        GenericUnitOfWork Unit ;


        public UnitTest1()
        {
            Unit = new GenericUnitOfWork(new ModelPrs());
        }

        [TestMethod]
        public void TestMethod1()
        {
            
            var xxx = Unit.Resipotory<tblItem>().GetAll();



        }
    }
}
