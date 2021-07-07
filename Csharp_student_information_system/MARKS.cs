using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_student_information_system
{
    class MARKS
    {


        MY_DB mydb = new MY_DB();


        //  function to insert a new marks to a student on a specific subject
        public bool insertScore(int studentID, int subjectID, double marksValue, string description)
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
        public bool studentScoreExist(int studentId, int courseID)
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


        // function to get the average score by course
        public DataTable getAvgScoreByCourse()
        {
            SqlCommand command = new SqlCommand();
            
            command.Connection = mydb.getConnection;
            command.CommandText = "SELECT Subject.label, AVG(Marks.Students_Marks) as 'Average Score' FROM Subjects, score WHERE subject.id =" +
            " Marks.Subjects_id GROUP BY Subjects.label";
            
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            
            DataTable table = new DataTable();
            
            adapter.Fill(table);
            
            return table;
        }


        // function to get students score
       public DataTable getStudentsScore()
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
       public DataTable getCourseScores(int subjectId)
       {
           SqlCommand command = new SqlCommand();
           
           command.Connection = mydb.getConnection;
           command.CommandText = ("SELECT Marks.StudentId, Students.Firstname,Students.Lastname, Marks.course_id, COURSE.label, SCORE." +
           "student_score FROM STUDENT INNER JOIN score on student.id = score.student_id INNER JOIN course on score.course_id = course.id WHERE score.course_id = " + subjectId);
           
           SqlDataAdapter adapter = new SqlDataAdapter(command);
           
           DataTable table = new DataTable();
           
           adapter.Fill(table);
           
           return table;
       }


        // get student's scores by id
       public DataTable getStudentScores(int studentId)
       {
           SqlCommand command = new SqlCommand();
           
           command.Connection = mydb.getConnection;
           command.CommandText = ("SELECT SCORE.student_id, STUDENT.first_name, STUDENT.last_name, SCORE.course_id, COURSE.label, SCORE." +
           "student_score FROM STUDENT INNER JOIN score on student.id = score.student_id INNER JOIN course on score.course_id = course.id WHERE score.student_id = " + studentId);
           
           SqlDataAdapter adapter = new SqlDataAdapter(command);
           
           DataTable table = new DataTable();
           
           adapter.Fill(table);
           
           return table;
       }


        // delete score using student id, and course id
        public bool deleteScore(int studentID, int courseID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [dbo].[Marks] WHERE [StudentId] = @stid AND [SubjectId] = @suid", mydb.getConnection);
            
            command.Parameters.Add("@stid", SqlDbType.Int).Value = studentID;
            command.Parameters.Add("@suid", SqlDbType.Int).Value = courseID;
            
            mydb.openConnection();
            
            if ( command.ExecuteNonQuery() == 1 )
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
