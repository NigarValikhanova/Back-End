using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApp
{
    public partial class FormStudent : Form
    {
        private readonly FormStudentInfo _formStudentInfo;
        public string Id, Name, Surname, City, Score;
        public FormStudent(FormStudentInfo formStudentInfo)
        {
            InitializeComponent();
            _formStudentInfo = formStudentInfo;
        }

        public void UpdateInfo()
        {
            lblText.Text = "Məlumatları Dəyişdir";
            btnSave.Text = "Dəyişdir";
            txtName.Text = Name;
            txtSurname.Text = Surname;
            txtCity.Text = City;
            txtScore.Text = Score;
        }

        public void SaveInfo()
        {
            lblText.Text = "Tələbə Əlavə Et";
            btnSave.Text = "Yeni Tələbə Əlavə Et";
        }

        public void Clear()
        {
            txtName.Text = txtSurname.Text = txtCity.Text = txtScore.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtName.Text.Trim().Length < 3)
            {
                MessageBox.Show("Tələbə adı boşdur. Minimum 3 hərf");
                return;
            }
            if (txtSurname.Text.Trim().Length < 4)
            {
                MessageBox.Show("Tələbə adı boşdur. Minimum 4 hərf");
                return;
            }
            if (txtCity.Text.Trim().Length < 4)
            {
                MessageBox.Show("Tələbə adı boşdur. Minimum 4 hərf");
                return;
            }
            if (txtScore.Text.Trim().Length == 0)
            {
                MessageBox.Show("Giriş balı qeyd edilməyib");
                return;
            }
            if(btnSave.Text == "Yeni Tələbə Əlavə Et")
            {
                Student std = new Student(txtName.Text.Trim(), txtSurname.Text.Trim(), txtCity.Text.Trim(), txtScore.Text.Trim());
                DbStudent.AddStudent(std);
                Clear();
            }
            if (btnSave.Text == "Dəyişdir")
            {
                Student std = new Student(txtName.Text.Trim(), txtSurname.Text.Trim(), txtCity.Text.Trim(), txtScore.Text.Trim());
                DbStudent.UpdateStudent(std, Id);
            }
            _formStudentInfo.Display();
        }
    }
}
