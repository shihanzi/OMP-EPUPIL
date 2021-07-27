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
        public bool insertSubToClass(int classID, string section, string subject)
        {
            try
            {
                using (var command = new SqlCommand("INSERT INTO SubToClass (ClassId, section, Subject) VALUES (@ClassId, @section, @Subject)"))
                {
                    command.Parameters.Add("@ClassID", SqlDbType.Int).Value = classID;
                    command.Parameters.Add("@Section", SqlDbType.VarChar).Value = section;
                    command.Parameters.Add("@Subject", SqlDbType.VarChar).Value = subject;
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
        public bool subToClassExist(int classId,string section,string Subject)
        {

           
                SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[SubToClass] WHERE [ClassId] = @ClassID AND [Section] = @section", mydb.getConnection);

                command.Parameters.Add("@ClassID", SqlDbType.Int).Value = classId;
                command.Parameters.Add("@section", SqlDbType.VarChar).Value = section;
                command.Parameters.Add("@subject", SqlDbType.VarChar).Value = Subject;

                
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


        // method to get subject
        public DataTable getStudentsMarks()
        {
            SqlCommand command = new SqlCommand();

            command.Connection = mydb.getConnection;
            command.CommandText = ("SELECT Marks.StudentId, Students.Firstname,Students.Lastname,Marks.SubjectId,Subjects.Name,Marks.Marks FROM ((Marks INNER JOIN Students ON Marks.StudentId = Students.Id)INNER JOIN Subjects ON Marks.SubjectId = Subjects.Id)");


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


        // delete score using student id, and course id
        public bool deleteMarks(int studentID, int courseID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [dbo].[Marks] WHERE [StudentId] = @stid AND [SubjectId] = @suid", mydb.getConnection);

            command.Parameters.Add("@stid", SqlDbType.Int).Value = studentID;
            command.Parameters.Add("@suid", SqlDbType.Int).Value = courseID;

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
