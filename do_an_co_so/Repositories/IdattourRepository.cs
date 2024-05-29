using do_an_co_so.Models;

namespace do_an_co_so.Repositories
{
    public interface IdattourRepository
    {
        Task<IEnumerable<DatTour>> GetAllAsync();
        Task<DatTour> GetByIdAsync(int id);
        Task AddAsync(DatTour dattour);
        Task UpdateAsync(DatTour dattour);
        Task DeleteAsync(int id);
    }
}
