using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OMP_Epupil
{
    class MY_DB
    {

        // the connection
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-1PTBS8T\TECHCARE; Initial Catalog = Student_DB; Integrated Security = True");


        // get the connection
        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }


        // open the connection
       public void openConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

        }


        // close the connection
       public void closeConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

        }

    }
}
