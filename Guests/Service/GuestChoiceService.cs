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
    internal class GuestChoiceService : IChoiceGuest
    {
        public List<ChoiceGuestModel> GetChoiceGuest(long guestId)
        {
            List<ChoiceGuestModel> listChoiceGuestModels = [];

            string query = "select * from GUEST_CHOICE where guest_id = @guestId";
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new(query, conn);
                    cmd.Parameters.AddWithValue("@guestId", guestId);
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ChoiceGuestModel model = new ChoiceGuestModel()
                            {
                                Id = reader.GetInt64(0),
                                IdGuest = reader.GetInt64(1),
                                IdCategory = reader.GetInt64(2),
                                IdFoodItem = reader.GetInt64(3),
                            };
                            listChoiceGuestModels.Add(model);
                        }

                    }
                 return listChoiceGuestModels;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return listChoiceGuestModels;
        }
    }
}
                    
