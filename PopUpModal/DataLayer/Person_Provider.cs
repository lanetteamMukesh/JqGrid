using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
   public class Person_Provider:person
    {

       /* public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }*/

        public static List<person> getAll()
        {
            List<person> lst = null;
            using (MukeshDBEntities med = new MukeshDBEntities())
            {
                lst = (from i in med.person select i).ToList();
            }

            return lst;
        }

        public void AddRecord()
        {
            using (MukeshDBEntities med = new MukeshDBEntities())
            {
                person p = new person();
                p.Name = Name;
                p.Age = Age;
                med.person.Add(p);
                med.SaveChanges();
            }
        }

        public void DeleteRecord()
        {
            using (MukeshDBEntities med = new MukeshDBEntities())
            {
                person p = med.person.Where(c => c.Id == Id).SingleOrDefault();
                med.person.Remove(p);
                med.SaveChanges();
            }
        }

        public void UpdateRecord()
        {
            using (MukeshDBEntities med = new MukeshDBEntities())
            {

                person p = med.person.Where(c=>c.Id==Id).SingleOrDefault();
                p.Name = Name;
                p.Age = Age;
              //  med.person.Add(p);
                med.SaveChanges();

            }
    

        }



    }
}
