using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMP_Epupil
{
    public static class Ex
    {
        public static void Print(Exception exception)
        {
            try
            {
                MessageBox.Show(exception.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.InnerException.Message);
            }
        }
    }
}
