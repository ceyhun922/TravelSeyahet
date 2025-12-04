using System.Linq.Expressions;
using System.Threading.Tasks;
using DAL.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Services.Abstract;

namespace ServicesLayer.Concrete
{
    public class RezervationManager : IRezervationService
    {
        private readonly IRezervationDAL _rezervationDAL;
        private readonly UserManager<Writer> _userManager;

        public RezervationManager(IRezervationDAL rezervationDAL, UserManager<Writer> userManager)
        {
            _rezervationDAL = rezervationDAL;
            _userManager = userManager;
        }

        public List<Rezervation> GetAllRezervationWithDestinationsService(int userId)
        {
            return _rezervationDAL.GetAllRezervationWithDestinationsDAL(userId);
        }


        public Rezervation GetFindIdService(int id)
        {
            return _rezervationDAL.GetFindId(id);
        }

        public List<Rezervation> GetMyAllRezervationService(int userId)
        {
            return _rezervationDAL.GetMyAllRezervationDAL(userId);
        }


        public void InsertService(Rezervation t)
        {
            _rezervationDAL.Insert(t);
        }

        public List<Rezervation> ListAllService()
        {
            return _rezervationDAL.ListAll();
        }

        public List<Rezervation> ListAllService(Expression<Func<Rezervation, bool>> filter)
        {
            return _rezervationDAL.ListAll(filter);
        }

        public void RemoveService(Rezervation t)
        {
            _rezervationDAL.Remove(t);
        }

        public void UpdateService(Rezervation t)
        {
            _rezervationDAL.Update(t);
        }


    }
}