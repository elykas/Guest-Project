using Guests.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guests.Service
{
    internal interface IGuestService
    {
        public List<GuestModel> GetAllGuests();


        GuestModel? InsertIfNotExists(string guest);

        List<GuestModel> FindByLetters(string letter);
    }
}
