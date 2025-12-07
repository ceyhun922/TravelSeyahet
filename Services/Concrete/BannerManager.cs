using System.Linq.Expressions;
using DAL.Abstract;
using Entities.Concrete;
using Services.Abstract;

namespace Services.Concrete
{
    public class SliderManager : ISliderService
    {
        private readonly ISliderDAL _sliderDAL;

        public SliderManager(ISliderDAL sliderDAL)
        {
            _sliderDAL = sliderDAL;
        }

        public Slider GetFindIdService(int id)
        {
            return _sliderDAL.GetFindId(id);
        }

        public void InsertService(Slider t)
        {
            _sliderDAL.Insert(t);
        }

        public List<Slider> ListAllService()
        {
            return _sliderDAL.ListAll();
        }

        public List<Slider> ListAllService(Expression<Func<Slider, bool>> filter)
        {
            return _sliderDAL.ListAll(filter);
        }

        public void RemoveService(Slider t)
        {
            _sliderDAL.Remove(t);
        }

        public void UpdateService(Slider t)
        {
            _sliderDAL.Update(t);
        }
    }
}