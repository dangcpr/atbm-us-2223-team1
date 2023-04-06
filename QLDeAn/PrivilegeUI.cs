using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDeAn
{
    public partial class PrivilegeUI : UserControl
    {
        public PrivilegeUI()
        {
            InitializeComponent();

        }

        private void grantPrivilege_Click(object sender, EventArgs e)
        {
            GrantPrivil_F grantPrivil = new GrantPrivil_F();
            grantPrivil.Show();
        }
    }
}
