using DAL.Abstract;
using DAL.Concrete;
using DAL.GenericRepositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

public class EFDestinationRepository : GenericRepository<Destination>, IDestinationDAL
{
    protected readonly Context _context;

    public EFDestinationRepository(Context context) : base(context)
    {
        _context = context;
    }

   /*  public List<Destination> AllDestinationWithTourDAL()
    {
        return _context.Destinations.Include(x => x.Tours).ToList();
    } */



    /*     public List<Destination> AllDestinationWithRotationDAL()
        {
            return _context.To.Include(d => d.Rotasions).ToList();

        } */
}
