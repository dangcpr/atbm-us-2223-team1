using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace QLDeAn
{
    public partial class RoleUI : UserControl
    {
        public RoleUI()
        {
            InitializeComponent();
        }

        private void grantRole_Click(object sender, EventArgs e)
        {
            GrantRole_F grantRole = new GrantRole_F();
            grantRole.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
