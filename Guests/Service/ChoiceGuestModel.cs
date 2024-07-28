using Guests.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guests.Service
{
    internal class ChoiceGuestModel
    {
        public long Id {  get; set; }   
        public long IdGuest {  get; set; }
        public long IdCategory {  get; set; }
        public long IdFoodItem {  get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, IdGuest: {IdGuest}, IdCategory: {IdCategory}, IdFoodItem: {IdFoodItem}";
        }
    }
}
