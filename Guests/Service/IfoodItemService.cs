using Guests.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guests.Service
{
    internal interface IfoodItemService
    {
        List<FoodItemModel>GetFoodItemsByCategory();

        FoodItemModel? InsertFoodItemInCatgeory(string foodItem, long idCategory);
    }
}
