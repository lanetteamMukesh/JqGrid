using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BussinessLayer
{
   public  class Person_Service
    {

        public static List<person> getAll()
        {

            return Person_Provider.getAll();
        }

        public void AddRecord(string Name,int Age)
        {
            Person_Provider pp = new Person_Provider();
            pp.Name =Name;
            pp.Age = Age;
            pp.AddRecord();
        }

        public void DeleteRecord(int Id)
        {
            Person_Provider pp = new Person_Provider();
            pp.Id = Id;
            pp.DeleteRecord();
        }

        public void Updaterecord(int Id,string Name,int Age)
        {
            Person_Provider pp = new Person_Provider();
            pp.Id = Id;
            pp.Name = Name;
            pp.Age = Age;
            pp.UpdateRecord();
        }

    }
}
