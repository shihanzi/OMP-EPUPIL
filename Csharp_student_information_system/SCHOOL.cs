using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Csharp_student_information_system
{
    class SCHOOL
    {
        MY_DB mydb = new MY_DB();
        

        //  function to get all courses from the database
        public DataTable getSchoolDetails()
        {

            SqlCommand command = new SqlCommand("SELECT * FROM School", mydb.getConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        // function to check if a score is already asigned to this student on this course
        public bool updateSchool(int scid,string scn, string scadd, string scphone, string scweb, string scemail)
        {
            SqlCommand command = new SqlCommand("UPDATE [dbo].[School] SET [Sid]=@scid,[Schoolname]=@scn,[Address]=@scadd,[Phone]=@scphone,[Web]=@scweb,[Email]=@scemail WHERE id=@Id", mydb.getConnection);

            command.Parameters.Add("@Sid", System.Data.SqlDbType.VarChar).Value = scid;
            command.Parameters.Add("@scn", System.Data.SqlDbType.VarChar).Value = scn;
            command.Parameters.Add("@scadd", System.Data.SqlDbType.Text).Value = scadd;
            command.Parameters.Add("@scphone", System.Data.SqlDbType.VarChar).Value = scphone;
            command.Parameters.Add("@scweb", System.Data.SqlDbType.VarChar).Value = scweb;
            command.Parameters.Add("@scemail", System.Data.SqlDbType.VarChar).Value = scemail;
            


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

    }
    }

