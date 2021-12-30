using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using SimpleUI.Models;

namespace SimpleUI.DataAccess
{
    public interface IGuestData
    {
        [Get("/Guests")]
        Task<List<GuestDto>> GetGuests();

        [Get("/Guests/{id}")]
        Task<GuestDto> GetGuest(int id);

        [Post("/Guests")]
        Task CreateGuest([Body] GuestDto guest);

        [Put("/Guests/{id}")]
        Task UpdateGuest(int id, [Body] GuestDto guest);

        [Delete("/Guests/{id}")]
        Task DeleteGuest(int id);
    }
}
