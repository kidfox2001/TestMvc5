using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServicePrs;
using Model;

namespace ConsolePrs
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitOfWorkPrs unit = new UnitOfWorkPrs();

            List<tblItem> items = unit.tblItemRepository.GetAll().ToList();

            foreach (var item in items)
            {
                Console.WriteLine(item.item_name);
            }


            Console.Read();

        }
    }
}
