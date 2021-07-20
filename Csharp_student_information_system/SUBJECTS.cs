using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMP_Epupil
{
    class SUBJECTS
    {


        MY_DB mydb = new MY_DB();


        //  function to insert a new course
    public bool insertSubject(string subjectName, int hoursNumber, string description) {
        
        SqlCommand command = new SqlCommand("INSERT INTO [dbo].[Subjects]([Name],[NOH],[Description]) VALUES (@name,@hrs,@descr)", mydb.getConnection);
       
        command.Parameters.Add("@name", SqlDbType.VarChar).Value = subjectName;
        command.Parameters.Add("@hrs", SqlDbType.Int).Value = hoursNumber;
        command.Parameters.Add("@descr", SqlDbType.VarChar).Value = description;

        mydb.openConnection();

        if ((command.ExecuteNonQuery() == 1)) {
            return true;
        }
        else {
            return false;
        }
        
    }

    //  function to uodate a subject data
    public bool updateSubject(int courseID, string courseName, int hoursNumber, string description) {
        
        SqlCommand command = new SqlCommand("UPDATE [dbo].[Subjects] SET [Name]=@name,[NOH] =@hrs,[Description]=@descr WHERE [Id] = @sid", mydb.getConnection);
        
        command.Parameters.Add("@sid", SqlDbType.Int).Value = courseID;
        command.Parameters.Add("@name", SqlDbType.VarChar).Value = courseName;
        command.Parameters.Add("@hrs", SqlDbType.Int).Value = hoursNumber;
        command.Parameters.Add("@descr", SqlDbType.VarChar).Value = description;
       
        mydb.openConnection();
        
        if ((command.ExecuteNonQuery() == 1)) {
            return true;
        }
        else {
            return false;
        }
        
    }


    //  function to remove a course by id
    public bool deleteSubject(int subjectID) {
       
        SqlCommand command = new SqlCommand("DELETE FROM [dbo].[Subjects] WHERE [Id] = @SID", mydb.getConnection);
       
        command.Parameters.Add("@SID", SqlDbType.Int).Value = subjectID;
       
        mydb.openConnection();
       
        if ( command.ExecuteNonQuery() == 1 ) {
            return true;
        }
        else {
            return false;
        }
        
    }

    // function to check if the course name already exists in the database
    public bool checkSubjectName(string subjectName, int subjectId = 0) {
       
        //  id <> @cID mean when the id is diffrent of the current course id
        // like if we want to edit only the course description
        SqlCommand command = new SqlCommand("SELECT * FROM subjects WHERE Name=@sName And id <> @sID", mydb.getConnection);
       
        command.Parameters.Add("@sName", SqlDbType.VarChar).Value = subjectName;
        command.Parameters.Add("@sID", SqlDbType.Int).Value = subjectId;
       
        SqlDataAdapter adapter = new SqlDataAdapter(command);
       
        DataTable table = new DataTable();
        
        adapter.Fill(table);
       
        if ((table.Rows.Count > 0)) {
            //  this course name aleready exists
            return false;
        }
        else {
            return true;
        }
        
    }

    //  function to get all courses from the database
    public DataTable getAllCourses() {
       
        SqlCommand command = new SqlCommand("SELECT * FROM subjects", mydb.getConnection);
       
        SqlDataAdapter adapter = new SqlDataAdapter(command);
       
        DataTable table = new DataTable();
       
        adapter.Fill(table);
        
        return table;
    }


    //  function to return a subject by id
    public DataTable getSubjectById(int subjectID) {
       
        SqlCommand command = new SqlCommand("SELECT * FROM subjects WHERE id = @sid", mydb.getConnection);
       
        command.Parameters.Add("@sid", SqlDbType.VarChar).Value = subjectID;
       
        SqlDataAdapter adapter = new SqlDataAdapter(command);
       
        DataTable table = new DataTable();
       
        adapter.Fill(table);
       
        return table;
    }


    //  function to execute the count query
    string execCount(string query) {
        SqlCommand command = new SqlCommand(query, mydb.getConnection);
        mydb.openConnection();
        String count = command.ExecuteScalar().ToString();
        mydb.closeConnection();
        return count;
    }
    
    //  function to return the total courses in the database
    public string totalSubjects() {
        return execCount("SELECT COUNT(*) FROM [dbo].[Subjects]");
    }


    }
}
