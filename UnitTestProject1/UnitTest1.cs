using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ServicePrs;
using System.Data.Entity;
using Model;
using System.Collections.Generic;
using Supermarket.Models;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        GenericUnitOfWork Unit;


        public UnitTest1()
        {
            Unit = new GenericUnitOfWork(new ModelPrs());
        }

        [TestMethod]
        public void TestMethod1()
        {

            //var xxx = Unit.Resipotory<tblItem>().GetAll();

            List<tblSupplier> data = new List<tblSupplier>();

            DateTime s1 = DateTime.Now;
            var count = 0;

            for (int i = 0; i < 50000; i++)
            {
                tblSupplier newUnit = new tblSupplier();
                newUnit.supplier_id = Guid.NewGuid();
                newUnit.supplier_name = "ship" + i.ToString();
                newUnit.supplier_code = "ship" + i.ToString();
                data.Add(newUnit);

                count++;
                if (count % 100 == 0)
                {
                    Unit.Resipotory<tblSupplier>().InsertBulkManual(data);
                    Unit.Save();

                    Unit = new GenericUnitOfWork(new ModelPrs());
                    data = new List<tblSupplier>();
                }
            }

            DateTime e1 = DateTime.Now;
            var x = (e1 - s1).TotalMinutes;


        }

        [TestMethod]
        public void TestMethod2()
        {

            //var xxx = Unit.Resipotory<tblItem>().GetAll();

            List<tblSupplier> data = new List<tblSupplier>();

            DateTime s1 = DateTime.Now;

            for (int i = 0; i < 50000; i++)
            {
                tblSupplier newUnit = new tblSupplier();
                newUnit.supplier_id = Guid.NewGuid();
                newUnit.supplier_name = "ship" + i.ToString();
                newUnit.supplier_code = "ship" + i.ToString();
                data.Add(newUnit);

            }

            Unit.BulkCopy<tblSupplier>(data);

            DateTime e1 = DateTime.Now;
            var x = (e1 - s1).TotalMinutes;


        }

        [TestMethod]
        public void TestMethod3()
        {
            //var x1 = Unit.Resipotory<Order>().GetAll();

            var x2 = Unit.Resipotory<Order>().GetQueryable()
                .Where(q => q.LineItems.Any(z => z.Total == 40)).ToList();

            var x3 = Unit.Resipotory<Order>().GetQueryable()
               .Where(q => q.LineItems.Any(z => z.Total == 40))
               .Include(q => q.LineItems)
               .ToList();

            var x4 = Unit.Resipotory<Order>().GetQueryable()
          .Include(q => q.LineItems)
           .Where(q => q.LineItems.Any(z => z.Total == 40))
          .ToList();

            var x5 = Unit.Resipotory<Order>().GetQueryable()
                  .Where(q => q.LineItems.Any(z => z.Total == 40))
         .Select(x => new
         {
             p = x,
             r = x.LineItems.Where(y => y.Id == 6)
         })
               .AsEnumerable()
               .Select(x => x.p).ToList()
                 ;


            var x6 = Unit.Resipotory<OrderDetail>().GetQueryable()
                  .Where(z => z.Total == 5)
                  .Include(q => q.MyOrder)
                  .ToList();




            DateTime e1 = DateTime.Now;

        }

        [TestMethod]
        public void TestMethod4()
        {


            var o1 = new Order();
            o1.Id = Unit.Resipotory<Order>().GetAll().Count() + 1;
            o1.Date = DateTime.Now.AddDays(-1);

            o1.LineItems.Add(
                new OrderDetail
                {
                    Id = Unit.Resipotory<OrderDetail>().GetAll().Count() + 1,
                    Product = new Product
                    {
                        Name = "uuu",
                        SKU = "uuu"
                    },
                    Quantity = 80,
                    Total = 40
                }
                );

            o1.LineItems.Add(
           new OrderDetail
           {
               Id = Unit.Resipotory<OrderDetail>().GetAll().Count() + 2,
               Product = new Product
               {
                   Name = "uuu",
                   SKU = "uuuu"
               },
               Quantity = 77,
               Total = 95
           }
           );





            Unit.Resipotory<Order>().Insert(o1);
            Unit.Save();

            DateTime e1 = DateTime.Now;

        }

    }
}