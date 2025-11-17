using DAL.Abstract;
using DAL.Concrete;
using DAL.GenericRepositories;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

public class EFDestinationRepository : GenericRepository<Destination>, IDestinationDAL
{
    protected readonly Context _context;

    public EFDestinationRepository(Context context) : base(context)
    {
        _context = context;
    }

    public List<Destination> AllDestinationSubTourDAL()
    {
        return _context.Destinations.Include(d => d.Tours).ToList();
    }

}
