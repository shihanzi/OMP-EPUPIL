using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace OMP_Epupil
{
    class OMPClass
    {
        MY_DB mydb = new MY_DB();
        
        //  function to insert a new course
        public bool insertClass(string ompclass, string section, string description)
        {

            SqlCommand command = new SqlCommand("INSERT INTO [dbo].[OMPClass] ([Class],[Section],[Description]) VALUES (@Class,@Section,@description)", mydb.getConnection);

            
            command.Parameters.Add("@Class", SqlDbType.VarChar).Value = ompclass;
            command.Parameters.Add("@Section", SqlDbType.VarChar).Value = section;
            command.Parameters.Add("@description", SqlDbType.VarChar).Value = description;

            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //  function to update a class data
        public bool updateClass(int id,string ompclass, string section, string description)
        {

            SqlCommand command = new SqlCommand("UPDATE [dbo].[OMPClass] SET [Class]=@Class,[Section]=@section,[Description]=@description WHERE [Id] = @id", mydb.getConnection);

            command.Parameters.Add("@Id",SqlDbType.VarChar).Value = id;
            command.Parameters.Add("@class", SqlDbType.VarChar).Value = ompclass;
            command.Parameters.Add("@section", SqlDbType.VarChar).Value = section;
            command.Parameters.Add("@description", SqlDbType.VarChar).Value = description;

            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        //  function to remove a course by id
        public bool deleteClass(int Id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [dbo].[OMPClass] WHERE [id] = @Id", mydb.getConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
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

        // function to check if the course name already exists in the database
        public bool checkClassName(int Id,int ompclass, string section, string description)
        {

            //  id <> @cID mean when the id is diffrent of the current course id
            // like if we want to edit only the course description
            SqlCommand command = new SqlCommand("SELECT * FROM OMPClass WHERE Class=@Class And id <> @ID", mydb.getConnection);

            command.Parameters.Add("@Class", SqlDbType.Int).Value = ompclass;
            command.Parameters.Add("@section", SqlDbType.VarChar).Value = section;
            command.Parameters.Add("@description", SqlDbType.VarChar).Value = description;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            if ((table.Rows.Count > 0))
            {
                //  this course name aleready exists
                return false;
            }
            else
            {
                return true;
            }

        }

        //  function to get all courses from the database
        public DataTable getAllClass()
        {

            SqlCommand command = new SqlCommand("SELECT * FROM OMPClass", mydb.getConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }


        //  function to return a subject by id
        public DataTable getClassById(SqlCommand command)
        {

            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        //  function to execute the count query
        string execCount(string query)
        {
            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            mydb.openConnection();
            String count = command.ExecuteScalar().ToString();
            mydb.closeConnection();
            return count;
        }

        //  function to return the total courses in the database
        public string totalClass()
        {
            return execCount("SELECT COUNT(*) FROM [dbo].[OMPClass]");
        }


    }
}

