using HotelListingAPI.Contracts;
using HotelListingAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelListingAPI.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        public HotelListingDbConext _context { get; }
        public HotelsRepository(HotelListingDbConext context) : base(context)
        {
            this._context = context;
        }

    }
}
