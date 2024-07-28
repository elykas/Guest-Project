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
    internal class GuestService : IGuestService
    {
        
        //function to find the names in the listbox by letter
        public List<GuestModel> FindByLetters(string letter)
        {
            List<GuestModel> listNames = [];
            string query = "select * from GUESTS where GUEST_NAME like @letter + '%' order by GUEST_NAME ";

            try
            {
                using (SqlConnection connection = new(Connection.connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@letter", letter);//put the value that we get by parameter into the query

                    //call the function to read the resukt of the sql
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        //loop that read the whole db, wich iteration is one row
                        while (reader.Read())
                        {
                            //create a new object from the model class
                            GuestModel guest = new()
                            {
                                Id = reader.GetInt64(0),//the 0 refer to the column of the db
                                GuestName = reader.GetString(1)//the 1 refer to the column of the db
                            };  
                            //add the object into the list of guests names
                            listNames.Add(guest);
                        }
                    }
                 }
            }
            catch (Exception ex)
            {
                    MessageBox.Show(ex.Message);
            }
            return listNames;
        }



        //func to display all names of the guests
        public List<GuestModel> GetAllGuests()
        {
            List<GuestModel> guestsList = [];

            string query = "SELECT * FROM GUESTS";
            try
            {
                using(SqlConnection connect = new SqlConnection(Connection.connectionString)) 
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand(query, connect);
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            GuestModel guest = new()
                            {
                                Id = reader.GetInt64(0),
                                GuestName = reader.GetString(1)
                            };
                            guestsList.Add(guest);
                        }
                    }
                    return guestsList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return guestsList ;
        }

        
        


        //the same function to insert, but here the query check if isn't exists and no the function of the add button
        public GuestModel? InsertIfNotExists(string guest)
        {
            string query = "IF NOT EXISTS (SELECT 1 FROM GUESTS WHERE GUEST_NAME = @name) " +
                "BEGIN  " +
                "  INSERT INTO GUESTS (GUEST_NAME) output inserted.id ," +
                "VALUES (@name) " +
                "end";
            try
            {
                using(SqlConnection connection = new(Connection.connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@name", guest);
                    long id = Convert.ToInt64(cmd.ExecuteScalar());
                    //we check if is insrted or not,
                    //if is insetered the id will be 1 up
                    //if not inseted the query return null and by convert to long is 0
                    if (id != 0)
                    {
                        return new()
                        {
                            Id = id,
                            GuestName = guest
                        };
                    }
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            return null; 
        }


        
    }
}   


