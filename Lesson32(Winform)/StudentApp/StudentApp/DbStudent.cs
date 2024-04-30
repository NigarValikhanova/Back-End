using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApp
{
    internal class DbStudent
    {
        public static SqlConnection GetConnection()
        {
            string sql = "Data Source=DESKTOP-RJOSFU4\\SQLEXPRESS;Initial Catalog=MyWorks;Integrated Security=True";
            SqlConnection connection = new SqlConnection(sql);
            try
            {
                connection.Open();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Sql Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
            return connection;
        }

        public static void AddStudent(Student std)
        {
            string sql = "INSERT INTO STUDENTS VALUES (@Name, @Surname, @City, @Score)";
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = std.Name;
            sqlCommand.Parameters.Add("@Surname", SqlDbType.NVarChar).Value = std.Surname;
            sqlCommand.Parameters.Add("@City", SqlDbType.NVarChar).Value = std.City;
            sqlCommand.Parameters.Add("@Score", SqlDbType.NVarChar).Value = std.Score;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Tələbə Əlavə Edildi", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Əlavə Olunmadı. \n" + ex.Message, "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void UpdateStudent(Student std, string Id)
        {
            string sql = "UPDATE Students SET Name = @Name, Surname = @Surname, City = @City, Score = @Score WHERE Id = @Id";
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Parameters.Add("@Id", SqlDbType.NVarChar).Value = Id;
            sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = std.Name;
            sqlCommand.Parameters.Add("@Surname", SqlDbType.NVarChar).Value = std.Surname;
            sqlCommand.Parameters.Add("@City", SqlDbType.NVarChar).Value = std.City;
            sqlCommand.Parameters.Add("@Score", SqlDbType.NVarChar).Value = std.Score;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Tələbə Məlumatları Dəyişdirildi", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Dəyişiklik Olunmadı. \n" + ex.Message, "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void DeleteStudent(string Id)
        {
            string sql = "DELETE FROM STUDENTS WHERE Id = @Id";
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Parameters.Add("@Id", SqlDbType.NVarChar).Value = Id;
            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Tələbə Məlumatları Silindi", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Silinmədi. \n" + ex.Message, "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }

        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            SqlConnection connection = GetConnection();
            SqlCommand sqlCommand = new SqlCommand(sql, connection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable table = new DataTable();
            sqlDataAdapter.Fill(table);
            dgv.DataSource = table;
            connection.Close();
        }
    }
}
