using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProject
{
    public class PeopleDal
    {
        public List<People> GetAll()
        {
            using (PeopledbContext context = new PeopledbContext())
            {
                return context.People.ToList();
            }
        }

        public void Save(People people)
        {
            using (PeopledbContext context = new PeopledbContext())
            {
                var entity = context.Entry(people);
                entity.State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Update(People people)
        {
            using (PeopledbContext context = new PeopledbContext())
            {
                var entity = context.Entry(people);
                entity.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(People people)
        {
            using (PeopledbContext context = new PeopledbContext())
            {
                var entity = context.Entry(people);
                entity.State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

    }
}
