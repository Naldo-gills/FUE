using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginAux : Form
    {
        public LoginAux()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DISI04_JC;Initial Catalog=fue_db;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into dbo.login values(@username, @password)", con);
            cmd.Parameters.AddWithValue("@username", txtUser.Text);
            cmd.Parameters.AddWithValue("@password", txtPass.Text);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
