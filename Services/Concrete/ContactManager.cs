using System.Linq.Expressions;
using DAL.Abstract;
using Entities.Concrete;
using Services.Abstract;

namespace Services.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDAL _contactDAL;

        public ContactManager(IContactDAL contactDAL)
        {
            _contactDAL = contactDAL;
        }

        public Contact GetFindIdService(int id)
        {
           return _contactDAL.GetFindId(id);
        }

        public void InsertService(Contact t)
        {
            _contactDAL.Insert(t);
        }

        public List<Contact> ListAllService()
        {
            return _contactDAL.ListAll();
        }

        public List<Contact> ListAllService(Expression<Func<Contact, bool>> filter)
        {
            return _contactDAL.ListAll(filter);
        }

        public void RemoveService(Contact t)
        {
            _contactDAL.Remove(t);
        }

        public void UpdateService(Contact t)
        {
           _contactDAL.Update(t);
        }
    }
}