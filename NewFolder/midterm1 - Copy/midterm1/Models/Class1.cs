using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using midterm1.Models;
namespace midterm1.Models
{
    public class Class1
    {
        CarDealerEntities oai = new CarDealerEntities();
        public IEnumerable <Supplier> layds()
        {
            return oai.Supplier.ToList();
        }
        public Supplier Lays(int id)
        {
            return oai.Supplier.First(m => m.Id.CompareTo(id) == 0);
        }
        public void Them( Supplier n)
        {
            oai.Supplier.Add(n);
            oai.SaveChanges();
        }
        public void sua(Supplier n)
        {
            Supplier x = Lays(n.Id);
            x.Name = n.Name;
            x.IsImporter = n.IsImporter;
            oai.SaveChanges();
        }
        public void xoa(int Id)
        {
            Supplier n = Lays(Id);
            oai.Supplier.Remove(n);
            oai.SaveChanges();
        }
    }
}