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
    class SUBTOCLASS
    {


        MY_DB mydb = new MY_DB();


        //  function to insert a new Sub to a class.
        public bool insertSubToClass(int classID, string section, int subjectId)
        {
            try
            {
                using (var command = new SqlCommand("INSERT INTO SubToClass (ClassId, section, SubjectId) VALUES (@ClassId, @section, @SubjectId)"))
                {
                    command.Parameters.Add("@ClassID", SqlDbType.Int).Value = classID;
                    command.Parameters.Add("@Section", SqlDbType.VarChar).Value = section;
                    command.Parameters.Add("@SubjectId", SqlDbType.Int).Value = subjectId;
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
        public bool subToClassExist(int classId,string section,int SubjectId)
        {

           
                SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[SubToClass] WHERE [ClassId] = @ClassID AND [Section] = @section AND [SubjectId] = @SubjectId", mydb.getConnection);

                command.Parameters.Add("@ClassID", SqlDbType.Int).Value = classId;
                command.Parameters.Add("@section", SqlDbType.VarChar).Value = section;
                command.Parameters.Add("@subjectId", SqlDbType.Int).Value = SubjectId;

                
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


        // method to get subject to class
        public DataTable getSubToClass()
        {
            SqlCommand command = new SqlCommand();

            command.Connection = mydb.getConnection;
            command.CommandText = ("SELECT * FROM [dbo].[SubToClass]");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        // get course scores
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


        // remove mapping using class id, and subject id
        public bool deleteSubToClass(int classID, int subjectID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [dbo].[SubToClass] WHERE [ClassId] = @stid AND [SubjectId] = @suid", mydb.getConnection);

            command.Parameters.Add("@stid", SqlDbType.Int).Value = classID;
            command.Parameters.Add("@suid", SqlDbType.Int).Value = subjectID;

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
