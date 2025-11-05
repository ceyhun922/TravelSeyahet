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

    public List<Destination> DestinationWithRotasionDAL(string userId)
    {
        return _context.Destinations
            .Where(d=>d.UserId ==userId)                 
            .Include(d => d.Rotasions)                      
            .ToList();
    }

    public List<Destination> DestinationWithRotasionDAL(int id)
    {
        return _context.Destinations
        .Where(d => d.DestinationId == id)
        .Include(d => d.Rotasions)
        .ToList();
    }
}
