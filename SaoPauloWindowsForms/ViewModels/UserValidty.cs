using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaoPauloWindowsForms.ViewModels
{
    class UserValidty
    {
        public static bool DoLogin(string useremail, string password)
        {
            var attemptLogin = DataAccess.AttemptLogin(useremail, password);

            if (attemptLogin != null)
            {
                if (attemptLogin.RoleId == "R")
                {
                    RunnerMenuForm rmf = new RunnerMenuForm();
                    rmf.Size = new Size(720, 480);
                    rmf.StartPosition = FormStartPosition.CenterScreen;
                    rmf.Show();
                }
                else if (attemptLogin.RoleId == "C")
                {
                    CoordinatorMenuForm cmf = new CoordinatorMenuForm();
                    cmf.Size = new Size(720, 480);
                    cmf.StartPosition = FormStartPosition.CenterScreen;
                    cmf.Show();
                }
                else if (attemptLogin.RoleId == "A")
                {
                    AdminMenuForm amf = new AdminMenuForm();
                    amf.Size = new Size(720, 480);
                    amf.StartPosition = FormStartPosition.CenterScreen;
                    amf.Show();
                }
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
