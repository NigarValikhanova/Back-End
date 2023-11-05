using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Register_Task_05._11._2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-RJOSFU4\\SQLEXPRESS;Initial Catalog=StudentsRegister;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[StudentsTable]
           ([First Name]
           ,[Last Name]
           ,[Address]
           ,[Gender]
           ,[Email]
           ,[Phone]
           ,[Username]
           ,[Password])
     VALUES
           ('"+txtFname.Text+"', '"+txtLname.Text+"', '"+txtAdd.Text+"', '"+cmGender.SelectedItem.ToString()+"', '"+txtEmail.Text+"', '"+txtPhone.Text+"', '"+txtUsername.Text+"', '"+txtPass.Text+"')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Register Successfully");
        }
    }
}
