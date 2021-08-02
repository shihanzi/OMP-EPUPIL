using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMP_Epupil
{
    class STUDTOCLASS
    {


        MY_DB mydb = new MY_DB();


        //  function to insert a new Sub to a class.
        public bool insertStudToClass(int studenttId, int classID, string section)
        {
            try
            {
                using (var command = new SqlCommand("INSERT INTO StudToClass (studentId,classID,section) VALUES (@studentId,@classID,@section)"))
                {
                    
                    command.Parameters.Add("@studentId", SqlDbType.Int).Value = studenttId;
                    command.Parameters.Add("@classID", SqlDbType.Int).Value = classID;
                    command.Parameters.Add("@section", SqlDbType.VarChar).Value = section;
                    command.Connection = mydb.getConnection;

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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }


        // function to check if a class is already asigned to this subject
        public bool subToStudentExist(int studenttId,int classID,string section)
        {


            SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[StudToClass] WHERE [studentId] = @studentId AND [classID] = @classID AND [section] = @section", mydb.getConnection);

            
            command.Parameters.Add("@studentId", SqlDbType.Int).Value = studenttId;
            command.Parameters.Add("@classID", SqlDbType.Int).Value = classID;
            command.Parameters.Add("@section", SqlDbType.VarChar).Value = section;


            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            if ((table.Rows.Count == 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }



        // method to get the average marks by subject
        public DataTable getAvgMarksBySubject()
        {
            SqlCommand command = new SqlCommand();

            command.Connection = mydb.getConnection;
            command.CommandText = ("SELECT Subjects.Name, AVG (Marks.Marks) as 'Average Score' FROM Subjects, Marks WHERE Subjects.Id = Marks.SubjectId GROUP BY Subjects.Name");


            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }


        // method to get sub to class
        public DataTable getStudToClass()
        {
            SqlCommand command = new SqlCommand();

            command.Connection = mydb.getConnection;
            command.CommandText = ("SELECT * FROM [dbo].[StudToClass]");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        // get subject marks
        public DataTable getSubjectMarks(int subjectId)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = mydb.getConnection;
            command.CommandText = ("SELECT Marks.StudentId, Students.Firstname,Students.Lastname,Marks.SubjectId,Subjects.Name,Marks.Marks FROM ((Marks INNER JOIN Students ON Marks.StudentId = Students.Id)INNER JOIN Subjects ON Marks.SubjectId = Subjects.Id)");

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }


        // get student's scores by id
        public DataTable getStudentMarks(int studentId)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = mydb.getConnection;
            command.CommandText = ("SELECT Marks.StudentId, Students.Firstname,Students.Lastname,Marks.SubjectId,Subjects.Name,Marks.Marks FROM ((Marks INNER JOIN Students ON Marks.StudentId = Students.Id)INNER JOIN Subjects ON Marks.SubjectId = Subjects.Id)");

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        //  function to get all subject from the database
        public DataTable getStudents()
        {

            SqlCommand command = new SqlCommand("SELECT * FROM StudToClass", mydb.getConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }


        // delete score using student id, and course id
        public bool deleteStudtoClass(int ClassID, int studentID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [dbo].[StudToClass] WHERE [ClassId] = @stid AND [studentID] = @suid", mydb.getConnection);

            command.Parameters.Add("@stid", SqlDbType.Int).Value = ClassID;
            command.Parameters.Add("@suid", SqlDbType.Int).Value = studentID;

            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


    }
}
