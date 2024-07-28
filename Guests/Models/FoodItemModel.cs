using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guests.Models
{
    internal class FoodItemModel
    {
        public long Id { get; set; }
        public string FoodName { get; set; }
        public long IdCategory { get; set; }

        public override string ToString()
        {
            return $"id: {Id}, foodName: {FoodName}, idCategory: {IdCategory}";
        }
    }
}
