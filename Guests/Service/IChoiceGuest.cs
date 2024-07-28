using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guests.Service
{
    internal interface IChoiceGuest
    {
        public List<ChoiceGuestModel> GetChoiceGuest(long guestId); 
    }
}
