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
    public partial class FormStudentInfo : Form
    {
        FormStudent form;
        public FormStudentInfo()
        {
            InitializeComponent();
            form = new FormStudent(this);
        }

        public void Display()
        {
            DbStudent.DisplayAndSearch("SELECT ID, Name, Surname, City, Score FROM Students", dataGridView);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.SaveInfo();
            form.ShowDialog();
        }

        private void FormStudentInfo_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DbStudent.DisplayAndSearch("SELECT ID, Name, Surname, City, Score FROM Students WHERE Name LIKE'%" + txtSearch.Text + "%' OR Surname LIKE'%" + txtSearch.Text + "%'", dataGridView);

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                //Edit
                form.Clear();
                form.Id = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.Name = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.Surname = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.City = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.Score = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.UpdateInfo();
                form.ShowDialog();

                return;
            }
            if (e.ColumnIndex == 1)
            {
                //Delete
                if(MessageBox.Show("Bu tələbəni silmək istədiyinizdən əminsiniz mi?", "Informasiya", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbStudent.DeleteStudent(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }
    }
}
