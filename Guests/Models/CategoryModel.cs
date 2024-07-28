using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guests.Models
{
    internal class CategoryModel
    {
        public long Id { get; set; }
        public string CategoryName { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Category{CategoryName}";
        }
    }

    
}
