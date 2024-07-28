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
    internal class CategoryService : ICategoryService
    {
        public List<CategoryModel> GetAllCategories()
        {
            List < CategoryModel > categoryModels = [];
            string query = "select * from FOOD_CATEGORIES";
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {


                        while (reader.Read())
                        {
                            CategoryModel model = new CategoryModel()
                            {
                                Id = reader.GetInt64(0),
                                CategoryName = reader.GetString(1),
                            };
                            categoryModels.Add(model);

                        }
                    }
                }
                return categoryModels;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return categoryModels;
        }


    }
}
