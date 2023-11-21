using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using REQUEST3.Models;
namespace REQUEST3.Models
{
    public class Class1
    {
        CarDealerEntities sup = new CarDealerEntities();
        public IEnumerable<Supplier> layds()
        {
            return sup.Suppliers.ToList();
        }
        public Supplier layid( int id)
        {
            return sup.Suppliers.First(m => m.Id.CompareTo(id) == 0);
        }
        public void Them( Supplier n)
        {
            sup.Suppliers.Add(n);
            sup.SaveChanges();
        }
        public void Sua(Supplier n)
        {
            Supplier x = layid(n.Id);
            x.Name = n.Name;
            x.IsImporter = n.IsImporter;
            sup.SaveChanges();
        }
        public void Xoa(int id)
        {
            Supplier n = layid(id);
            sup.Suppliers.Remove(n);
            sup.SaveChanges();
        }
    }
}