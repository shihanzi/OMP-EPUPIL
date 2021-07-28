using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Data;

namespace OMP_Epupil
{
    class STAFF
    {
       

            MY_DB mydb = new MY_DB();


            //  function to insert a new staff
            public bool insertStaff(string fname, string lname, DateTime bdate, string gender, string phone, string address, string jc, MemoryStream picture)
            {
                SqlCommand command = new SqlCommand("INSERT INTO [dbo].[Staffs] ([First Name], [Last Name], [DOB],[Gender], [Phone], [Address],[Job Category], [Picture])" + " VALUES (@fn, @ln, @bdate, @gdr, @phn, @address,@jc, @pic)", mydb.getConnection);

                command.Parameters.Add("@fn", System.Data.SqlDbType.VarChar).Value = fname;
                command.Parameters.Add("@ln", System.Data.SqlDbType.VarChar).Value = lname;
                command.Parameters.Add("@bdate", System.Data.SqlDbType.DateTime).Value = bdate;
                command.Parameters.Add("@gdr", System.Data.SqlDbType.VarChar).Value = gender;
                command.Parameters.Add("@phn", System.Data.SqlDbType.VarChar).Value = phone;
                command.Parameters.Add("@address", System.Data.SqlDbType.VarChar).Value = address;
                command.Parameters.Add("@jc", System.Data.SqlDbType.VarChar).Value = jc;
                command.Parameters.Add("@pic", System.Data.SqlDbType.Image).Value = picture.ToArray();

                mydb.openConnection();

                if ((command.ExecuteNonQuery() == 1))
                {
                    mydb.closeConnection();
                    return true;
                }
                else
                {
                    mydb.closeConnection();
                    return false;
                }
            }

            // function to get all students from database
            public DataTable getStaffs(SqlCommand command)
            {
                command.Connection = mydb.getConnection;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }

            // function to delete student by id
            public bool deleteStaffs(int id)
            {
                SqlCommand command = new SqlCommand("DELETE FROM [dbo].[Staffs] WHERE [id] = @Id", mydb.getConnection);
                command.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                mydb.openConnection();
                if ((command.ExecuteNonQuery() == 1))
                {
                    mydb.closeConnection();
                    return true;
                }
                else
                {
                    mydb.closeConnection();
                    return false;
                }

            }

            //  function to update a staffs information
            public bool updateStaffs(int id, string fname, string lname, DateTime bdate, string gender, string phone, string address,string jc, MemoryStream picture)
            {
                SqlCommand command = new SqlCommand("UPDATE [dbo].[Staffs] SET [First Name]=@fn,[Last Name]=@ln,[DOB]=@bdt,[Gender]=@gdr,[Phone]=@phn,[Address]=@address,[Job Category]=@jc,[Picture]=@pic WHERE id=@Id", mydb.getConnection);

                command.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = id;
                command.Parameters.Add("@fn", System.Data.SqlDbType.VarChar).Value = fname;
                command.Parameters.Add("@ln", System.Data.SqlDbType.VarChar).Value = lname;
                command.Parameters.Add("@bdt", System.Data.SqlDbType.DateTime).Value = bdate;
                command.Parameters.Add("@gdr", System.Data.SqlDbType.VarChar).Value = gender;
                command.Parameters.Add("@phn", System.Data.SqlDbType.VarChar).Value = phone;
                command.Parameters.Add("@address", System.Data.SqlDbType.VarChar).Value = address;
                command.Parameters.Add("@jc", System.Data.SqlDbType.VarChar).Value = jc;
                command.Parameters.Add("@pic", System.Data.SqlDbType.Image).Value = picture.ToArray();

                mydb.openConnection();

                if ((command.ExecuteNonQuery() == 1))
                {
                    mydb.closeConnection();
                    return true;
                }
                else
                {
                    mydb.closeConnection();
                    return false;
                }

            }

            //  function to execute count query
            string execCount(string query)
            {
                SqlCommand command = new SqlCommand(query, mydb.getConnection);
                mydb.openConnection();

                String count = command.ExecuteScalar().ToString();
                mydb.closeConnection();

                return count;
            }

            //  function to return the total staffs in the database
            public string totalStaff()
            {
                return execCount("SELECT COUNT(*) FROM [dbo].[Staffs]");
            }

            //  function to return the total Male staffs in the database
            public string totalMaleStaff()
            {
                return execCount("SELECT COUNT(*) FROM [dbo].[Staffs] WHERE [Gender] = 'Male'");
            }

            //  function to return the total Female students in the database
            public string totalFemaleStaff()
            {
                return execCount("SELECT COUNT(*) FROM [dbo].[Staffs] WHERE [Gender] = 'Female'");
            }

        }
    }


