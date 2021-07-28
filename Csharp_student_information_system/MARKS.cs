using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMP_Epupil
{
    class MARKS
    {


        MY_DB mydb = new MY_DB();


        //  function to insert a new marks to a student on a specific subject
        public bool insertMarks(int studentID, int subjectID, double marksValue, string description)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [dbo].[Marks]([StudentId],[SubjectId],[Marks],[Description]) VALUES (@stid,@suid,@mar" +
                ",@descr)", mydb.getConnection);
            
            command.Parameters.Add("@stid", SqlDbType.Int).Value = studentID;
            command.Parameters.Add("@suid", SqlDbType.Int).Value = subjectID;
            command.Parameters.Add("@mar", SqlDbType.Float).Value = marksValue;
            command.Parameters.Add("@descr", SqlDbType.VarChar).Value = description;
            
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


        // function to check if a score is already asigned to this student on this course
        public bool studentMarksExist(int studentId, int courseID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [dbo].[Marks] WHERE [StudentId] = @stid AND [SubjectId] = @suid", mydb.getConnection);
            
            command.Parameters.Add("@stid", SqlDbType.Int).Value = studentId;
            command.Parameters.Add("@suid", SqlDbType.Int).Value = courseID;
            
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


        // method to get students marks
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


        // method get course marks
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
