using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guests.Models
{
    internal class GuestModel
    {
        public long Id { get; set; }
        public string GuestName { get; set; }


        public override string ToString()
        {
            return $"Id: {Id}, GuestName: {GuestName} ";
        }
    }
}
