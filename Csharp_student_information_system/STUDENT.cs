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
    class STUDENT
    {

        MY_DB mydb = new MY_DB();


        //  function to insert a new student
        public bool insertStudent(string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [dbo].[Students] ([Firstname], [Lastname], [DOB],[Gender], [Phone], [Address], [Picture])" + " VALUES (@fn, @ln, @bdt, @gdr, @phn, @adrs, @pic)", mydb.getConnection);

            command.Parameters.Add("@fn", System.Data.SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", System.Data.SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", System.Data.SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", System.Data.SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", System.Data.SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", System.Data.SqlDbType.VarChar).Value = address;
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
        public DataTable getStudents(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

         // function to get all students from database
        public DataTable getAllStudents()
        {

            SqlCommand command = new SqlCommand("SELECT * FROM Students", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

            // function to delete student by id
            public bool deleteStudent(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [dbo].[Students] WHERE [id] = @Id", mydb.getConnection);
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

        //  function to update a student information
        public bool updateStudent(int id, string fname, string lname, DateTime bdate, string gender, string phone, string address, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE [dbo].[Students] SET [Firstname]=@fn,[Lastname]=@ln,[DOB]=@bdt,[Gender]=@gdr,[Phone]=@phn,[Address]=@adrs,[Picture]=@pic WHERE id=@Id", mydb.getConnection);

            command.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", System.Data.SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", System.Data.SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@bdt", System.Data.SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", System.Data.SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@phn", System.Data.SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", System.Data.SqlDbType.VarChar).Value = address;
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

        //  function to return the total students in the database
       public string totalStudent()
        {
            return execCount("SELECT COUNT(*) FROM [dbo].[Students]");
        }

        //  function to return the total Male students in the database
       public string totalMaleStudent()
        {
            return execCount("SELECT COUNT(*) FROM [dbo].[Students] WHERE [Gender] = 'Male'");
        }

        //  function to return the total Female students in the database
       public string totalFemaleStudent()
        {
            return execCount("SELECT COUNT(*) FROM [dbo].[Students] WHERE [Gender] = 'Female'");
        }

    }
}
