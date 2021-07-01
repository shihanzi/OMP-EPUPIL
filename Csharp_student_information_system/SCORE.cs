using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_student_information_system
{
    class SCORE
    {


        MY_DB mydb = new MY_DB();


        //  function to insert a new score to a student on a specific course
        public bool insertScore(int studentID, int courseID, double scoreValue, string description)
        {
            SqlCommand command = new SqlCommand("INSERT INTO `score`(`student_id`, `course_id`, `student_score`, `description`) VALUES (@sid,@cid,@scr" +
                ",@descr)", mydb.getConnection);
            
            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;
            command.Parameters.Add("@scr", SqlDbType.Float).Value = scoreValue;
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
            SqlCommand command = new SqlCommand("SELECT * FROM `score` WHERE `student_id` = @sid AND `course_id` = @cid", mydb.getConnection);
            
            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentId;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;
            
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
            command.CommandText = "SELECT course.label, AVG(score.student_score) as 'Average Score' FROM course, score WHERE course.id =" +
            " score.course_id GROUP BY course.label";
            
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
            command.CommandText = ("SELECT SCORE.student_id, STUDENT.first_name, STUDENT.last_name, SCORE.course_id, COURSE.label, SCORE." +
            "student_score FROM STUDENT INNER JOIN score on student.id = score.student_id INNER JOIN course on score.course_id = course.id");
            
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            
            DataTable table = new DataTable();
            
            adapter.Fill(table);
            
            return table;
        }


        // get course scores
       public DataTable getCourseScores(int courseId)
       {
           SqlCommand command = new SqlCommand();
           
           command.Connection = mydb.getConnection;
           command.CommandText = ("SELECT SCORE.student_id, STUDENT.first_name, STUDENT.last_name, SCORE.course_id, COURSE.label, SCORE." +
           "student_score FROM STUDENT INNER JOIN score on student.id = score.student_id INNER JOIN course on score.course_id = course.id WHERE score.course_id = " + courseId);
           
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
            SqlCommand command = new SqlCommand("DELETE FROM `score` WHERE `student_id` = @sid AND course_id = @cid", mydb.getConnection);
            
            command.Parameters.Add("@sid", SqlDbType.Int).Value = studentID;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = courseID;
            
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
