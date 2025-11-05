using System.Linq.Expressions;
using DAL.Abstract;
using Entities.Concrete;
using ServicesLayer.Abstract;

namespace ServicesLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        private readonly IWriterDAL _writerDAL;

        public WriterManager(IWriterDAL writerDAL)
        {
            _writerDAL = writerDAL;
        }

        public Writer GetFindIdService(int id)
        {
            return _writerDAL.GetFindId(id);
        }

        public void InsertService(Writer t)
        {
            _writerDAL.Insert(t);
        }

        public List<Writer> ListAllService()
        {
            return _writerDAL.ListAll();
        }

        public List<Writer> ListAllService(Expression<Func<Writer, bool>> filter)
        {
            return _writerDAL.ListAll(filter);
        }

        public void RemoveService(Writer t)
        {
            _writerDAL.Remove(t);
        }

        public void UpdateService(Writer t)
        {
            _writerDAL.Update(t);
        }
    }
}