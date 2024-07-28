using Guests.Configuration;
using Guests.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guests.Service
{
    internal class FoodItemService : IfoodItemService
    {
        public List<FoodItemModel> GetFoodItemsByCategory()
        {
            List<FoodItemModel> ListFoodByCategory = [];
            string query = "SELECT f.* from FOOD_ITEM f " +
                "inner join FOOD_CATEGORIES c on f.CATEGORY_ID = c.id ";

            try
            {
                using(SqlConnection conn = new SqlConnection(Connection.connectionString)) 
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            FoodItemModel food = new FoodItemModel()
                            {
                                Id = reader.GetInt64(0),
                                FoodName = reader.GetString(1),
                                IdCategory = reader.GetInt64(2)
                            };
                            ListFoodByCategory.Add(food);
                        }
                    }
                    return ListFoodByCategory;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ListFoodByCategory;

        }

        public FoodItemModel? InsertFoodItemInCatgeory(string foodName, long idCategory)
        {
            string query = "IF NOT EXISTS (SELECT 1 FROM FOOD_ITEM WHERE FOOD_NAME = @foodName)  " +
                   " BEGIN  " +
                        "INSERT INTO FOOD_ITEM(FOOD_NAME,CATEGORY_ID) output inserted.id " +
                         "VALUES (@foodName,@iCategory) " +
                   " end  ";
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@foodName", foodName);
                    command.Parameters.AddWithValue("@iCategory", idCategory);
                    long id = Convert.ToInt64(command.ExecuteScalar());
                    if (id != 0)
                    {
                        return new()
                        {
                            Id = id,
                            FoodName = foodName,
                            IdCategory = idCategory
                        };
                    }
                        
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
    }
}
