using System.Linq.Expressions;
using DAL.Abstract;
using Entities.Concrete;
using Services.Abstract;

namespace Services.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDAL _testimonialDAL;

        public TestimonialManager(ITestimonialDAL testimonialDAL)
        {
            _testimonialDAL = testimonialDAL;
        }

        public Testimonial GetFindIdService(int id)
        {
            return _testimonialDAL.GetFindId(id);
        }

        public void InsertService(Testimonial t)
        {
            _testimonialDAL.Insert(t);
        }

        public List<Testimonial> ListAllService()
        {
            return _testimonialDAL.ListAll();
        }

        public List<Testimonial> ListAllService(Expression<Func<Testimonial, bool>> filter)
        {
            return _testimonialDAL.ListAll(filter);
        }

        public void RemoveService(Testimonial t)
        {
            _testimonialDAL.Remove(t);
        }

        public void UpdateService(Testimonial t)
        {
            _testimonialDAL.Update(t);
        }
    }
}